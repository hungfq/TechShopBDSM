USE [techshopdbms]
GO
/****** Object:  UserDefinedFunction [dbo].[check_Login]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[check_Login](@username NVARCHAR(255), @password VARCHAR(255))
RETURNS INT
AS
BEGIN
    DECLARE @user_id INT
    SELECT @user_id = user_id
    FROM users
    WHERE username = @username AND password = @password
        RETURN @user_id;
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_BrandNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[get_BrandNameById](@id int)
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @name NVARCHAR(255)
    SELECT @name = name
            FROM brands
            WHERE brand_id = @id
    RETURN @name
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_CategoryNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[get_CategoryNameById](@id int)
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @name NVARCHAR(255)
    SELECT @name = name
            FROM categories
            WHERE category_id = @id
    RETURN @name
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_CusNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_CusNameById](@cus_id INT)
RETURNS NVARCHAR(255)
AS
BEGIN
  RETURN (SELECT name
            FROM customers
            WHERE customer_id = @cus_id)
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_HighestPriceProductId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_HighestPriceProductId]()
RETURNS INT
AS
BEGIN
	RETURN (SELECT TOP(1) product_id
			FROM products
			ORDER BY price DESC)
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_InsuranceTimeById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[get_InsuranceTimeById](@id int)
RETURNS NVARCHAR(255)
AS
BEGIN
    DECLARE @name NVARCHAR(255)
    SELECT @name = time
            FROM insurances
            WHERE insurance_id = @id
    RETURN @name
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_LastOrderId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_LastOrderId]()
RETURNS INT
AS
BEGIN
    RETURN (SELECT TOP(1) order_id
            FROM orders
            ORDER BY order_id DESC)
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_LowestPriceProductId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_LowestPriceProductId]()
RETURNS INT
AS
BEGIN
	RETURN (SELECT TOP(1) product_id
			FROM products
			ORDER BY price ASC)
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_Price]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[get_Price](@product_id int)  
returns int
as
BEGIN
DECLARE @PRICE INT
select @PRICE = price
	from products 
	where product_id = @product_id
RETURN @PRICE
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_RoleNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_RoleNameById](@id int)  
RETURNS NVARCHAR(255)
AS
BEGIN
	DECLARE @name NVARCHAR(255)
	SELECT @name = roles.name
			FROM roles
			WHERE role_id = @id
	RETURN @name
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_RoleNameByUserName]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_RoleNameByUserName](@username NVARCHAR(255))
RETURNS NVARCHAR(255)
AS
BEGIN
	RETURN (SELECT roles.name
			FROM roles,users
			WHERE users.username = @username AND users.role_id = roles.role_id)
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_totalPriceofOD]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_totalPriceofOD](@OD_id int)------tính giá trị của 1 orderdetail
RETURNS INT
AS
BEGIN
    DECLARE @total INT
    SELECT @total = price*quantity 
            FROM orderdetails OD, products P
            WHERE OD.orderdetail_id = @OD_id AND OD.product_id = P.product_id
    RETURN @total
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_totalPriceofOrder]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_totalPriceofOrder](@Order_id int)------tính giá trị của 1 order
RETURNS INT
AS
BEGIN
    DECLARE @total INT
    SELECT @total = SUM(dbo.get_totalPriceofOD(orderdetail_id))
            FROM orderdetails OD, orders O
            WHERE O.order_id = @Order_id AND O.order_id = OD.order_id
    RETURN @total
END
GO
/****** Object:  UserDefinedFunction [dbo].[get_UserNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_UserNameById](@user_id INT)
RETURNS NVARCHAR(255)
AS
BEGIN
  RETURN (SELECT name
            FROM users
            WHERE user_id = @user_id)
END
GO
/****** Object:  UserDefinedFunction [dbo].[getProductNameById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create FUNCTION [dbo].[getProductNameById](@id INT)
RETURNS NVARCHAR(255) AS
BEGIN
	DECLARE @name NVARCHAR(255) = ''
	SELECT @name = products.name
	FROM products
	WHERE product_id = @id
	RETURN @name
END
GO
/****** Object:  UserDefinedFunction [dbo].[revenue_alltime]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[revenue_alltime]()
returns int
as
begin
declare @totalmoney int;
select 
@totalmoney = sum(total_money)
from orders
return @totalmoney
end;
GO
/****** Object:  Table [dbo].[orders]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[seller_id] [int] NOT NULL,
	[sold_date] [datetime] NOT NULL,
	[total_money] [int] NOT NULL,
 CONSTRAINT [PK__order__46596229509BECE7] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[find_OrderByCustomerId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[find_OrderByCustomerId](@customer_id int)  
RETURNS TABLE
AS
	RETURN (SELECT *
			FROM orders
			WHERE customer_id = @customer_id)
GO
/****** Object:  Table [dbo].[products]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[price] [int] NOT NULL,
	[image] [nvarchar](255) NULL,
	[brand_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[insuarence_id] [int] NULL,
 CONSTRAINT [PK__product__47027DF5DCE3F980] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[find_ProductByBrandId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[find_ProductByBrandId](@brand_id int)  
RETURNS TABLE
AS
	RETURN (SELECT *
			FROM products
			WHERE brand_id = @brand_id)
GO
/****** Object:  UserDefinedFunction [dbo].[find_ProductByCategoryId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[find_ProductByCategoryId](@category_id int)  
RETURNS TABLE
AS
	RETURN (SELECT *
			FROM products
			WHERE category_id = @category_id)
GO
/****** Object:  UserDefinedFunction [dbo].[find_ProductById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[find_ProductById](@id int)
returns table
as
return
( select *
 from products
 where product_id = @id)
GO
/****** Object:  UserDefinedFunction [dbo].[find_ProductByInsuranceId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[find_ProductByInsuranceId](@insurance_id int)  
RETURNS TABLE
AS
	RETURN (SELECT *
			FROM products
			WHERE insuarence_id = @insurance_id)
GO
/****** Object:  Table [dbo].[users]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[phone_number] [char](10) NULL,
	[role_id] [int] NOT NULL,
	[username] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__user__B9BE370FBB346B7F] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[find_UserById]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[find_UserById](@id int)  
RETURNS TABLE
AS
	RETURN (SELECT *
			FROM users
			WHERE user_id = @id)
GO
/****** Object:  UserDefinedFunction [dbo].[find_UserByRoleId]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[find_UserByRoleId](@roleId int)  
returns table
as
return
(select *
 from users
 where user_id = @roleId)
GO
/****** Object:  UserDefinedFunction [dbo].[get_HighestPrice]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_HighestPrice]()
RETURNS TABLE
AS
	RETURN (SELECT TOP(1) * FROM products ORDER BY price DESC)

GO
/****** Object:  UserDefinedFunction [dbo].[get_LowestPrice]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[get_LowestPrice]()
RETURNS TABLE
AS
	RETURN (SELECT TOP(1) *
			FROM products 
			ORDER BY price ASC)

GO
/****** Object:  UserDefinedFunction [dbo].[view_IncomeByYear]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[view_IncomeByYear]()
RETURNS TABLE
AS
	RETURN(	SELECT year(sold_date) AS year, SUM(total_money) AS SUM
		FROM orders
		GROUP BY year(sold_date))
GO
/****** Object:  Table [dbo].[roles]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__role__760965CC92E4270A] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_UserRoleAdmin]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[view_UserRoleAdmin] AS 
SELECT users.name, phone_number
FROM users
inner JOIN roles
ON users.role_id = roles.role_id
WHERE roles.name='admin'


GO
/****** Object:  View [dbo].[view_UserRoleManager]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_UserRoleManager] AS 
SELECT users.name, phone_number
FROM users
inner JOIN roles
ON users.role_id = roles.role_id
WHERE roles.name='manager'
GO
/****** Object:  View [dbo].[view_UserRoleSeller]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_UserRoleSeller] AS 
SELECT users.name, phone_number
FROM users
inner JOIN roles
ON users.role_id = roles.role_id
WHERE roles.name='seller'
GO
/****** Object:  View [dbo].[UserRoleAdmin]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UserRoleAdmin] AS
SELECT users.name, phone_number
FROM users
inner JOIN roles
ON users.role_id = roles.role_id
WHERE roles.name='admin'
GO
/****** Object:  Table [dbo].[orderdetails]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetails](
	[product_id] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK__orderdet__59AE7411C35D6AAB] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC,
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_IncomeOfProduct]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[view_IncomeOfProduct]
AS 
SELECT products.name as 'Tên sản phẩm', sum(quantity*price) as 'Doanh thu'
FROM orderdetails, products
WHERE orderdetails.product_id = products.product_id
GROUP BY orderdetails.product_id, products.name
GO
/****** Object:  Table [dbo].[customers]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[age] [int] NULL,
	[phone_number] [varchar](11) NOT NULL,
 CONSTRAINT [PK__customer__CD65CB8557742A03] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_IncomeFromCustomer]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_IncomeFromCustomer]
AS 
SELECT customers.name as 'Tên khách hàng', sum(total_money) as 'Doanh thu'
FROM orders, customers
WHERE orders.customer_id = customers.customer_id
GROUP BY orders.customer_id, customers.name
GO
/****** Object:  Table [dbo].[brands]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brands](
	[brand_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[brand_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insurances]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insurances](
	[insurance_id] [int] IDENTITY(1,1) NOT NULL,
	[time] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__insuaren__7CAB47A03F7AE814] PRIMARY KEY CLUSTERED 
(
	[insurance_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_Products]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Products]
AS
    SELECT P.product_id as 'ID',P.name as 'Ten',P.price as 'Gia',
            B.name as 'ThuongHieu',C.name as 'Loai',I.time as 'BaoHanh', P.image as 'Hinh'
    FROM products P,brands B,categories C,insurances I
    WHERE   P.brand_id = B.brand_id 
            AND P.category_id = C.category_id
            AND P.insuarence_id = I.insurance_id
GO
/****** Object:  View [dbo].[view_Orders]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create VIEW [dbo].[view_Orders]
AS
    SELECT o.order_id as 'ID', o.sold_date as 'date', o.total_money as 'money',
	C.name as 'Ten', U.name as 'TenNV'
    FROM orders O, users U, customers C
    WHERE   O.customer_id = C.customer_id
		and O.seller_id = U.user_id
GO
SET IDENTITY_INSERT [dbo].[brands] ON 

INSERT [dbo].[brands] ([brand_id], [name]) VALUES (1, N'Asus')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (2, N'Acer')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (3, N'Lenovo')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (4, N'Dell')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (5, N'Apple')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (6, N'Orange')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (7, N'Grape')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (8, N'Durian')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (9, N'Cucumber')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (10, N'Pineapple')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (11, N'sdfgh')
INSERT [dbo].[brands] ([brand_id], [name]) VALUES (14, N'bao bao')
SET IDENTITY_INSERT [dbo].[brands] OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([category_id], [name]) VALUES (1, N'Mouse')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (2, N'Screen')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (3, N'Laptop')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (4, N'PC')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (5, N'Headphone')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (6, N'Key board')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (7, N'Ram')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (8, N'USB')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (9, N'Fan')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (10, N'Earphone')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (13, N'nhap nhap')
INSERT [dbo].[categories] ([category_id], [name]) VALUES (14, N'nahp ')
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (1, N'Nguyễn Đức Tôngggg', 20, N'0909090909')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (2, N'Nguyễn Minh Duck', 20, N'0121153122')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (3, N'Lê Bảo Bảo', 20, N'0123111111')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (4, N'Tạ Quốc Anh', 20, N'0123665894')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (5, N'Phạm Quang Hưng', 20, N'0909000000')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (12, N'Lê Quang Liêm', 25, N'01234567890')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (13, N'Đoàn Minh Đức', 95, N'03133113220')
INSERT [dbo].[customers] ([customer_id], [name], [age], [phone_number]) VALUES (17, N'Jang Hong-ruu', 23, N'45154156111')
SET IDENTITY_INSERT [dbo].[customers] OFF
GO
SET IDENTITY_INSERT [dbo].[insurances] ON 

INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (1, N'1 yearsss')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (2, N'2 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (3, N'3 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (4, N'4 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (5, N'5 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (6, N'6 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (7, N'7 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (8, N'8 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (9, N'9 years')
INSERT [dbo].[insurances] ([insurance_id], [time]) VALUES (10, N'10 years')
SET IDENTITY_INSERT [dbo].[insurances] OFF
GO
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (1, 24, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (1, 26, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (1, 28, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (1, 30, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (1, 34, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (4, 27, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (4, 30, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (4, 34, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (5, 24, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (5, 31, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (6, 26, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (6, 27, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (6, 28, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (6, 31, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (8, 24, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (8, 28, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (8, 30, 2)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (9, 26, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (9, 27, 1)
INSERT [dbo].[orderdetails] ([product_id], [order_id], [quantity]) VALUES (18, 29, 4)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (24, 5, 7, CAST(N'2021-06-23T00:00:00.000' AS DateTime), 2515)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (26, 13, 7, CAST(N'2021-08-03T00:00:00.000' AS DateTime), 232)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (27, 17, 7, CAST(N'2021-09-08T00:00:00.000' AS DateTime), 521)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (28, 2, 7, CAST(N'2021-09-09T00:00:00.000' AS DateTime), 508)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (29, 4, 7, CAST(N'2021-09-09T00:00:00.000' AS DateTime), 325)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (30, 1, 7, CAST(N'2021-09-12T00:00:00.000' AS DateTime), 577)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (31, 17, 7, CAST(N'2021-09-12T00:00:00.000' AS DateTime), 388)
INSERT [dbo].[orders] ([order_id], [customer_id], [seller_id], [sold_date], [total_money]) VALUES (34, 2, 12, CAST(N'2021-10-21T00:00:00.000' AS DateTime), 299)
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (1, N'Acer Nitro 5123sss', 150, N'1.jpg', 2, 2, 2)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (4, N'Acer Nitro 6', 149, N'1.jpg', 2, 3, 2)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (5, N'Acer Nitro 7', 169, N'1.jpg', 2, 3, 3)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (6, N'Acer Nitro 8', 219, N'1.jpg', 2, 3, 4)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (7, N'Asus 1', 129, N'a.jpg', 1, 5, 5)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (8, N'Asus 2', 139, N'2', 1, 6, 6)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (9, N'Asus 3', 299, N'3', 1, 7, 7)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (10, N'Asus 4', 349, N'4', 1, 8, 8)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (11, N'Asus 5', 149, N'5', 1, 9, 9)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (13, N'Asus 6', 299, N'6', 1, 10, 10)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (14, N'girl', 129, N'original-2-15904048419461374664211.jpg', 3, 2, 2)
INSERT [dbo].[products] ([product_id], [name], [price], [image], [brand_id], [category_id], [insuarence_id]) VALUES (18, N'mồn lèo', 999, N'maxresdefault.jpg', 6, 1, 10)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([role_id], [name]) VALUES (1, N'admin')
INSERT [dbo].[roles] ([role_id], [name]) VALUES (2, N'manager')
INSERT [dbo].[roles] ([role_id], [name]) VALUES (4, N'seller')
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([user_id], [name], [phone_number], [role_id], [username], [password]) VALUES (7, N'Phạm Quang Hưng', N'0123456789', 1, N'hung', N'123')
INSERT [dbo].[users] ([user_id], [name], [phone_number], [role_id], [username], [password]) VALUES (8, N'nguyen van teo', N'0123555115', 4, N'teonv', N'1234')
INSERT [dbo].[users] ([user_id], [name], [phone_number], [role_id], [username], [password]) VALUES (12, N'test account', N'0123333555', 1, N'', N'')
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[orderdetails] ADD  DEFAULT ((1)) FOR [quantity]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [fk_order_id] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [fk_order_id]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [fk_product_id] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [fk_product_id]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [fk_customer_id] FOREIGN KEY([customer_id])
REFERENCES [dbo].[customers] ([customer_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [fk_customer_id]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [fk_seller_id] FOREIGN KEY([seller_id])
REFERENCES [dbo].[users] ([user_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [fk_seller_id]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK__product__insuare__4AB81AF0] FOREIGN KEY([insuarence_id])
REFERENCES [dbo].[insurances] ([insurance_id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK__product__insuare__4AB81AF0]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [fk_brand_id] FOREIGN KEY([brand_id])
REFERENCES [dbo].[brands] ([brand_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [fk_brand_id]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [fk_category_id] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([category_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [fk_category_id]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [fk_role_id] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([role_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [fk_role_id]
GO
/****** Object:  StoredProcedure [dbo].[sp_countTotalbyYear]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_countTotalbyYear]
@year INT 
AS
    SELECT MONTH(sold_date) AS 'Tháng', SUM(total_money) as 'Doanh thu'
    FROM orders
    WHERE CAST(YEAR(sold_date) AS INT)= @year
    GROUP BY YEAR(sold_date),MONTH(sold_date)
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerFilter]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_CustomerFilter]
@name NVARCHAR(255)
AS
BEGIN
	Set NoCount ON  
	DECLARE @SQLQuery AS NVARCHAR(4000)  
	DECLARE @ParamDefinition AS NVARCHAR(2000)   
    SET @SQLQuery ='SELECT C.customer_id, C.age, C.name, C.phone_number FROM customers C'
	IF (@name Is NOT NULL) AND (@name <> '')
		SET @SQLQuery = @SQLQuery + ' WHERE C.name LIKE '''+ '%' + @name + '%' + ''''
	SET @ParamDefinition = '@name nvarchar(255)'  
         Execute sp_Executesql @SQLQuery,@ParamDefinition,@name
END
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteAllOD]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deleteAllOD]
@order_id INT 
AS
    DELETE FROM orderdetails where orderdetails.order_id = @order_id
	delete from orders where order_id = @order_id
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBrand]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------Brand-----------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_DeleteBrand] 
 @brand_id int
AS
BEGIN
  DELETE FROM brands where brand_id = @brand_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCategory]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------Category-------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteCategory] 
 @category_id int
AS
BEGIN
  DELETE FROM categories where category_id = @category_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomer]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------Customer-------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteCustomer] 
 @customer_id int
AS
BEGIN
  DELETE FROM customers where customer_id = @customer_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteInsurance]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------insurance----------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteInsurance] 
 @insurance_id int
AS
BEGIN
  DELETE FROM insurances where insurance_id = @insurance_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteOrder]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-------Order---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteOrder] 
 @order_id int
AS
BEGIN
  DELETE FROM orders where order_id = @order_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteOrderdetail]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------Orderdetail----------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteOrderdetail] 
 @order_id int
AS
BEGIN
  DELETE FROM orderdetails where order_id = @order_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProduct]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----Product------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteProduct] 
 @product_id int
AS
BEGIN
  DELETE FROM products where product_id = @product_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteRole]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------Role-----------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[sp_DeleteRole] 
 @role_id int
AS
BEGIN
  DELETE FROM roles where role_id = @role_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUser]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------User-----

CREATE PROCEDURE [dbo].[sp_DeleteUser] 
 @user_id int
AS
BEGIN
  DELETE FROM users where user_id = @user_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetIncome]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_GetIncome]
@sold_date datetime
AS
Begin
    SELECT sum(total_money) as TotalPrice
    FROM orders 
    where MONTH(sold_date) = MONTH(@sold_date) and YEAR(sold_date)=YEAR(@sold_date)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertBrand]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertBrand] 
 @name nvarchar(255)
AS
BEGIN
  insert into brands(name) values (@name)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCategory]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertCategory] 
 @name nvarchar(255)
AS
BEGIN
  insert into categories(name) values (@name)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCustomer]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertCustomer]
 @name nvarchar(255),
 @age int,
 @phone_number nvarchar(11)
AS
BEGIN
  insert into customers(name,age,phone_number) values (@name,@age,@phone_number)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertInsurance]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertInsurance] 
 @time nvarchar(255)
AS
BEGIN
  insert into insurances(time) values (@time)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertOrder]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertOrder] 
 @customer_id int,
 @seller_id int,
 @sold_date datetime,
 @total_money int
AS
BEGIN
  insert into orders(customer_id,seller_id,sold_date,total_money) values (@customer_id,@seller_id,@sold_date,@total_money)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertOrderdetail]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertOrderdetail] 
 @product_id int,
 @order_id int,
 @quantity int
AS
BEGIN
  insert into orderdetails(product_id,order_id,quantity) values (@product_id,@order_id,@quantity)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProduct]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertProduct] 
 @name nvarchar(255),
 @price decimal(18,0),
 @image nvarchar(255),
 @brand_id int,
 @category_id int,
 @insurance_id int
AS
BEGIN
  insert into products(name,price,image,brand_id,category_id,insuarence_id) values (@name,@price,@image,@brand_id,@category_id,@insurance_id)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRole]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertRole] 
 @name nvarchar(255)
AS
BEGIN
  insert into roles(name) values (@name)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUser]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertUser] 
 @name nvarchar(255),
 @phone_number char(10),
 @role_id int,
 @username nvarchar(255),
 @password nvarchar(255)
AS
BEGIN
  insert into users(name,phone_number,role_id,username,password) values (@name,@phone_number,@role_id,@username,@password)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ProductsFilter]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_ProductsFilter]
@name NVARCHAR(255),
@brand_id INT,
@category_id INT
AS
BEGIN
	Set NoCount ON  
	DECLARE @SQLQuery AS NVARCHAR(4000)  
	DECLARE @ParamDefinition AS NVARCHAR(2000)   
    SET @SQLQuery ='SELECT P.product_id, P.name, P.price,P.image, P.brand_id, P.category_id, P.insuarence_id
					FROM products P,brands B,categories C,insurances I
					WHERE P.brand_id = B.brand_id AND 
        P.category_id = C.category_id AND
        P.insuarence_id = I.insurance_id'
	IF (@name Is NOT NULL) AND (@name <> '')
		SET @SQLQuery = @SQLQuery + ' AND P.name LIKE '''+ '%' + @name + '%' + ''''
    IF (@brand_id Is Not Null) and (@brand_id <> 0)  
		Set @SQLQuery = @SQLQuery + ' AND P.brand_id = @brand_id'  
	IF (@category_id Is Not Null) and (@category_id <> 0)  
		Set @SQLQuery = @SQLQuery + ' AND P.category_id = @category_id'  
	SET @ParamDefinition = '@name nvarchar(255),@brand_id int,@category_id int'  
         Execute sp_Executesql @SQLQuery,@ParamDefinition,@name,@brand_id,@category_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_search]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_search]
@name nvarchar(255),
@brand_id int,
@category_id int
as
begin
    select * 
    from products p
    where @brand_id=p.brand_id and @category_id=p.category_id and p.name like '%[@name]%' escape '\'
end



GO
/****** Object:  StoredProcedure [dbo].[sp_testProcedure]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_testProcedure]
@user_id INT
AS
	select user_id from users where user_id= @user_id
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateBrand]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateBrand] 
 @brand_id int,
 @name nvarchar(255)
AS
BEGIN
  update brands set name = @name
	where brand_id= @brand_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCategory]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateCategory] 
 @category_id int,
 @name nvarchar(255)
AS
BEGIN
  update categories set name = @name
	 where category_id = @category_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCustomer]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateCustomer] 
 @customer_id int,
 @name nvarchar(255),
 @age int,
 @phone_number nvarchar(11)
AS
BEGIN
  update customers set name = @name, age = @age, phone_number= @phone_number
	  where customer_id= @customer_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateInsurance]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateInsurance] 
 @insurance_id int,
 @time nvarchar(255)
AS
BEGIN
  update insurances set time = @time 
	where insurance_id = @insurance_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateOrder]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateOrder] 
 @order_id int,
 @customer_id int,
 @seller_id int,
 @sold_date datetime,
 @total_money int
AS
BEGIN
  update orders set customer_id = @customer_id, seller_id = @seller_id, sold_date = @sold_date, total_money = @total_money
	 where order_id = @order_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateOrderdetail]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateOrderdetail] 
 @product_id int,
 @order_id int,
 @quantity int
AS
BEGIN
  update orderdetails set product_id = @product_id, order_id = @order_id, quantity = @quantity
	 where @product_id = product_id and @order_id = order_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateOrderPrice]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateOrderPrice] 
@order_id INT
AS
BEGIN
  update orders set total_money = dbo.get_totalPriceofOrder(order_id)
     where order_id = @order_id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProduct]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateProduct] 
 @product_id int,
 @name nvarchar(255),
 @price decimal(18,0),
 @image nvarchar(255),
 @brand_id int,
 @category_id int,
 @insurance_id int
AS
BEGIN
  update products set name = @name, price = @price, image = @image, brand_id = @brand_id, category_id = @category_id, insuarence_id = @insurance_id
	 where product_id = @product_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRole]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateRole] 
 @role_id int, 
 @name nvarchar(255)
AS
BEGIN
  update roles set name = @name
	 where role_id= @role_id
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUser]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateUser] 
 @user_id int,
 @name nvarchar(255),
 @phone_number char(10),
 @role_id int,
 @username nvarchar(255),
 @password nvarchar(255)
AS
BEGIN
  update users set name = @name, phone_number = @phone_number, role_id = @role_id, username = @username, password = @password
	 where user_id= @user_id
END
GO
/****** Object:  Trigger [dbo].[Check_BrandName]    Script Date: 10/24/2021 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------Brands-----------------------------------


Create TRIGGER [dbo].[Check_BrandName] -- TÊN THƯƠNG HIỆU KHÔNG ĐƯỢC TRÙNG NHAU
ON [dbo].[brands]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @NAME AS NVARCHAR(255), @TEMP AS INT
	SELECT @NAME = inserted.NAME FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.brands
		WHERE NAME= @NAME
	IF (@TEMP>1)
		BEGIN
			PRINT N'Thương hiệu đã tồn tại'
			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[brands] ENABLE TRIGGER [Check_BrandName]
GO
/****** Object:  Trigger [dbo].[Check_CategoryName]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------Categories----------------------------

Create TRIGGER [dbo].[Check_CategoryName] -- TÊN LOẠI SẢN PHẨM KHÔNG ĐƯỢC TRÙNG NHAU
ON [dbo].[categories]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @NAME AS NVARCHAR(255), @TEMP AS INT
	SELECT @NAME = inserted.NAME FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.categories
		WHERE NAME= @NAME
	IF (@TEMP>1)
		BEGIN
			PRINT N'Loại sản phẩm đã tồn tại'
			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[categories] ENABLE TRIGGER [Check_CategoryName]
GO
/****** Object:  Trigger [dbo].[Check_CusPhoneNumber]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create TRIGGER [dbo].[Check_CusPhoneNumber] -- KIỂM TRA ĐỊNH DẠNG SỐ ĐIỆN THOẠI
ON [dbo].[customers]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @PHONE_NUMBER AS VARCHAR(11)
	SELECT @PHONE_NUMBER=inserted.PHONE_NUMBER FROM inserted
	IF ((SELECT ISNUMERIC(@PHONE_NUMBER))=0)
	BEGIN
		PRINT(N'Số điện thoại không được chứa kí tự khác chữ số')
		ROLLBACK TRAN
	END
	ELSE IF(LEN(@PHONE_NUMBER)<10)
	BEGIN
	PRINT(N'Số điện thoại phải nhiều hơn 10 chữ số')
		ROLLBACK TRAN
	END
END

GO
ALTER TABLE [dbo].[customers] ENABLE TRIGGER [Check_CusPhoneNumber]
GO
/****** Object:  Trigger [dbo].[Check_Customer]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------Customers----------------------------
	

Create TRIGGER [dbo].[Check_Customer] -- KIỂM TRA KHÁCH HÀNG ĐÃ TỒN TẠI HAY CHƯA
ON [dbo].[customers]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @NAME AS NVARCHAR(255),@AGE AS INT,
		@PHONE_NUMBER AS VARCHAR(11), @TEMP AS INT
	SELECT @NAME = inserted.NAME FROM inserted
	SELECT @PHONE_NUMBER = inserted.PHONE_NUMBER FROM inserted
	SELECT @AGE = inserted.AGE FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.customers
		WHERE NAME= @NAME 
	IF (@TEMP>1)
		BEGIN
			PRINT N'Tên khách hàng đã tồn tại'
			ROLLBACK TRANSACTION
		END
	SELECT @TEMP=COUNT(*) FROM dbo.customers
		WHERE @PHONE_NUMBER = PHONE_NUMBER
	IF (@TEMP>1)
		BEGIN
			PRINT N'Số điện thoại đã tồn tại'
			ROLLBACK TRANSACTION
		END
	IF (@AGE<18)
		BEGIN
			PRINT N'Tuổi phải trên 18'
			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[customers] ENABLE TRIGGER [Check_Customer]
GO
/****** Object:  Trigger [dbo].[Check_InsuranceName]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------Insurances-----------------------

Create TRIGGER [dbo].[Check_InsuranceName] -- THỜI GIAN BẢO HÀNH KHÔNG ĐƯỢC TRÙNG NHAU
ON [dbo].[insurances]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @TIME AS NVARCHAR(255), @TEMP AS INT
	SELECT @TIME = inserted.TIME FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.insurances
		WHERE TIME= @TIME
	IF (@TEMP>1)
		BEGIN
			PRINT N'Thời hạn bảo hành đã tồn tại'
			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[insurances] ENABLE TRIGGER [Check_InsuranceName]
GO
/****** Object:  Trigger [dbo].[Check_ODQuantity]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------Oderdetails----------------------

Create TRIGGER [dbo].[Check_ODQuantity] -- SỐ LƯỢNG SẢN PHẨM KHÔNG ĐƯỢC ÂM
ON [dbo].[orderdetails]
FOR INSERT
AS
BEGIN
	DECLARE @QUANTITY AS INT
	SELECT @QUANTITY = inserted.QUANTITY FROM inserted
	IF (@QUANTITY<0)
			BEGIN
				PRINT N'Số lượng không thể âm'
				ROLLBACK TRANSACTION
			END
END

GO
ALTER TABLE [dbo].[orderdetails] ENABLE TRIGGER [Check_ODQuantity]
GO
/****** Object:  Trigger [dbo].[Check_Price]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create TRIGGER [dbo].[Check_Price] -- GIÁ SẢN PHẨM KHÔNG ĐƯỢC ÂM
ON [dbo].[products]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @PRICE AS INT
	SELECT @PRICE =inserted.PRICE FROM inserted
	IF (@PRICE<0)
		BEGIN
			PRINT N'Giá sản phẩm không thể âm'
			ROLLBACK TRANSACTION
			END
END

GO
ALTER TABLE [dbo].[products] ENABLE TRIGGER [Check_Price]
GO
/****** Object:  Trigger [dbo].[Check_ProductName]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------Products---------------------

Create TRIGGER [dbo].[Check_ProductName] -- TÊN SẢN PHẨM KHÔNG ĐƯỢC TRÙNG NHAU
ON [dbo].[products]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @NAME AS NVARCHAR(255), @TEMP AS INT
	SELECT @NAME=inserted.name FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.products
		WHERE NAME=@NAME
	IF (@TEMP>1)
		BEGIN
			PRINT N'Tên sản phẩm bị trùng'
			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[products] ENABLE TRIGGER [Check_ProductName]
GO
/****** Object:  Trigger [dbo].[Check_Password]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Check_Password] -- MẬT KHẨU CỦA NGƯỜI DÙNG KHÔNG ĐƯỢC DƯỚI 8 KÍ TỰ
ON [dbo].[users]
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @PASSWORD AS NVARCHAR(255), @TEMP AS INT
	SELECT @PASSWORD=inserted.PASSWORD FROM inserted
	IF (LEN(@PASSWORD)<8)
		BEGIN
			PRINT N'Mật khẩu phải nhiều hơn 8 kí tự'
 			ROLLBACK TRANSACTION
		END
END

GO
ALTER TABLE [dbo].[users] ENABLE TRIGGER [Check_Password]
GO
/****** Object:  Trigger [dbo].[Check_User]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------Users---------------------------------

Create TRIGGER [dbo].[Check_User] -- TÊN ĐĂNG NHẬP CỦA NGƯỜI DÙNG KHÔNG ĐƯỢC TRÙNG NHAU
ON [dbo].[users]
FOR INSERT, UPDATE
AS
BEGIN
 	DECLARE @USERNAME AS NVARCHAR(255), @TEMP AS INT
	SELECT @USERNAME=inserted.USERNAME FROM inserted
	SELECT @TEMP=COUNT(*) FROM dbo.users
		WHERE USERNAME=@USERNAME
	IF (@TEMP>1)
 		BEGIN
 			PRINT N'Người dùng đã tồn tại'
 			ROLLBACK TRANSACTION
 		END
END

GO
ALTER TABLE [dbo].[users] ENABLE TRIGGER [Check_User]
GO
/****** Object:  Trigger [dbo].[Check_UserPhoneNumber]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create TRIGGER [dbo].[Check_UserPhoneNumber] -- KIỂM TRA ĐỊNH DẠNG SỐ ĐIỆN THOẠI
ON [dbo].[users]
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @PHONE_NUMBER AS VARCHAR(11)
	SELECT @PHONE_NUMBER=inserted.PHONE_NUMBER FROM inserted
	IF ((SELECT ISNUMERIC(@PHONE_NUMBER))=0)
	BEGIN
		PRINT(N'Số điện thoại không được chứa kí tự khác chữ số')
		ROLLBACK TRAN
	END
	ELSE IF(LEN(@PHONE_NUMBER)<10)
	BEGIN
	PRINT(N'Số điện thoại phải nhiều hơn 10 chữ số')
		ROLLBACK TRAN
	END
END

GO
ALTER TABLE [dbo].[users] ENABLE TRIGGER [Check_UserPhoneNumber]
GO
/****** Object:  Trigger [dbo].[trg_AccountUser]    Script Date: 10/24/2021 9:39:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_AccountUser] ON [dbo].[users]
AFTER INSERT AS
BEGIN

    DECLARE @username NVARCHAR(50), @pass NVARCHAR(20), @type NVARCHAR(20), @sql NVARCHAR(MAX);
    SELECT @type = role_id, @username = username , @pass = password FROM inserted 
    SET @sql=' CREATE LOGIN '+@username+' WITH Password = ''' + @pass + ''''
    EXEC (@sql) 
    SET @sql= 'CREATE USER ' + @username+ ' FOR LOGIN ' + @username
    EXEC (@sql)

    IF (@type = 1) -- Phân loại nhân viên
        BEGIN
            SET @sql= 'sp_addrolemember' + '''RoleAdmin''' + ',' + @username
            EXEC (@sql)
        END
    ELSE IF (@type = 2)
        BEGIN
            SET @sql= 'sp_addrolemember' + '''RoleManager''' + ',' + @username
            EXEC (@sql)
        END

    ELSE IF (@type = 4)
        BEGIN
            SET @sql= 'sp_addrolemember' + '''RoleSeller''' + ',' + @username
            EXEC (@sql)
        END
END
GO
ALTER TABLE [dbo].[users] ENABLE TRIGGER [trg_AccountUser]
GO
