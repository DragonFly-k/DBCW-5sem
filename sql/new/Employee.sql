create or replace package cwPack2
as
procedure checkEmpAccount(login1 nvarchar2, pass1 nvarchar2, results out number);
procedure getCurrentEmplIdAndName(lgine nvarchar2, psde nvarchar2, id_rete out number, fioe out nvarchar2);
procedure getComponentsNameAndId(p_cursor IN OUT NOCOPY SYS_REFCURSOR);
procedure getClientOrdersForEmployeeToDo(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR);
procedure changeOrderStatus(idor number);
procedure getClientOrdersForEmployee(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR);
procedure addMakers(repairtype nvarchar2, price number, repairdate date);
procedure getLastMakers(idmk out number);
procedure changeStatusAndMakers(ior number, idmk number);
procedure getOrdersHistoryForEmployee(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR);
procedure addComponentsOrder(idcomp number, idmaker number);
end cwPack2;

create or replace package body cwPack2
as
procedure checkEmpAccount(login1 nvarchar2, pass1 nvarchar2, results out number)
as 
begin 
results:=0;
select count(*) into results from employee where (Login=login1 and decryption_password(Passw)=pass1);
exception
when others then 
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end checkEmpAccount;

procedure getCurrentEmplIdAndName(lgine nvarchar2, psde nvarchar2, id_rete out number, fioe out nvarchar2)
as 
begin
select Id_Emp into id_rete from Employee where Login=lgine and decryption_password(Passw)=psde;
select FullName into fioe from Employee where Login=lgine and decryption_password(Passw)=psde;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getCurrentEmplIdAndName;

