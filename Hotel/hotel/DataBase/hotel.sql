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

insert into Admin values('admin','肖勇','admin','管理员')
insert into Admin values('baobao','胡天宝','baobao','服务员')

select * from admin

alter table Admin
	add constraint pk_A_AdminId primary key (A_AdminId)
--外键
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

insert into RoomType values('标准单人间')
insert into RoomType values('标准双人间')
insert into RoomType values('豪华单人间')
insert into RoomType values('豪华双人间')
insert into RoomType values('商务套房')
insert into RoomType values('总统套房')
insert into RoomType values('会议厅')

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

--插入数据测试
insert into Room  values('101','空净','一楼',1,98,0,'空调')
insert into Room  values('102','空净','一楼',1,98,0,'空调')
insert into Room  values('103','空净','一楼',1,98,0,'空调')
insert into Room  values('104','空净','一楼',1,98,0,'空调')
insert into Room  values('105','空净','一楼',1,98,0,'空调')


insert into Room  values('201','空净','一楼',2,108,0,'空调')
insert into Room  values('202','空净','一楼',2,108,0,'空调')
insert into Room  values('203','空净','一楼',2,108,0,'空调')
insert into Room  values('204','空净','一楼',2,108,0,'空调')
insert into Room  values('205','空净','一楼',2,108,0,'空调')



insert into Room  values('301','空净','一楼',3,178,0,'空调')
insert into Room  values('302','空净','一楼',3,178,0,'空调')
insert into Room  values('303','空净','一楼',3,178,0,'空调')
insert into Room  values('304','空净','一楼',3,178,0,'空调')
insert into Room  values('305','空净','一楼',3,178,0,'空调')


insert into Room  values('401','空净','三楼',4,580,0,'空调')
insert into Room  values('402','空净','三楼',4,580,0,'空调')
insert into Room  values('403','空净','三楼',4,580,0,'空调')
insert into Room  values('404','空净','三楼',4,580,0,'空调')
insert into Room  values('405','空净','三楼',4,580,0,'空调')


insert into Room  values('501','空净','一楼',5,680,0,'空调')
insert into Room  values('502','空净','一楼',5,680,0,'空调')
insert into Room  values('503','空净','一楼',5,680,0,'空调')
insert into Room  values('504','空净','一楼',5,680,0,'空调')
insert into Room  values('505','空净','一楼',5,680,0,'空调')



insert into Room  values('601','空净','三楼',6,980,0,'空调')
insert into Room  values('602','空净','三楼',6,980,0,'空调')
insert into Room  values('603','空净','三楼',6,980,0,'空调')


insert into Room  values('701','空净','三楼',7,1080,0,'空调')
insert into Room  values('702','空净','三楼',7,1080,0,'空调')
insert into Room  values('703','空净','三楼',7,1080,0,'空调')



select * from Room

--update Room set State ='预订' where R_id=4

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

insert into Users values('weixu','xiaoyong','weixu',100,'身份证','430521198904038745','株洲','男','13651444324',10,'')

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

insert into Underwrite values('20081002001','株洲北大青鸟','')
insert into Underwrite values('20081002002','株洲市公安厅','')



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

insert into WareType values('1','烟酒')
insert into WareType values('2','日用品')
insert into WareType values('3','熟食')
insert into WareType values('4','饮料')
insert into WareType values('5','其它')


if exists (select * from SysObjects where name='Ware')
	drop table Ware
create table Ware
(
	WareName	 varchar(50)  not null,
	WareComePrice money       not null,	
	WareGoPrice   money		  not null,	
	WareEasyName varchar(50)  not null,   --检索码
	WareType	 varchar(50)  not null,
	WareCount    int		  not null,	
	WareUnit	 varchar(50)  not null,
	Date		 datetime	  not null,
	authorized	 varchar(50)  not null
)

alter table Ware
	add constraint pk_WareName primary key(WareName)
		--constraint fk_WareType foreign key(WareType) references WareType(W_wareTypeId)

insert into Ware values('五子醉','4.5','5.0','wzz','槟榔',100,'袋','2008-10-12 10:38','')
insert into Ware values('白沙烟','4.0','5.0','bsy','烟酒',100,'包','2008-10-12 10:38','')
insert into Ware values('面包','.08','1.0','mb','食品',100,'个','2008-10-12 10:38','')
insert into Ware values('红茶','2.5','3.0','hc','饮料',100,'瓶','2008-10-12 10:38','')
insert into Ware values('绿茶','2.5','3.0','lc','饮料',100,'瓶','2008-10-12 10:38','')
insert into Ware values('纸巾','0.8','1.0','zj','日用品',100,'包','2008-10-12 10:38','')
insert into Ware values('芙蓉王','20','25','frw','烟酒',100,'包','2008-10-12 10:38','')
insert into Ware values('绍洋大曲','7.0','9.0','sydq','烟酒',100,'瓶','2008-10-12 10:38','')
insert into Ware values('可乐','2.5','3.0','kl','饮料',100,'瓶','2008-10-12 10:38','')
insert into Ware values('鱼仔','2.5','3.0','yz','食品',100,'袋','2008-10-12 10:38','')




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
		
--插入数据测试
insert into Awoke values('20080929001','你好','未读','2008-10-09 01:37:00.000','测试')

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

--insert into Service values('20081005004',3,'我要一瓶青岛','未读','2008-10-02 21:30') 

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

insert into SoftWareSet values('軎砉','帅',0.9,1,0,0,10,10,1,1,'D:\hotel.bak')


if exists (select * from SysObjects where name='purview')
	drop table purview
create table purview
(
	Admin	varchar(50)		not null,	--用户名
	Ispurview bit   not null,   --是否有修改权限的权限
	SysSet	bit		not null,   --系统设置	

	HAdd    bit		not null,   --房子添加
	HUpdate bit		not null,
	HDelete bit		not null,
	
	EAdd    bit		not null,   --员工添加
	EUpdate bit		not null,
	EDelete bit		not null,
	
	AAdd    bit		not null,   --提醒添加
	AUpdate bit		not null,
	ADelete bit		not null,

	UAdd    bit		not null,   --签单添加
	UUpdate bit		not null,
	UDelete bit		not null,
	
	LLook   bit		not null,	--查看日志
	LDelete	bit		not null,	--日志删除

	Qiantai bit     not null,   --前台操作
	Yuding  bit     not null,   --预订管理
	ShouYin bit    not null,   --收银管理
	jiben    bit    not null,   --基本操作
)
insert  into purview values('admin',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1)

insert  into purview values('baobao',0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1)

--select * from Guest
--select Max(G_GuestId) from Guest

--drop view temp

--创建视图
go
create view temp
as
select Room.R_id,Room.R_RoomId,Room.price,Room.State,
Room.Floot,Room.RoomType,Room.R_Count,Room.Fixing,
Guest.G_GuestId,Guest.Uname,Guest.AdvanceForegift,Guest.Underwrite,
Guest.comeDate,Guest.Bookleave,Guest.faceDate,Guest.Operator,Guest.Remark
from Room left join guest on room.R_id=Guest.R_id and Guest.faceDate = ''
go
