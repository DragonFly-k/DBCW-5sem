create or replace package cwClient
as
procedure addClient(fullName nvarchar2, Adress nvarchar2, PhoneNumber nvarchar2, Login nvarchar2, Passw nvarchar2);
procedure getCountOfClientWithSameLogin(checklogin nvarchar2, results OUT number);
procedure checkClientAccount(lg nvarchar2, ps nvarchar2, results out number);
procedure getClienIdAndName(lgin nvarchar2, psd nvarchar2, id_ret out number, fio out nvarchar2);
procedure getNameAndIdEmp(p_cursor IN OUT NOCOPY SYS_REFCURSOR); 
procedure addEquipment(eqname nvarchar2, sernum nvarchar2, descr nvarchar2, eqmakers nvarchar2, eqmodel nvarchar2);
procedure makeOrder(eq_Id number,client_Id number, empl_Id number, status_id number, dateO date);
procedure getEpuipmentIdForOrder(results out number);
procedure showCurrentClientOrders(cl_id number, p_cursor IN OUT NOCOPY SYS_REFCURSOR);
procedure showHistoryClientOrders(cl_id number, p_cursor IN OUT NOCOPY SYS_REFCURSOR);
end cwClient;

create or replace package body cwClient
as 
procedure addClient(fullName nvarchar2, Adress nvarchar2, PhoneNumber nvarchar2, Login nvarchar2, Passw nvarchar2)
as 
begin
insert into Client(fullname, adress,phonenumber, login, passw) values(fullName, Adress, PhoneNumber, Login, encryption_password(Passw));
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addClient ;

procedure getCountOfClientWithSameLogin(checklogin nvarchar2, results OUT number)
as 
begin 
results:=0;
select count(*) into results from Client where Login=checklogin;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getCountOfClientWithSameLogin;

procedure checkClientAccount(lg nvarchar2, ps nvarchar2, results out number)
as 
begin 
results:=0;
select Count(*) into results from client where Login=lg and decryption_password(Passw)=ps;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end checkClientAccount;

procedure getClienIdAndName(lgin nvarchar2, psd nvarchar2, id_ret out number, fio out nvarchar2)
as 
begin
select Id_Client  into id_ret from Client where Login=lgin and decryption_password(Passw)=psd;
select FullName into fio from Client where Login=lgin and decryption_password(Passw)=psd;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getClienIdAndName;

