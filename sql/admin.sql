create or replace package cwAdmin
as
procedure showAllClients;
procedure addVacancy(vacName nvarchar2);
procedure showAllVacancy;
procedure addEmp(fullName nvarchar2, Id_vac  number, PassportSeria nvarchar2, PassportNumber nvarchar2,  Adress nvarchar2,
                PhoneNumber nvarchar2, StartWorkDate date,  Login nvarchar2, Passw nvarchar2);
procedure showAllEmp;
procedure addStatus(stName nvarchar2);
procedure showAllOrderStatus;
procedure get (ConscriptsOut out sys_refcursor);
procedure importXmlDataFromComponents;
procedure exportXmlToClients;
procedure addComponents(componname nvarchar2, compcost number);
procedure insert_100k_components;
end cwAdmin;

create or replace package body cwAdmin
as

procedure showAllClients
as begin
for client in (select id_client, fullname, adress,phonenumber from Client)
  loop
    dbms_output.put_line(client.id_client|| ' ' ||client. fullname|| ' ' ||client.adress|| ' ' ||client.phonenumber); 
  end loop;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showAllClients ;

procedure addVacancy(vacName nvarchar2)
as
begin 
  insert into Vacancy(vacancyname) values(vacName);
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addVacancy;

procedure showAllVacancy
as
begin
for vac in (select * from Vacancy)
  loop  
    dbms_output.put_line(vac.Id_Vac|| ' ' ||vac.VacancyName); 
  end loop;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showAllVacancy;

procedure addEmp(fullName nvarchar2, Id_vac  number, PassportSeria nvarchar2, PassportNumber nvarchar2,  Adress nvarchar2,  PhoneNumber nvarchar2, StartWorkDate date, Login nvarchar2, Passw nvarchar2)
as
begin 
  insert into Employee(fullname, id_vac, passportseria,passportnumber,adress,phonenumber,startworkdate, login, passw) values(fullName, Id_vac, PassportSeria, PassportNumber,  Adress,  PhoneNumber, StartWorkDate, Login, encryption_password(Passw)); 
  commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addEmp;

procedure showAllEmp
as
begin
for emp in (select fullname, id_vac, passportseria,passportnumber,adress,phonenumber,startworkdate from Employee)
  loop
    dbms_output.put_line(emp.fullname|| ' ' ||emp.passportseria|| ' ' ||emp.passportnumber|| ' ' ||emp.adress|| ' ' ||emp.phonenumber|| ' ' ||to_char(emp.startworkdate,'DD-MM-YYYY')); 
  end loop;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showAllEmp;

procedure addStatus(stName nvarchar2)
as
begin
  insert into OrderStatus(StatusName) values(stName);
  commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addStatus;

procedure showAllOrderStatus
as
begin
for status in (select StatusName from OrderStatus)
  loop
    dbms_output.put_line(status.statusName); 
  end loop;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showAllOrderStatus;

PROCEDURE GET (ConscriptsOut OUT sys_refcursor)
as
BEGIN
OPEN ConscriptsOut FOR 
SELECT  id_client, fullname, adress,phonenumber FROM  Client; 
end GET;

procedure importXmlDataFromComponents
IS
BEGIN
INSERT INTO shopofcomponents (comname, price)
SELECT ExtractValue(VALUE(components), '//NAME') AS comname,
       ExtractValue(VALUE(components), '//PRICE') AS price
FROM TABLE(XMLSequence(EXTRACT(XMLTYPE(bfilename('DIR', 'components_import.xml'),
           nls_charset_id('UTF-8')),'/ROWSET/ROW'))) components;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end importXmlDataFromComponents;

procedure exportXmlToClients
is 
rc sys_refcursor;
doc DBMS_XMLDOM.DOMDocument;
begin
OPEN rc FOR 
SELECT id_client,fullname,adress,phonenumber,login,passw FROM client;
doc := DBMS_XMLDOM.NewDOMDocument(XMLTYPE(rc));
DBMS_XMLDOM.WRITETOFILE(doc, 'DIR/client_export.xml');
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);      
end exportXmlToClients;

procedure addComponents(componname nvarchar2, compcost number)
as
begin 
insert into ShopOfComponents (ComName, Price) values(componname, compcost);
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addComponents;

procedure insert_100k_components
is
begin
for i in 1 .. 100000 
  loop
    cwAdmin.addComponents('ComName', i);
  end loop;
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end insert_100k_components;

end cwAdmin;

--------check----------------------
SET SERVEROUTPUT ON;

