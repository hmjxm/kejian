go
use master
if exists (select * from Sysdatabases where name='hotel') drop database hotel

create database hotel
on
(
	name='hotel_dat',
	filename='f:\hotel.mdf',
	size=3MB,
	maxsize=10MB,
	filegrowth=15%
) 
log on
(
	name='hotel_log',
	filename='f:\hotel.ldf',
	size=1MB
)

go
use hotel

if exists (select * from SysObjects where name='Admin')
	drop table Admin
create table Admin
(
	A_AdminId    varchar(50)  not null,	
	A_Name		 varchar(50)  not null,
	Password     varchar(50)  not null,
	A_Type	     varchar(50)  not null
)

insert into Admin values('admin','Ф��','admin','����Ա')
insert into Admin values('baobao','���챦','baobao','����Ա')

select * from admin

alter table Admin
	add constraint pk_A_AdminId primary key (A_AdminId)
--���
select * from Admin


if exists (select * from SysObjects where name='LoginLog')
	drop table LoginLog
create table LoginLog 
(
	L_LoginLogId	 varchar(50)  not null,	
	L_AdminId		 varchar(50)  not null,
	LoginDate		datetime	  not null,
	LeaveDate		datetime	  null
)

alter table LoginLog
	add constraint pk_L_LoginLogId primary key (L_LoginLogId)

--	    constraint fk_L_AdminId foreign key(L_AdminId) references  Admin(A_AdminId)
select * from LoginLog

if exists (select * from SysObjects where name='RoomType')
	drop table RoomType
create table RoomType
(
	R_RoomId		 int identity(1,1),
	R_Type		     varchar(50)  not null,	
)

insert into RoomType values('��׼���˼�')
insert into RoomType values('��׼˫�˼�')
insert into RoomType values('�������˼�')
insert into RoomType values('����˫�˼�')
insert into RoomType values('�����׷�')
insert into RoomType values('��ͳ�׷�')
insert into RoomType values('������')

alter table RoomType
	add constraint pk_R_RoomId primary key (R_RoomId)



if exists (select * from SysObjects where name='Room')
	drop table Room
create table Room 
(
	R_id		 int identity(1,1)not null,
	R_RoomId	 varchar(50)  not null,	
	State		 varchar(20)  not null,
	Floot		 varchar(50)  not null,		
	RoomType     int		  not null,	
	price        money		  not null,	
	R_Count		 int          not null,	
	fixing		 varchar(255) ,
)

select * from room

alter table Room
	add constraint pk_G_RoomId primary key (R_id)

--		constraint fk_RoomType foreign key(RoomType) references RoomType(R_RoomId)

--�������ݲ���
insert into Room  values('101','�վ�','һ¥',1,98,0,'�յ�')
insert into Room  values('102','�վ�','һ¥',1,98,0,'�յ�')
insert into Room  values('103','�վ�','һ¥',1,98,0,'�յ�')
insert into Room  values('104','�վ�','һ¥',1,98,0,'�յ�')
insert into Room  values('105','�վ�','һ¥',1,98,0,'�յ�')


insert into Room  values('201','�վ�','һ¥',2,108,0,'�յ�')
insert into Room  values('202','�վ�','һ¥',2,108,0,'�յ�')
insert into Room  values('203','�վ�','һ¥',2,108,0,'�յ�')
insert into Room  values('204','�վ�','һ¥',2,108,0,'�յ�')
insert into Room  values('205','�վ�','һ¥',2,108,0,'�յ�')



insert into Room  values('301','�վ�','һ¥',3,178,0,'�յ�')
insert into Room  values('302','�վ�','һ¥',3,178,0,'�յ�')
insert into Room  values('303','�վ�','һ¥',3,178,0,'�յ�')
insert into Room  values('304','�վ�','һ¥',3,178,0,'�յ�')
insert into Room  values('305','�վ�','һ¥',3,178,0,'�յ�')


insert into Room  values('401','�վ�','��¥',4,580,0,'�յ�')
insert into Room  values('402','�վ�','��¥',4,580,0,'�յ�')
insert into Room  values('403','�վ�','��¥',4,580,0,'�յ�')
insert into Room  values('404','�վ�','��¥',4,580,0,'�յ�')
insert into Room  values('405','�վ�','��¥',4,580,0,'�յ�')


