insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 10,'800��','��.��',2,1,2.00,9.00,1 where not exists (select * from PhysicalItem where id=10)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 11,'1000��','��.��',2,1,2.00,9.00,1 where not exists (select * from PhysicalItem where id=11)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 18,'һ��������','��/��',0,1,0,300,2 where not exists (select * from PhysicalItem where id=18)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 15,'��ʵ����','��',1,1,1.0,25.0,2 where not exists (select * from PhysicalItem where id=15)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 6,'������Զ','����',0,1,50,400,2 where not exists (select * from PhysicalItem where id=6)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 5,'50��','��',1,1,0,20.0,1  where not exists (select * from PhysicalItem where id=5)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 12,'һ������������','��/��',0,1,0,99,2  where not exists (select * from PhysicalItem where id=12)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 14,'��������','��',0,1,0,99,2  where not exists (select * from PhysicalItem where id=14)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 13,'400��','��.��',2,1,0.45,4.00,1  where not exists (select * from PhysicalItem where id=13)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 7,'��λ��ǰ��','����',1,1, -30,40,2 where not exists (select * from PhysicalItem where id=7)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 8,'����','����',1,1,1,100,2 where not exists (select * from PhysicalItem where id=8)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 9,'50�ס�8������','��.��',2,1,0.45,4.00,1  where not exists (select * from PhysicalItem where id=9)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 1,'���','����',1,1,80,250,null  where not exists (select * from PhysicalItem where id=1)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 2,'����','����',1,1,14,200,null  where not exists (select * from PhysicalItem where id=2)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 4,'�λ���','����',0,1,0,9999,2  where not exists (select * from PhysicalItem where id=4)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 3,'̨�ײ���','��',1,1,20,100,2  where not exists (select * from PhysicalItem where id=3)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 16,'��ɳ��','��',1,1,0,50,2  where not exists (select * from PhysicalItem where id=16)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 17,'25��*2������','��',1,1,5.0,20.0,1  where not exists (select * from PhysicalItem where id=17)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 19,'��������','��',2,1,1,60,1 where not exists (select * from PhysicalItem where id=19)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 20,'��������','��',2,1,1,60,1 where not exists (select * from PhysicalItem where id=20)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 21,'�������','��',0,1,0,99,2  where not exists (select * from PhysicalItem where id=21)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 22,'30���߼���','��',0,1,0,99,2 where not exists (select * from PhysicalItem where id=22)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 23,'�������','��',0,1,0,99,2 where not exists (select * from PhysicalItem where id=23)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode) select 70,'һ���Ӹ��Գ�','��/��',0,1,0,900,2 where not exists (select * from PhysicalItem where id=70)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 24,'BMIָ��','',1,1,null,null,null,'([����] * 10000)/([���] * [���])' where not exists (select * from PhysicalItem where id=24)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 25,'�λ�������ָ��','',1,1,null,null,2,'[�λ���]/[����]' where not exists (select * from PhysicalItem where id=25)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 26,'��������ָ��','',1,1,null,null,2,'([����] * 100) / [����]' where not exists (select * from PhysicalItem where id=26)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 71,'��������','',1,1,0,10,2,null where not exists (select * from PhysicalItem where id=71)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 72,'��������','',1,1,0,10,2,null where not exists (select * from PhysicalItem where id=72)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 73,'100����','��',2,1,5,50,1,null where not exists (select * from PhysicalItem where id=73)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 74,'200����','��',2,1,5,100,1,null where not exists (select * from PhysicalItem where id=74)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 80,'��Ӧʱ','��',2,1,null,null,1,null where not exists (select * from PhysicalItem where id=80)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 81,'��������','����',2,1,null,null,2,null where not exists (select * from PhysicalItem where id=81)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 82,'���۵���վ��','��',2,1,null,null,2,null where not exists (select * from PhysicalItem where id=82)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 75,'60����','��',2,1,0,30,1,null where not exists (select * from PhysicalItem where id=75)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 76,'100�׿���','��',2,1,0,30,1,null where not exists (select * from PhysicalItem where id=76)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 77,'110�׿���','��',2,1,0,30,1,null where not exists (select * from PhysicalItem where id=77)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 79,'4*100����','��',2,1,0,120,1,null where not exists (select * from PhysicalItem where id=79)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 83,'������','����',2,1,0,500,2,null where not exists (select * from PhysicalItem where id=83)
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 84,'��������','��',2,1,0,60,1,null where not exists (select * from PhysicalItem where id=84)
go

