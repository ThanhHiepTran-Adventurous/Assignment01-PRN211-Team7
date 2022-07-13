CREATE DATABASE ManagementMemberDB;
GO
USE ManagementMemberDB;
GO

CREATE TABLE [dbo].[Members](
	[MemberID] [INT] NOT NULL,
	[MemberName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleID][nvarchar](50)NULL,
	[City][nvarchar](50)NULL,
	[Country] [nvarchar](50)NULL,
	[Email][nvarchar](50)NULL
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[Members] ALTER COLUMN [MemberID] INT NOT NULL

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (1,N'Trần Thanh Hiệp',N'0105', N'member',N'Ninh Thuận',N'Việt Nam',N'nguyenhiep0456@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (2,N'Mai Hữu Tài',N'0102', N'member',N'Tiền Giang',N'Việt Nam',N'huutaimai@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password],[RoleID], [City], [Country], [Email]) 
                              VALUES (3,N'Vũ Nguyễn Huy Chương',N'0102', N'member',N'Ninh Thuận',N'Việt Nam',N'chuongvnh@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (4,N'Nguyễn Thành Tài',N'0105', N'member',N'Bà rịa',N'Việt Nam',N'Taint@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (5,N'Lê Vinh Quang',N'0105', N'member',N'Bến Tre',N'Việt Nam',N'nguyenhiep0456@gmail.com');


INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (7,N'Aisha',N'0105', N'member',N'Kuala Lumpur',N'Malaysia',N'Aisha@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (8,N'Dãnh Nhòi Búa',N'0105', N'member',N'Luang Prabang',N'Laos',N'DãnhNhòiBúa@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (9,N'Chirawan',N'0105', N'member',N'Bangkok',N'ThaiLand',N'Chirawan@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (10,N'Park Min Young',N'0105', N'member',N'Busan',N'South Korea',N'ParkMinYoung@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (11,N'Kwang-min',N'0105', N'member',N'Bình Nhưỡng',N'North Korea',N'Kwang-min@gmail.com');

INSERT [dbo].[Members] ([MemberID],[MemberName], [Password], [RoleID], [City], [Country], [Email]) 
                              VALUES (5,N'Lê Vinh Quang',N'0105', N'member',N'Bến Tre',N'Việt Nam',N'nguyenhiep0456@gmail.com');


SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM  Members

SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM  Members

SELECT MemberID, MemberName, Password, RoleID, City, Country, Email " +
                " FROM Members WHERE MemberID = N'Chuong'

DELETE Members WHERE MemberID = N'TaiNguyen'

SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM Members WHERE MemberID = 3
	
SELECT * FROM Members WHERE MemberName LIKE N'%T%'
SELECT * FROM Members WHERE MemberName LIKE N'THANH'

SELECT * FROM Members WHERE MemberName LIKE @MemberName
SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM Members WHERE MemberName like N'%Chương%'
SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM Members WHERE MemberName LIKE N'%T%'
select * from Members