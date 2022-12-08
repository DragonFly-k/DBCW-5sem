create table Client
(
  Id_Client NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Client_pk PRIMARY KEY (Id_Client),
  FullName nvarchar2(50) not null,
  Adress nvarchar2(200) not null,
  PhoneNumber nvarchar2(40) not null,
  Login nvarchar2(150 ) not null UNIQUE,
  Passw nvarchar2(150) not null
);
create table Vacancy
(
  Id_vac NUMBER GENERATED ALWAYS AS IDENTITY,
  VacancyName nvarchar2(200) not null,
  CONSTRAINT Vac_pk PRIMARY KEY (Id_vac)
);
create table Employee
(
  Id_emp NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Emp_pk PRIMARY KEY (Id_emp),
  FullName nvarchar2(50) not null,
  Id_vac number not null,
  CONSTRAINT fk_Id_vac FOREIGN KEY (Id_vac) REFERENCES Vacancy(Id_vac),
  PassportSeria nvarchar2(60) not null,
  PassportNumber nvarchar2(60) not null,
  Adress nvarchar2(200) not null,
  PhoneNumber nvarchar2(40) not null,
  StartWorkDate DATE,
  Login nvarchar2(150) not null UNIQUE,
  Passw nvarchar2(150) not null
 );
create table OrderStatus
(
  Id_Order NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT IdOrder_pk PRIMARY KEY (Id_Order),
  StatusName nvarchar2(150) not null
);
create table Equipment
(
  Id_eqp NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Eqp_pk PRIMARY KEY (Id_eqp),
  Ename nvarchar2(150) not null,
  SeriaNumber nvarchar2(150) not null,
  Description nvarchar2(300) not null,
  Maker nvarchar2(100) not null,
  EModel nvarchar2(100) not null
);
create table Makers
(
  Id_make NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Make_pk PRIMARY KEY (Id_make),
  TypeOfRepair nvarchar2(200) not null,
  Costs number not null,
  DateOfRepair date not null   
);
create table ShopOfComponents
(
  Id_Com NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Com_pk PRIMARY KEY (Id_Com),
  ComName nvarchar2(200) not null,
  Price number not null  
);
create table COrder
(
  Id_Or NUMBER GENERATED ALWAYS AS IDENTITY,
  CONSTRAINT Or_pk PRIMARY KEY (Id_Or),
  Id_eqp number not null,
  CONSTRAINT fk_Id_Eq FOREIGN KEY (Id_eqp) REFERENCES Equipment(Id_eqp),
  Id_Client number not null,
  CONSTRAINT fk_Id_Cl FOREIGN KEY (Id_Client) REFERENCES Client(Id_Client),
  Id_emp number not null,
  CONSTRAINT fk_Id_Emp FOREIGN KEY (Id_emp) REFERENCES Employee(Id_emp),
  Id_Status number not null,
  CONSTRAINT fk_Id_OrStatus FOREIGN KEY (Id_Status) REFERENCES OrderStatus(Id_Order),
  Id_make number default null,
  CONSTRAINT fk_Id_mk FOREIGN KEY (Id_make) REFERENCES Makers(Id_make),
  OrderDate date not null
);
create table ComponentsOrder
(
  Id_Com NUMBER not null,
  CONSTRAINT fk_Id_Com FOREIGN KEY (Id_Com) REFERENCES ShopOfComponents(Id_Com),
  Id_make number not null,
  CONSTRAINT fk_Id_make FOREIGN KEY (Id_make) REFERENCES Makers(Id_make)
);

select * from client;
select * from employee;
select * from vacancy;
select * from orderstatus;
select * from equipment; 
select * from makers;          
select * from shopofcomponents;
select * from componentsorder;  
select * from corder;

--drop table COrder;
--drop table ComponentsOrder;
--drop table ShopOfComponents;
--drop table Makers;
--drop table Equipment;
--drop table OrderStatus;
--drop table Employee;
--drop table Vacancy;
--drop table Client;