begin
cwAdmin.showallclients;
cwAdmin.showallvacancy;
cwAdmin.addemp('Katty Katty', 2,'2827829M823181', 'HB988981218','Yakuba Kolasa 122','+37626722148', '3.12.2003', 'Kat','Katty');
cwAdmin.showallemp; 
cwAdmin.showallorderstatus;
end;

DECLARE
 C_EMP SYS_REFCURSOR;
 TYPE new_type IS RECORD(id_client number, fullname nvarchar2(150), adress nvarchar2(150),phonenumber nvarchar2(140));
 L_REC new_type; 
BEGIN
cwAdmin.GET(C_EMP);
  LOOP
    FETCH c_emp INTO l_rec;
    EXIT WHEN c_emp%NOTFOUND;
    dbms_output.put_line(l_rec.id_client|| ' ' ||l_rec. fullname|| ' ' ||l_rec.adress|| ' ' ||l_rec.phonenumber );
  END LOOP;
CLOSE c_emp;
END;

begin
cwAdmin.importXmlDataFromComponents;
end;

--delete from shopofcomponents where id_com >10; 

begin
cwAdmin.exportXmlToClients;
end;

begin
cwAdmin.insert_100k_components;
end;
--select count(*) from shopofcomponents;

-------add data------------------------------
begin
cwAdmin.addstatus('новый');
cwAdmin.addstatus('в обработке');
cwAdmin.addstatus('завершен');
end;

begin
cwAdmin.addvacancy('мастер');
cwAdmin.addvacancy('стажер');
end;

begin
cwAdmin.addComponents('защитное стекло',500);
cwAdmin.addComponents('фронтальная камера',900);
cwAdmin.addComponents('корпус на iphoneX',1500);
cwAdmin.addComponents('процессор',5000);
cwAdmin.addComponents('ram',1600);
end;

begin
cwAdmin.addemp('Katty Katty Katyy', 2,'2827829M823181', 'HB988981218','Yakuba Kolasa 122','+37626722148', '3.12.2003', 'Katty','Katty');
cwAdmin.addemp('Сятковская Екатерина Дмитриевна',1,'MB55555','PBD55A54','Прушинских-4','80297631738','20-09-2022','Ks7631738','Ks7631738');
end;

---create dir for export--------------------
CREATE OR REPLACE DIRECTORY  DIR AS 'C:\XML';
select directory_name from all_directories where directory_path = 'C:\XML';

-------users---------------------------
alter session set "_ORACLE_SCRIPT"=true; 
create role RLClient;
grant create session to RLClient;
grant execute on cwClient to RLClient;

create role RLEmpl;
grant create session to RLEmpl;
grant execute on cwEmpl to RLEmpl;

create user C##Client identified by Password123;
create user C##Employee identified by Password123;

grant RLClient to C##Client;
grant RLEmpl to C##Employee;

drop user C##Client cascade;
drop user C##Employee cascade;
--select * from all_users;
-------plan--------------------------
EXPLAIN PLAN FOR select * from shopofcomponents;
SELECT * FROM TABLE(DBMS_XPLAN.DISPLAY());

-------encrypt---------------
CREATE OR REPLACE FUNCTION encryption_password
(emp_passw IN employee.passw%TYPE)
RETURN employee.passw%TYPE
IS
l_key VARCHAR2(2000) := '0710196810121972';
l_in_val VARCHAR2(2000) := emp_passw;
l_mod NUMBER := DBMS_CRYPTO.encrypt_aes128 + DBMS_CRYPTO.chain_cbc + DBMS_CRYPTO.pad_pkcs5;
l_enc RAW(2000);
BEGIN
l_enc := DBMS_CRYPTO.encrypt(utl_i18n.string_to_raw(l_in_val, 'AL32UTF8'), l_mod, utl_i18n.string_to_raw(l_key, 'AL32UTF8'));
RETURN RAWTOHEX(l_enc);
END encryption_password;

CREATE OR REPLACE FUNCTION decryption_password
(emp_passw IN employee.passw%TYPE)
RETURN employee.passw%TYPE
IS
l_key VARCHAR2(2000) := '0710196810121972';
l_in_val RAW(2000) := HEXTORAW(emp_passw);
l_mod NUMBER := DBMS_CRYPTO.encrypt_aes128 + DBMS_CRYPTO.chain_cbc + DBMS_CRYPTO.pad_pkcs5;
l_dec RAW(2000);
BEGIN
l_dec := DBMS_CRYPTO.decrypt(l_in_val, l_mod, utl_i18n.string_to_raw(l_key, 'AL32UTF8'));
RETURN utl_i18n.raw_to_char(l_dec);
END decryption_password;