insert into Room  values('501','�վ�','һ¥',5,680,0,'�յ�')
insert into Room  values('502','�վ�','һ¥',5,680,0,'�յ�')
insert into Room  values('503','�վ�','һ¥',5,680,0,'�յ�')
insert into Room  values('504','�վ�','һ¥',5,680,0,'�յ�')
insert into Room  values('505','�վ�','һ¥',5,680,0,'�յ�')



insert into Room  values('601','�վ�','��¥',6,980,0,'�յ�')
insert into Room  values('602','�վ�','��¥',6,980,0,'�յ�')
insert into Room  values('603','�վ�','��¥',6,980,0,'�յ�')


insert into Room  values('701','�վ�','��¥',7,1080,0,'�յ�')
insert into Room  values('702','�վ�','��¥',7,1080,0,'�յ�')
insert into Room  values('703','�վ�','��¥',7,1080,0,'�յ�')



select * from Room

--update Room set State ='Ԥ��' where R_id=4

if exists (select * from SysObjects where name='Users')
	drop table Users
create table Users
(
	U_UsersId		 varchar(50)  not null,
	Uname		     varchar(50)  not null,
	Pass			 varchar(50)  not null,
	Score			 float		  not null,	
	CertificateType  varchar(50)  not null,
	CertificateID    varchar(50)  not null,
	Address			 varchar(50)  ,
	Usex			 varchar(50)  not null,
	contactTel		 varchar(50)  ,
	U_money          money   	  not null,
	remark			 varchar(50)  ,
)
alter table Users
	add constraint pk_U_UsersId primary key (U_UsersId)	

insert into Users values('weixu','xiaoyong','weixu',100,'���֤','430521198904038745','����','��','13651444324',10,'')

select * from Users
if exists (select * from SysObjects where name='Underwrite')
	drop table Underwrite
create table Underwrite
(
	U_Id		 varchar(50)  not null,	
	Underwrite	 varchar(50)  not null,	
	Remark		 varchar(50)  not null,
)
alter table Underwrite
	add constraint pk_U_Id primary key (U_Id)

insert into Underwrite values('20081002001','���ޱ�������','')
insert into Underwrite values('20081002002','�����й�����','')



if exists (select * from SysObjects where name='UnderwriteAnnal')
	drop table UnderwriteAnnal
create table UnderwriteAnnal
(
	A_Id		 varchar(50)  not null,
	Room_id		 varchar(50)  not null,
	G_GuestId	 varchar(50)  not null,		
	Underwrite	 varchar(50)  not null,
	U_money		 money		  not null,	
	shifu		 money		  ,
	zhaoling	 money		  ,
	shengyu		 money		  ,
	State		 varchar(5)	  not null,
	Remark		 varchar(255) not null,
)
alter table UnderwriteAnnal
	add constraint pk_A_Id primary key (A_Id)

select * from UnderwriteAnnal


if exists (select * from SysObjects where name='Book')
	drop table Book
create table Book 
(
	B_BookId			 varchar(50)  not null,	
	U_UserId			 varchar(50)  ,	
	R_id				 int		  not null,
	Room_id				 varchar(50)  not null,	
	State	             varchar(50)  not null,
	AdvanceForegift		 money		  ,
	Underwrite			 varchar(50)   null,
	comeDate			 datetime     not null,
	Bookleave            datetime     not null,				
	Operator			 varchar(50)  not null,
	Uname				 varchar(50)  not null,	
	CertificateType      varchar(50)  not null,
	CertificateID        varchar(255) not null,
	Address              varchar(255) ,
	Usex				 varchar(10)  not null ,
	contactTel           varchar(50)  ,
	remark				 varchar(255) 
)

select * from Book

alter table Book
	add constraint pk_B_BookId primary key (B_BookId)
		--constraint fk_B_R_id foreign key(R_id) references Room(R_id),		
--		constraint fk_Operator foreign key(Operator) references Admin(A_AdminId)	




if exists (select * from SysObjects where name='CashManage')
	drop table CashManage
create table CashManage
(
	C_Id				 varchar(50)  not null,
	A_AdminId		     varchar(50)  not null,
	C_sum				 money		  not null,	
	jiaobanhou			 money		  not null,
	jiebanqian			 money		  not null,	
	jiebanDate			 datetime	  not null,	
)