procedure getComponentsNameAndId(p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as 
begin
OPEN p_cursor FOR 
select Id_com, comname, price  from ShopOfComponents order by id_com;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getComponentsNameAndId;

procedure getClientOrdersForEmployeeToDo(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as 
begin
OPEN p_cursor FOR 
select distinct Corder.id_or, corder.orderdate as Дата_Заказа, 
  equipment.ename as Наименование_оборудования, equipment.Description as Описание_поломки, 
  OrderStatus.statusname as Статус_заказа, Client.Fullname as Имя_Клиента
from Corder inner join Client on Corder.Id_client = Client.Id_client
inner join equipment on corder.id_eqp = equipment.Id_eqp
inner join Employee on Corder.Id_emp = eplid
inner join OrderStatus on  Corder.Id_Status= OrderStatus.ID_order
where Corder.Id_Status=1;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getClientOrdersForEmployeeToDo;

procedure changeOrderStatus(idor number)
as 
begin
update  COrder set Id_Status=2 where Id_Or=idor;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end changeOrderStatus;

procedure getClientOrdersForEmployee(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as
begin
OPEN p_cursor FOR 
select distinct Corder.id_or, corder.orderdate as Дата_Заказа, 
  equipment.ename as Наименование_оборудования, equipment.Description as Описание_поломки, 
  OrderStatus.statusname as Статус_заказа, Client.Fullname as Имя_Клиента
from Corder inner join Client on Corder.Id_client = Client.Id_client
inner join equipment on  corder.id_eqp = equipment.Id_eqp
inner join Employee on Corder.Id_emp = eplid
inner join OrderStatus on  Corder.Id_Status= OrderStatus.ID_order
where Corder.Id_Status=2;
exception 
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getClientOrdersForEmployee;

procedure addMakers(repairtype nvarchar2, price number, repairdate date)
as 
begin
insert into Makers(TypeOfRepair, Costs, DateOfRepair) values(repairtype,price, repairdate);
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addMakers;

procedure getLastMakers(idmk out number)
as 
begin 
idmk:=0;
select max(id_make) into idmk from Makers;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getLastMakers;

procedure changeStatusAndMakers(ior number, idmk number)
as 
begin
update  COrder set ID_MAKE=idmk, Id_Status=3 where Id_Or=ior;  
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end changeStatusAndMakers;

procedure getOrdersHistoryForEmployee(eplid number, p_cursor IN OUT NOCOPY SYS_REFCURSOR)
as 
begin
OPEN p_cursor FOR 
select distinct Corder.id_or, corder.orderdate as Дата_Заказа, 
  equipment.ename as Наименование_оборудования, equipment.Description as Описание_поломки,
  OrderStatus.statusname as Статус_заказа,  Client.Fullname as Имя_Клиента, 
  makers.typeofrepair as Тип_Ремонта, makers.COSTS as Стоимость, ShopOfComponents.comname as Детали  
from Corder inner join Client on Corder.Id_client = Client.Id_client
inner join equipment on  corder.id_eqp = equipment.Id_eqp
inner join Employee on Corder.Id_emp = eplid
inner join OrderStatus on  Corder.Id_Status= OrderStatus.ID_order
inner join Makers on COrder.ID_MAKE = makers.ID_MAKE
left join componentsorder on COrder.ID_MAKE = componentsorder.ID_MAKE
left join ShopOfComponents on ShopOfComponents.ID_Com = componentsorder.ID_Com
where Corder.Id_Status=3;                                               
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end getOrdersHistoryForEmployee;

procedure addComponentsOrder(idcomp number, idmaker number)
as 
begin 
insert into ComponentsOrder(Id_Com, Id_make) values(idcomp, idmaker);
commit;
exception
when others then
raise_application_error(-20001,'An error was encountered - '||SQLCODE||' -ERROR- '||SQLERRM);
end addComponentsOrder;

end cwPack2;

--------check----------------------
SET SERVEROUTPUT ON;

declare 
ct2 number;
begin
cwpack2.checkEmpAccount('Ks7631738','Ks7631738',ct2);
dbms_output.put_line('count = '||ct2);
end;

declare  
fio nvarchar2(50); 
idd number;
begin
cwpack2.getCurrentEmplIdAndName('Ks7631738','Ks7631738', idd, fio);
dbms_output.put_line('id = '||idd||' fio '|| fio);
end;

declare 
cur sys_refcursor;
   TYPE zz1  IS RECORD(Id_com number, comname nvarchar2(150), price number); 
   zz zz1;    
begin 
cwpack2.getComponentsNameAndId(cur);
     loop
      fetch cur into zz;
      EXIT when cur%notfound;
       dbms_output.put_line('Id: '||zz.Id_com||' Name: ' || zz.comname||' price: '||zz.price);
    end loop;
  if cur%isopen then
       close cur;
    end if;    
end;

declare 
cur sys_refcursor;
   TYPE zz1  IS RECORD(id_or number, orderdate date, ename nvarchar2(150), Description nvarchar2(150), statusname nvarchar2(150), Fullname nvarchar2(150)); 
   zz zz1;
begin
cwpack2.getClientOrdersForEmployeeToDo(1, cur);
     loop
      fetch cur into zz;
      EXIT when cur%notfound;
       dbms_output.put_line('Id order: ' || zz.id_or ||' Дата Заказа: ' || zz.orderdate|| ' Наименование оборудования: ' || zz.ename || ' Имя исполнителя: ' ||zz.FULLNAME || ' Статус заказа: ' || zz.statusname|| ' Описание поломки: ' || zz.Description);
    end loop;
  if cur%isopen then close cur;
    end if;    
end;

begin 
cwpack2.changeOrderStatus(1);
end;

declare 
cur sys_refcursor;
   TYPE zz1  IS RECORD(id_or number, orderdate date, ename nvarchar2(150), Description nvarchar2(150), statusname nvarchar2(150), Fullname nvarchar2(150));  -- обязательно надо определить, куда фетчим, это самый скользкий момент
   zz zz1;
begin
cwpack2.getClientOrdersForEmployee(2, cur);
    loop
      fetch cur into zz;
      EXIT when cur%notfound;
       dbms_output.put_line('Id order: ' || zz.id_or ||' Дата Заказа: ' || zz.orderdate|| ' Наименование оборудования: ' || zz.ename || ' Имя исполнителя: ' ||zz.FULLNAME || ' Статус заказа: ' || zz.statusname|| ' Описание поломки: ' || zz.Description);
    end loop;
  if cur%isopen then
       close cur;
    end if;    
end;

begin
cwpack2.addMakers('repair type', 100, '10.11.2022');
end;

declare 
n number;
begin
cwpack2.getLastMakers(n);
dbms_output.put_line('Last Id Maker: ' ||n);
end;

begin 
cwpack2.changeStatusAndMakers(1,1);
end;

declare cur sys_refcursor;
TYPE zz1  IS RECORD(id_or number, orderdate date, ename nvarchar2(150), Description nvarchar2(150), statusname nvarchar2(150), Fullname nvarchar2(150),typeofrepair   nvarchar2(150), COSTS number, comname nvarchar2(150));  -- обязательно надо определить, куда фетчим, это самый скользкий момент
   zz zz1;
begin
cwpack2.getOrdersHistoryForEmployee(1, cur);
     loop
      fetch cur into zz;
      EXIT when cur%notfound;
       dbms_output.put_line('Id order: ' || zz.id_or ||' Дата Заказа: ' || zz.orderdate|| ' Наименование оборудования: ' || zz.ename || ' Имя исполнителя: ' ||zz.FULLNAME || ' Тип ремонта: ' || zz.typeofrepair || ' Статус заказа: ' || zz.statusname|| ' Описание поломки: ' || zz.Description || ' Стоимость: ' || zz.COSTS || ' Наименование детали: ' || zz.comname);
    end loop;
  if cur%isopen then
       close cur;
    end if;      
end;

begin 
cwpack2.addComponentsOrder(1,1);
end;