procedure getNameAndIdEmp(p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as  
begin
OPEN p_cursor FOR 
select Id_emp, fullName  from employee;
end getNameAndIdEmp; 

procedure addEquipment(eqname nvarchar2, sernum nvarchar2, descr nvarchar2, eqmakers nvarchar2, eqmodel nvarchar2)
as 
begin
insert into equipment(Ename, SeriaNumber, Description, Maker, EModel) values(eqname,sernum,  descr, eqmakers, eqmodel);
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addEquipment;

procedure getEpuipmentIdForOrder(results out number)
as 
begin  
results:=0;
select max(id_eqp) into results from equipment;
end getEpuipmentIdForOrder;

procedure makeOrder(eq_Id number,client_Id number, empl_Id number, status_id number,  dateO date)
as 
begin
insert into corder(Id_eqp, Id_Client, Id_emp, Id_Status, OrderDate) values(eq_Id ,client_Id , empl_Id , status_id ,  dateO );
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end makeOrder;

procedure showCurrentClientOrders(cl_id number, p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as 
begin
OPEN p_cursor FOR 
select distinct Corder.id_or, corder.orderdate as Дата_Заказа, equipment.ename as Наименование_оборудования, 
  Employee.FULLNAME as Имя_исполнителя, OrderStatus.statusname as Статус_заказа
from Corder
inner join Client on Corder.Id_client = cl_id
inner join  equipment on  corder.id_eqp = equipment.Id_eqp
inner join Employee on Corder.Id_emp = Employee.Id_Emp
inner join OrderStatus on Corder.Id_status = OrderStatus.Id_order
where Corder.Id_status=1 or Corder.Id_status=2;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showCurrentClientOrders;

procedure showHistoryClientOrders(cl_id number, p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as
begin
OPEN p_cursor FOR 
select distinct Corder.id_or, corder.orderdate as Дата_Заказа, equipment.ename as Наименование_оборудования, 
Employee.FULLNAME as Имя_исполнителя, OrderStatus.statusname as Статус_заказа, makers.COSTS as Стоимость
from Corder
inner join Client on Corder.Id_client = cl_id
inner join  equipment on  corder.id_eqp = equipment.Id_eqp
inner join Employee on Corder.Id_emp = Employee.Id_Emp
inner join OrderStatus on Corder.Id_status = OrderStatus.Id_order
inner join Makers on COrder.ID_MAKE = makers.ID_MAKE
where Corder.Id_status=3;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end showHistoryClientOrders;

end cwClient;

--------check----------------------
SET SERVEROUTPUT ON;

begin
cwClient.addclient('Syatkovskaya Katsiaryna Dmitrievna', 'Prushinskih, 34', '+375297631738', 'SedSedSed','Password1');
cwClient.addclient('Syatkovskaya Katsiaryna Dmitrievna', 'Prushinskih, 34', '+375297631738', 'Sed','Pass');
end;

declare
ct number;
begin
cwClient.getCountOfClientWithSameLogin('Sed', ct);
dbms_output.put_line('count = '||ct);
end;

declare
ct3 number;
BEGIN
cwClient.checkClientAccount('SedSedSed', 'Password1',ct3);
dbms_output.put_line('count = '||ct3);
end;

declare 
fio nvarchar2(50);
idd number;
begin
cwClient.getClienIdAndName('Sed','Pass', idd, fio);
dbms_output.put_line('id = '||idd||' fio '|| fio);
end;

declare
cur sys_refcursor;
TYPE zz1  IS RECORD(Id_emp number, fullName nvarchar2(50));  
zz zz1; 
begin  
cwClient.getNameAndIdEmp(cur);
  loop
    fetch cur into zz;
    EXIT when cur%notfound;
    dbms_output.put_line(zz.Id_emp|| zz.fullName);
  end loop;
if cur%isopen then close cur;
end if;    
end;

begin
cwClient.addEquipment('xxxx', '123123','toruble', 1, 'model');
end;

begin
cwClient.makeOrder(1,1,1,1,'10.11.2022');
end;

declare
ct3 number;
BEGIN
cwClient.getEpuipmentIdForOrder(ct3);
dbms_output.put_line('ID_Eqp = '||ct3);
end;

declare 
cur sys_refcursor;
TYPE zz1  IS RECORD(id_or number, orderdate date, ename nvarchar2(150), FULLNAME nvarchar2(150), statusname nvarchar2(150));  -- обязательно надо определить, куда фетчим, это самый скользкий момент
zz zz1;
begin
cwClient.showCurrentClientOrders(1, cur);
  loop
    fetch cur into zz;
    EXIT when cur%notfound;
    dbms_output.put_line('Id order: ' || zz.id_or ||' Дата Заказа: ' || zz.orderdate|| ' Наименование оборудования: ' || zz.ename || ' Имя исполнителя: ' ||zz.FULLNAME || ' Статус заказа: ' || zz.statusname);
  end loop;
if cur%isopen then close cur;
end if;    
end;

declare 
cur sys_refcursor;
TYPE zz1  IS RECORD(id_or number, orderdate date, ename nvarchar2(150), FULLNAME nvarchar2(150), statusname nvarchar2(150), costs number);  
zz zz1;
begin
cwClient.showHistoryClientOrders(1, cur);
  loop
    fetch cur into zz;
    EXIT when cur%notfound;
    dbms_output.put_line('Id order: ' || zz.id_or ||' Дата Заказа: ' || zz.orderdate|| ' Наименование оборудования: ' || zz.ename || ' Имя исполнителя: ' ||zz.FULLNAME || ' Статус заказа: ' || zz.statusname||' Стоимость '|| zz.costs);
  end loop;
if cur%isopen then close cur;
end if;     
end;