alter table CashManage
	add constraint pk_C_Id primary key(C_Id)
--		constraint fk_A_AdminId foreign key(A_AdminId) references Admin(A_AdminId)



if exists (select * from SysObjects where name='Guest')
	drop table Guest
create table Guest 
(
	G_GuestId			 varchar(50)  not null,	
	R_id				 int		  not null,	
	U_UserId			 varchar(50)  ,	
	Uname				 varchar(50)  not null,		
	Sex					 varchar(4)   not null,
	CertificateType      varchar(50)  ,
	CertificateID        varchar(255) ,
	CertificatePic       varchar(255) ,
	Address              varchar(255) ,	
	contactTel           varchar(50)  ,
	AdvanceForegift		 money		  ,
	Underwrite			 varchar(50)  ,
	comeDate			 datetime	  not null,
	Bookleave            datetime     not null,	
	faceDate			 varchar(50)	  ,
	R_price				 money  ,
	Due					 money	,	  
	Fact				 money	,	  
	locate				 money	,
	Operator			 varchar(50)  ,	
	remark				 varchar(255) 
)

alter table Guest
	add constraint pk_G_GuestId primary key(G_GuestId)
--		constraint fk_RoomId foreign key(R_id) references Room(R_id)



if exists (select * from SysObjects where name='WareType')
	drop table WareType
create table WareType
(
	W_wareTypeId	 varchar(50)  not null,
	WareTypeName	 varchar(50)  not null,		
)
alter table WareType
	add constraint pk_W_wareTypeId primary key(W_wareTypeId)		

insert into WareType values('1','�̾�')
insert into WareType values('2','����Ʒ')
insert into WareType values('3','��ʳ')
insert into WareType values('4','����')
insert into WareType values('5','����')


if exists (select * from SysObjects where name='Ware')
	drop table Ware
create table Ware
(
	WareName	 varchar(50)  not null,
	WareComePrice money       not null,	
	WareGoPrice   money		  not null,	
	WareEasyName varchar(50)  not null,   --������
	WareType	 varchar(50)  not null,
	WareCount    int		  not null,	
	WareUnit	 varchar(50)  not null,
	Date		 datetime	  not null,
	authorized	 varchar(50)  not null
)

alter table Ware
	add constraint pk_WareName primary key(WareName)
		--constraint fk_WareType foreign key(WareType) references WareType(W_wareTypeId)

insert into Ware values('������','4.5','5.0','wzz','����',100,'��','2008-10-12 10:38','')
insert into Ware values('��ɳ��','4.0','5.0','bsy','�̾�',100,'��','2008-10-12 10:38','')
insert into Ware values('���','.08','1.0','mb','ʳƷ',100,'��','2008-10-12 10:38','')
insert into Ware values('���','2.5','3.0','hc','����',100,'ƿ','2008-10-12 10:38','')
insert into Ware values('�̲�','2.5','3.0','lc','����',100,'ƿ','2008-10-12 10:38','')
insert into Ware values('ֽ��','0.8','1.0','zj','����Ʒ',100,'��','2008-10-12 10:38','')
insert into Ware values('ܽ����','20','25','frw','�̾�',100,'��','2008-10-12 10:38','')
insert into Ware values('�������','7.0','9.0','sydq','�̾�',100,'ƿ','2008-10-12 10:38','')
insert into Ware values('����','2.5','3.0','kl','����',100,'ƿ','2008-10-12 10:38','')
insert into Ware values('����','2.5','3.0','yz','ʳƷ',100,'��','2008-10-12 10:38','')




select * from guest


go
if exists (select * from SysObjects where name='Consume')
	drop table Consume
create table Consume
(
	C_ConsumeId		 varchar(50)  not null,
	G_GuestId		 varchar(50)  not null,	
	C_Name			 varchar(50)  not null,
	Price			 money		  not null,	
	C_Count          int		  not null,
	date			 datetime	  not null,
	C_type			 varchar(50)  not null,
	Operator		 varchar(50)  not null,
	Remark			 varchar(255) ,
)
go
alter table Consume
	add constraint pk_C_ConsumeId primary key(C_ConsumeId)
		--constraint fk_G_GuestId foreign key (G_GuestId) references Guest (G_GuestId)

go
if exists (select * from SysObjects where name='defray')
	drop table defray