--2017-8-12 ������ɷַ�����Ŀ
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 151,'��֬����(TBF)','%',1,1,0,100,0,null where not exists (select * from PhysicalItem where id=151)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 152,'��ָ֬��(VFI)','',1,1,0,100,0,null where not exists (select * from PhysicalItem where id=152)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 153,'��ˮ����(TBW)','%',1,1,0,100,0,null where not exists (select * from PhysicalItem where id=153)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 154,'��������(SM)','%',1,1,0,100,0,null where not exists (select * from PhysicalItem where id=154)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 155,'�ǿ���(BMC)','KG',1,1,0,100,0,null where not exists (select * from PhysicalItem where id=155)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 156,'������л(BMR)','',0,1,0,10000,0,null where not exists (select * from PhysicalItem where id=156)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 157,'��֫ƽ��','',3,1,0,100,0,null where not exists (select * from PhysicalItem where id=157)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 158,'��֫ƽ��','',3,1,0,100,0,null where not exists (select * from PhysicalItem where id=158)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 159,'ȫ��ƽ��','',3,1,0,100,0,null where not exists (select * from PhysicalItem where id=159)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 160,'��ɷ��ۺ�����','',1,1,0,100,2,null where not exists (select * from PhysicalItem where id=160)
go
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 161,'��������','',0,1,0,100,1,null where not exists (select * from PhysicalItem where id=161)
go


--20171010 �˶���������һ�е÷ֵȼ�
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Rank' AND id = OBJECT_ID(N'[dbo].[SportSuggestion]'))
BEGIN
	exec ('alter table SportSuggestion add Rank nvarchar(50) null')
end
go

--����25�������ܣ��������߼����������Կ�Ŀ 20180501
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 85,'25��������','��',2,1,0,100,1,null where not exists (select * from PhysicalItem where id=85)
go

insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 86,'������','��',0,1,0,100,2,null where not exists (select * from PhysicalItem where id=86)
go

insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 87,'�߼���','��',0,1,0,300,2,null where not exists (select * from PhysicalItem where id=87)
go

--20180829 ѧ���ɼ�����Note��
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Note' AND id = OBJECT_ID(N'[dbo].[PhysicalScore]'))
BEGIN
	exec ('alter table PhysicalScore add Note nvarchar(512) null')
end
go

--20181019 �˶�����������Ա����������
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Sex' AND id = OBJECT_ID(N'[dbo].[SportSuggestion]'))
BEGIN
	exec ('alter table SportSuggestion add Sex nvarchar(50) null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Evaluation' AND id = OBJECT_ID(N'[dbo].[SportSuggestion]'))
BEGIN
	exec ('alter table SportSuggestion add Evaluation nvarchar(512) null')
end
go

--20181127 �����Ŀ���ӿ�ʼ���������ֶ�
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='StartDate' AND id = OBJECT_ID(N'[dbo].[PhysicalProject]'))
BEGIN
	exec ('alter table PhysicalProject add StartDate datetime null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='EndDate' AND id = OBJECT_ID(N'[dbo].[PhysicalProject]'))
BEGIN
	exec ('alter table PhysicalProject add EndDate datetime null')
end
go

--20181227 ��Ŀ���Ӳ��Դ�����
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='TestCount' AND id = OBJECT_ID(N'[dbo].[PhysicalItem]'))
BEGIN
	exec ('alter table PhysicalItem add TestCount int null')
end
go

--20190219 ����Ա���ӿ�����
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='PhysicalProject' AND id = OBJECT_ID(N'[dbo].[Operator]'))
BEGIN
	exec ('alter table [Operator] add PhysicalProject nvarchar(50) null')
end
go

--20190225 ����б������ ����
insert into PhysicalItem (ID,Name,Unit,PointCount,Hasmachine,[Min],[Max],SortMode,Formula) select 150,'б������','',0,1,0,100,2,null where not exists (select * from PhysicalItem where id=150)
go

--20190226 ��Ŀ���Ӽ���У��������ӿ���ʱ��ͼ�¼ʱ����
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='ShortName' AND id = OBJECT_ID(N'[dbo].[PhysicalItem]'))
BEGIN
	exec ('alter table PhysicalItem add ShortName nvarchar(50) null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='PlanDate' AND id = OBJECT_ID(N'[dbo].[StudentGroup]'))
BEGIN
	exec ('alter table PhysicalItem add PlanDate nvarchar(50) null')
end
go

if not exists (SELECT * FROM dbo.syscolumns WHERE name ='CheckTime' AND id = OBJECT_ID(N'[dbo].[StudentGroup]'))
BEGIN
	exec ('alter table PhysicalItem add CheckTime datetime null')
end
go
