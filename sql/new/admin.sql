create or replace package cwAdmin
as
procedure showAllClients;
procedure addVacancy(vacName nvarchar2);
procedure showAllVacancy;
procedure addEmp(fullName nvarchar2, Id_vac  number, PSeria nvarchar2, PNumber nvarchar2,  Adress nvarchar2,PhoneN nvarchar2, StartWorkDate date,  Logi nvarchar2, Passw nvarchar2);
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
vac_count number;
begin 
select count(*) into vac_count from vacancy where vacname =vacancy.vacancyname;
if (vac_count =0) then
 insert into Vacancy(vacancyname) values(vacName);
 commit;
else raise_application_error(-20000, 'vacancy exist');
end if;
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

procedure addEmp(fullName nvarchar2, Id_vac  number, PSeria nvarchar2, PNumber nvarchar2,  Adress nvarchar2,  PhoneN nvarchar2, StartWorkDate date, Logi nvarchar2, Passw nvarchar2)
as
empl_count number;
begin 
select count(*) into empl_count from employee where PNumber = employee.passportnumber and Logi = employee.login and PhoneN= employee.phonenumber; 
if (empl_count =0) then
insert into Employee(fullname, id_vac, passportseria, passportnumber, adress, phonenumber, startworkdate, login, passw) values(fullName, Id_vac, PSeria, PNumber,  Adress,  PhoneN, StartWorkDate, Logi, encryption_password(Passw)); 
 commit;
else raise_application_error(-20000, 'account already exist');
end if;
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

procedure get (ConscriptsOut out sys_refcursor)
as
begin
open ConscriptsOut for
select  id_client, fullname, adress,phonenumber from Client; 
end get;

procedure importXmlDataFromComponents
is
begin
insert into shopofcomponents (comname, price)
select ExtractValue(value(components), '//NAME') as comname,
       ExtractValue(value(components), '//PRICE') as price
from table(XMLSequence(extract(xmltype(bfilename('DIR', 'components_import.xml'),
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
open rc for
select id_client,fullname,adress,phonenumber,login,passw from client;
doc := DBMS_XMLDOM.NewDOMDocument(xmltype(rc));
DBMS_XMLDOM.WRITETOFILE(doc, 'DIR/client_export.xml');
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);      
end exportXmlToClients;

procedure addComponents(componname nvarchar2, compcost number)
as
comp number;
begin 
select count(*) into comp from shopofcomponents where componname= shopofcomponents.comname;
if ( comp =0) then
 insert into ShopOfComponents (ComName, Price) values(componname, compcost);
 commit;
else raise_application_error(-20000, 'component already exsist');
end if;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addComponents;

procedure insert_100k_components
is
begin
for i in 1 .. 100000 
  loop
    cwAdmin.addComponents(i, i);
  end loop;
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end insert_100k_components;

end cwAdmin;

------triggers---------------------
create or replace trigger client_befor_insert
before insert on client
for each row
begin 
dbms_output.put_line('NEW CLIENT!!!');
end;

create or replace trigger empl_befor_insert
before insert on employee
for each row
begin 
dbms_output.put_line('NEW EMPLOYEE!!!');
end;

create or replace trigger ChangeStatusOfOrder
after insert or update of id_status on COrder
for each row
begin 
case
 WHEN INSERTING THEN
   DBMS_OUTPUT.PUT_LINE('Inserting order: '||'new.id_order = '||:new.id_or||'new.id_status = '||:new.id_status);
 WHEN UPDATING('id_status') THEN
   DBMS_OUTPUT.PUT_LINE('Updating status of order '||'old status = '||:old.id_status||' new status = '||:new.id_status);
end case;
end;

--------check----------------------
SET SERVEROUTPUT ON;

begin
cwAdmin.showallclients;
cwAdmin.showallvacancy;
cwAdmin.showallemp; 
cwAdmin.showallorderstatus;
end;

declare
rf sys_refcursor;
type cl is record(id_client number, fullname nvarchar2(150), adress nvarchar2(150),phonenumber nvarchar2(140));
rec cl; 
begin
cwAdmin.get(rf);
  loop
    fetch rf into rec;
    exit when rf%notfound;
    dbms_output.put_line(rec.id_client|| ' ' ||rec. fullname|| ' ' ||rec.adress|| ' ' ||rec.phonenumber );
  end loop;
close rf;
end;

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
cwAdmin.addemp('Katty Katty Katyy', 2, '2827829M823181', 'HB988981218', 'Yakuba Kolasa 122', '37626722148', '3.12.2003', 'Katty', 'Katty');
cwAdmin.addemp('Сятковская Екатерина Дмитриевна', 1, 'p823181', 'PBD55A54', 'Прушинских-4', '80297631738', '20-09-2022', 'Ks7631738', 'Ks7631738');
end;

---create dir for export--------------------
create or replace directory  DIR as 'C:\XML';
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
explain plan for select Id_com, comname, price  from ShopOfComponents order by id_com;
select * from table(DBMS_XPLAN.DISPLAY());

-------encrypt---------------
CREATE OR REPLACE FUNCTION encryption_password(emp_passw IN employee.passw%TYPE) RETURN employee.passw%TYPE
IS
l_key VARCHAR2(2000) := '0710196810121972';
l_in_val VARCHAR2(2000) := emp_passw;
l_mod NUMBER := DBMS_CRYPTO.encrypt_aes128 + DBMS_CRYPTO.chain_cbc + DBMS_CRYPTO.pad_pkcs5;
l_enc RAW(2000);
BEGIN
l_enc := DBMS_CRYPTO.encrypt(utl_i18n.string_to_raw(l_in_val, 'AL32UTF8'), l_mod, utl_i18n.string_to_raw(l_key, 'AL32UTF8'));
RETURN RAWTOHEX(l_enc);
END encryption_password;

CREATE OR REPLACE FUNCTION decryption_password(emp_passw IN employee.passw%TYPE) RETURN employee.passw%TYPE
IS
l_key VARCHAR2(2000) := '0710196810121972';
l_in_val RAW(2000) := HEXTORAW(emp_passw);
l_mod NUMBER := DBMS_CRYPTO.encrypt_aes128 + DBMS_CRYPTO.chain_cbc + DBMS_CRYPTO.pad_pkcs5;
l_dec RAW(2000);
BEGIN
l_dec := DBMS_CRYPTO.decrypt(l_in_val, l_mod, utl_i18n.string_to_raw(l_key, 'AL32UTF8'));
RETURN utl_i18n.raw_to_char(l_dec);
END decryption_password;