create table defray
(
	D_defrayId		 varchar(50)  not null,		
	Price			 money		  not null,		
	date			 datetime	  not null,
	C_type			 varchar(50)  not null,
	Operator		 varchar(50)  not null,
	Remark			 varchar(255) ,
)
go
alter table defray
	add constraint pk_D_defrayId primary key(D_defrayId)
	

go


if exists (select * from SysObjects where name='Awoke')
	drop table Awoke
create table Awoke
(
	A_AwokeId		 varchar(50)  not null,
	A_content		 varchar(50)  not null,	
	State			 varchar(50)  not null,	
	Date 			 dateTime	  not null,
	Remark			 varchar(255) 
)
alter table Awoke
	add constraint pk_A_AwokeId primary key(A_AwokeId)
		
--�������ݲ���
insert into Awoke values('20080929001','���','δ��','2008-10-09 01:37:00.000','����')

if exists (select * from SysObjects where name='Service')
	drop table Service
create table Service
(
	S_serviceId		 varchar(50)   not null,
	toId			 varchar(50)   not null,
	U_UsersId        varchar(50)   not null,
	S_content		 varchar(255)  not null,	
	State			 varchar(50)   not null,	
	Date 			 dateTime	   not null,	
)

alter table Service
	add constraint pk_S_serviceId primary key(S_serviceId)

select * from Service

--insert into Service values('20081005004',3,'��Ҫһƿ�ൺ','δ��','2008-10-02 21:30') 

if exists (select * from SysObjects where name='LeaveWord')
	drop table LeaveWord
create table LeaveWord
(
	L_LeaveWordId	 varchar(50)  not null,
	L_U_UsersId		 varchar(50)  not null,
	L_content		 varchar(50)  not null,		
	Date 			 dateTime	  not null,	
)

alter table LeaveWord
	add constraint pk_L_LeaveWordId primary key(L_LeaveWordId)



if exists (select * from SysObjects where name='SoftWareSet')
	drop table SoftWareSet
create table SoftWareSet
(
	HotelName		 varchar(50)  not null,
	Intro			 varchar(50)  not null,	
	discount		 float		  not null,
	SameName		 int		  not null,
	ForegiftSmall	 int		  not null,
	IsRefurbish      int		  not null,
	Refurbish        int		  not null,
	IgnoreTime		 int		  not null,	
	ExceedTime		 int		  not null,
	GoOutBak		 int		  ,
	S_Path			 varchar(255),	
)

insert into SoftWareSet values('��','˧',0.9,1,0,0,10,10,1,1,'D:\hotel.bak')


if exists (select * from SysObjects where name='purview')
	drop table purview
create table purview
(
	Admin	varchar(50)		not null,	--�û���
	Ispurview bit   not null,   --�Ƿ����޸�Ȩ�޵�Ȩ��
	SysSet	bit		not null,   --ϵͳ����	

	HAdd    bit		not null,   --�������
	HUpdate bit		not null,
	HDelete bit		not null,
	
	EAdd    bit		not null,   --Ա�����
	EUpdate bit		not null,
	EDelete bit		not null,
	
	AAdd    bit		not null,   --�������
	AUpdate bit		not null,
	ADelete bit		not null,

	UAdd    bit		not null,   --ǩ�����
	UUpdate bit		not null,
	UDelete bit		not null,
	
	LLook   bit		not null,	--�鿴��־
	LDelete	bit		not null,	--��־ɾ��

	Qiantai bit     not null,   --ǰ̨����
	Yuding  bit     not null,   --Ԥ������
	ShouYin bit    not null,   --��������
	jiben    bit    not null,   --��������
)
insert  into purview values('admin',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1)

insert  into purview values('baobao',0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1)

--select * from Guest
--select Max(G_GuestId) from Guest

--drop view temp

--������ͼ
go
create view temp
as
select Room.R_id,Room.R_RoomId,Room.price,Room.State,
Room.Floot,Room.RoomType,Room.R_Count,Room.Fixing,
Guest.G_GuestId,Guest.Uname,Guest.AdvanceForegift,Guest.Underwrite,
Guest.comeDate,Guest.Bookleave,Guest.faceDate,Guest.Operator,Guest.Remark
from Room left join guest on room.R_id=Guest.R_id and Guest.faceDate = ''
go
