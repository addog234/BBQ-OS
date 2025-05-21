USE BBQ;
CREATE TABLE Employees (
    ManagerID NVARCHAR(8) PRIMARY KEY,  -- 管理者編號，8碼，主鍵
    Name NVARCHAR(30) NOT NULL,         -- 姓名
    Position NVARCHAR(20),              -- 職位
    Permission NVARCHAR(1),             -- 權限 (A, B, C)
    Password NVARCHAR(16) NOT NULL,     -- 密碼（只能包含英文和數字）
    Phone NVARCHAR(20),                 -- 電話
    Address NVARCHAR(100),              -- 住址
    Email NVARCHAR(50),                 -- EMAIL
    HireDate DATETIME NOT NULL,         -- 到職日期
    ResignDate DATETIME                 -- 離職日期 (可為NULL)
);

-- 會員資料表 (Member)
CREATE TABLE Member (
    MemberID NVARCHAR(20) PRIMARY KEY,   -- 會員編號 (主鍵，必填)
    Name NVARCHAR(50) NOT NULL,          -- 姓名 (必填)
    Phone NVARCHAR(20) NULL,             -- 電話 (可為空值)
    Address NVARCHAR(100) NULL,          -- 住址 (可為空值)
    Email NVARCHAR(100) NULL,            -- EMAIL (可為空值)
    Points INT NULL,                     -- 點數 (可為空值)
    Birthdate DATE NULL,                 -- 生日 (可為空值)
    Status NVARCHAR(10) NULL             -- 狀態 (可為空值，VIP或黑名單)
);

-- 產品資料表 (Product)
CREATE TABLE Product (
    ProductID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- 產品編號 (主鍵，不可空值)
	 ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,               -- 產品類別 (不可空值)
    UnitPrice DECIMAL(10, 0) NOT NULL,            -- 單價 (不可空值)
    Cost DECIMAL(10, 0) NOT NULL,                 -- 成本 (不可空值)
    Status NVARCHAR(10) NOT NULL                  -- 狀態 (不可空值，正常/下架/無庫存)
);

-- 庫存資料表 (Stock)
CREATE TABLE Stock (
    ProductID NVARCHAR(20) PRIMARY KEY,           -- 商品編號 (主鍵，且作為外來鍵)
    StockQuantity INT NOT NULL,                   -- 庫存數量 (不可空值)
    Status NVARCHAR(10) NOT NULL,                 -- 狀態 (不可空值，正常/無庫存等)
    
    CONSTRAINT FK_Product_Stock FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- 訂單資料表 (Orders)
CREATE TABLE Orders (
    OrderID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- 訂單編號 (主鍵)
    MemberID NVARCHAR(20) NOT NULL,             -- 會員編號 (外來鍵)
    OrderDate DATE NOT NULL,                    -- 訂單日期 (不可空)
    Status NVARCHAR(10) NOT NULL,               -- 訂單狀態 (不可空)
    EmployeeID NVARCHAR(8) NULL,                -- 建單人 (員工編號，可空)
	TotalPriceBeforeDiscount DECIMAL(10, 0) NOT NULL DEFAULT 0,  -- 折扣前的總價
    TotalPriceAfterDiscount DECIMAL(10, 0) NOT NULL DEFAULT 0, -- 折扣後的總價

    -- 外來鍵約束
    CONSTRAINT FK_Order_Member FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    CONSTRAINT FK_Order_Employee FOREIGN KEY (EmployeeID) REFERENCES Employees(ManagerID)
);

-- 訂單明細表 (OrderDetails)
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1) , -- 訂單明細編號，自動遞增作為主鍵
    OrderID NVARCHAR(20) NOT NULL,               -- 訂單編號 (外來鍵，來自訂單表)
    ProductID NVARCHAR(20) NOT NULL,             -- 產品編號 (外來鍵，來自產品表)
    Quantity INT NOT NULL,                       -- 產品數量 (不可空值)
    UnitPrice DECIMAL(10, 0) NOT NULL,           -- 單價 (不可空值)


    -- 外來鍵約束
    CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
	);
	select * from Orders;
	INSERT INTO Product (ProductID, ProductName, Category, UnitPrice, Cost, Status)
VALUES 
    ('P00001', '紐約客', '牛肉', 800, 400, '正常'),
    ('P00002', '莎朗牛排', '牛肉', 750, 350, '正常'),
    ('P00003', '牛小排', '牛肉', 700, 300, '正常'),
    ('P00004', '牛肋眼', '牛肉', 850, 450, '正常'),
    ('P00005', '黑安格斯牛肉', '牛肉', 900, 500, '正常'),
    ('P00006', '豬五花肉', '豬肉', 500, 250, '正常'),
    ('P00007', '豬小排', '豬肉', 550, 280, '正常'),
    ('P00008', '羊排', '羊肉', 850, 400, '正常'),
    ('P00009', '紐西蘭羊腿', '羊肉', 800, 380, '正常'),
    ('P00010', '大海蝦', '海鮮', 800, 400, '正常'),
    ('P00011', '生鮮鮭魚', '海鮮', 1000, 600, '正常'),
    ('P00012', '生鮮扇貝', '海鮮', 1200, 700, '正常'),
    ('P00013', '雞腿肉', '雞肉', 300, 150, '正常'),
    ('P00014', '雞胸肉', '雞肉', 250, 120, '正常'),
    
    ('P00015', '鮮榨果汁', '飲料', 100, 50, '正常'),
    ('P00016', '氣泡水', '飲料', 60, 30, '正常'),
    ('P00017', '碳酸飲料', '飲料', 50, 25, '正常'),
    ('P00018', '瓶裝水', '飲料', 30, 15, '正常'),
    ('P00019', '紅茶', '飲料', 70, 35, '正常'),

    ('P00020', '酸奶', '甜點', 150, 70, '正常'),
    ('P00021', '芒果布丁', '甜點', 120, 60, '正常'),
    ('P00022', '巧克力', '甜點', 180, 90, '正常'),
    ('P00023', '奶酪', '甜點', 200, 100, '正常'),
    ('P00024', '水果沙拉', '甜點', 220, 115, '正常'),

    ('P00025', '小羔羊', '羊肉', 600, 300, '正常'),
    ('P00026', '薄切牛肉', '牛肉', 600, 280, '正常'),
    ('P00027', '蜜汁雞翅', '雞肉', 300, 150, '正常'),
    ('P00028', '生鮮小羊肩', '羊肉', 900, 450, '正常'),
    ('P00029', '生鮮雞肝', '雞肉', 500, 250, '正常'),

    ('P00030', '泰國蝦', '海鮮', 400, 200, '正常');

	INSERT INTO Stock (ProductID, StockQuantity, Status)
VALUES 
    ('P00001', 150, '正常'),
    ('P00002', 100, '正常'),
    ('P00003', 80, '正常'),
    ('P00004', 200, '正常'),
    ('P00005', 120, '正常'),
    ('P00006', 170, '正常'),
    ('P00007', 90, '正常'),
    ('P00008', 160, '正常'),
    ('P00009', 110, '正常'),
    ('P00010', 200, '正常'),
    ('P00011', 150, '正常'),
    ('P00012', 130, '正常'),
    ('P00013', 100, '正常'),
    ('P00014', 80, '正常'),
    
    ('P00015', 150, '正常'),
    ('P00016', 120, '正常'),
    ('P00017', 90, '正常'),
    ('P00018', 200, '正常'),
    ('P00019', 80, '正常'),

    ('P00020', 60, '正常'),
    ('P00021', 100, '正常'),
    ('P00022', 70, '正常'),
    ('P00023', 150, '正常'),
    ('P00024', 80, '正常'),

    ('P00025', 110, '正常'),
    ('P00026', 140, '正常'),
    ('P00027', 90, '正常'),
    ('P00028', 130, '正常'),
    ('P00029', 70, '正常'),

    ('P00030', 200, '正常');
	select * from Stock;


INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
('202410180001', 'P00001', 2, 800.00),  -- 牛紐約客單價 800.00，數量 2
('202410180001', 'P00002', 1, 750.00),  -- 莎朗牛排單價 750.00，數量 1
('202410180002', 'P00004', 1, 850.00),  -- 牛肋眼單價 850.00，數量 1
('202410180002', 'P00006', 3, 500.00),  -- 豬五花肉單價 500.00，數量 3
('202410180003', 'P00010', 2, 800.00),  -- 生鮮蝦單價 800.00，數量 2
('202410180003', 'P00012', 1, 1200.00), -- 生鮮扇貝單價 1200.00，數量 1
('202410180004', 'P00014', 2, 250.00),  -- 雞胸肉單價 250.00，數量 2
('202410180004', 'P00020', 1, 150.00),  -- 酸奶單價 150.00，數量 1
('202410180005', 'P00025', 1, 600.00),  -- 生鮮羊肉片單價 600.00，數量 1
('202410180005', 'P00029', 2, 500.00);  -- 生鮮雞翅單價 500.00，數量 2

INSERT INTO Orders (OrderID, MemberID, OrderDate, Status, EmployeeID, TotalPriceBeforeDiscount, TotalPriceAfterDiscount)
VALUES
-- 王小明是 VIP，訂單總額 (800*2 + 750 = 2350)，打 95 折後總額為 2232.5
('202410180001', 'MEM00001', '2024-10-01', '已完成', NULL, 2350, 2232.5),

-- 李小華是普通會員，訂單總額 (850*1 + 500*3 = 2350)，無折扣
('202410180002', 'MEM00002', '2024-10-02', '已完成', NULL, 2350, 2350),

-- 周志強是 VIP，訂單總額 (800*2 + 1200 = 2800)，打 95 折後總額為 2660
('202410180003', 'MEM00007', '2024-10-03', '已完成', NULL, 2800, 2660),

-- 彭子瑜是普通會員，訂單總額 (250*2 + 150 = 650)，無折扣
('202410180004', 'MEM00010', '2024-10-04', '已完成', NULL, 650, 650),

-- 鄭家欣是普通會員，訂單總額 (600*1 + 500*2 = 1600)，無折扣
('202410180005', 'MEM00017', '2024-10-05', '已完成', NULL, 1600, 1600);

INSERT INTO Member (MemberID, Name, Phone, Address, Email, Points, Birthdate, Status) VALUES
('MEM00001', '王小明', '0912345678', '台北市中正區1號', 'member1@example.com', 150, '1995-06-22', 'VIP'),
('MEM00002', '李小華', '0923456789', '台北市中正區2號', 'member2@example.com', 30, '1990-01-15', '普通'),
('MEM00003', '陳大文', '0934567890', '台北市中正區3號', 'member3@example.com', 80, '1987-05-30', '普通'),
('MEM00004', '張天宇', '0945678901', '台北市中正區4號', 'member4@example.com', 200, '1986-11-05', 'VIP'),
('MEM00005', '許志明', '0956789012', '台北市中正區5號', 'member5@example.com', 60, '1980-07-19', '普通'),
('MEM00006', '劉靜怡', '0967890123', '台北市中正區6號', 'member6@example.com', 25, '1992-03-24', '普通'),
('MEM00007', '周志強', '0978901234', '台北市中正區7號', 'member7@example.com', 300, '1985-08-12', 'VIP'),
('MEM00008', '鄭文彬', '0989012345', '台北市中正區8號', 'member8@example.com', 110, '1991-12-09', 'VIP'),
('MEM00009', '蔡小君', '0912345679', '台北市中正區9號', 'member9@example.com', 75, '1983-01-17', '普通'),
('MEM00010', '彭子瑜', '0923456790', '台北市中正區10號', 'member10@example.com', 45, '1996-06-30', '普通'),
('MEM00011', '廖家豪', '0934567901', '台北市中正區11號', 'member11@example.com', 150, '1984-02-11', 'VIP'),
('MEM00012', '黃家樂', '0945679012', '台北市中正區12號', 'member12@example.com', 5, '1993-10-20', '普通'),
('MEM00013', '吳思瑤', '0956789123', '台北市中正區13號', 'member13@example.com', 60, '1986-09-13', '普通'),
('MEM00014', '鍾文華', '0967890234', '台北市中正區14號', 'member14@example.com', 100, '1990-03-02', '普通'),
('MEM00015', '賴永志', '0978901345', '台北市中正區15號', 'member15@example.com', 20, '1988-04-30', '普通'),
('MEM00016', '徐雅婷', '0989012456', '台北市中正區16號', 'member16@example.com', 90, '1994-12-11', '普通'),
('MEM00017', '鄭家欣', '0912345670', '台北市中正區17號', 'member17@example.com', 66, '1981-05-19', '普通'),
('MEM00018', '吳文煒', '0923456781', '台北市中正區18號', 'member18@example.com', 10, '1995-08-29', '普通'),
('MEM00019', '陳瑤瑤', '0934567892', '台北市中正區19號', 'member19@example.com', 200, '1989-07-07', 'VIP'),
('MEM00020', '何志強', '0945678903', '台北市中正區20號', 'member20@example.com', 50, '1992-06-15', '普通'),
('MEM00021', '林家銘', '0912345789', '台北市中正區21號', 'member21@example.com', 90, '1988-11-20', '普通'),
('MEM00022', '鄭雅雯', '0923456780', '台北市中正區22號', 'member22@example.com', 300, '1985-09-02', 'VIP'),
('MEM00023', '胡政勳', '0934567891', '台北市中正區23號', 'member23@example.com', 120, '1991-02-05', 'VIP'),
('MEM00024', '賴明德', '0945678902', '台北市中正區24號', 'member24@example.com', 70, '1994-05-08', '普通'),
('MEM00025', '宋美華', '0956789013', '台北市中正區25號', 'member25@example.com', 45, '1993-06-15', '普通'),
('MEM00026', '陳冠儀', '0967890124', '台北市中正區26號', 'member26@example.com', 22, '1992-07-29', '普通'),
('MEM00027', '李易峰', '0978901235', '台北市中正區27號', 'member27@example.com', 100, '1991-03-18', '普通'),
('MEM00028', '王小婷', '0989012346', '台北市中正區28號', 'member28@example.com', 89, '1990-01-04', '普通'),
('MEM00029', '劉建明', '0912345678', '台北市中正區29號', 'member29@example.com', 120, '1989-09-25', 'VIP'),
('MEM00030', '陳宇辰', '0923456789', '台北市中正區30號', 'member30@example.com', 60, '1993-04-22', '普通'),
('MEM00031', '吳少梅', '0934567890', '台北市中正區31號', 'member31@example.com', 105, '1985-10-12', 'VIP'),
('MEM00032', '周莉莉', '0945678901', '台北市中正區32號', 'member32@example.com', 15, '1996-06-28', '普通'),
('MEM00033', '鄭志豪', '0956789012', '台北市中正區33號', 'member33@example.com', 80, '1988-12-17', '普通'),
('MEM00034', '鍾建國', '0967890123', '台北市中正區34號', 'member34@example.com', 40, '1994-01-22', '普通'),
('MEM00035', '劉子瑜', '0978901234', '台北市中正區35號', 'member35@example.com', 200, '1987-05-03', 'VIP'),
('MEM00036', '張淑芳', '0989012345', '台北市中正區36號', 'member36@example.com', 70, '1981-03-13', '普通'),
('MEM00037', '何思妤', '0912345676', '台北市中正區37號', 'member37@example.com', 22, '1993-04-14', '普通'),
('MEM00038', '賴永華', '0923456787', '台北市中正區38號', 'member38@example.com', 50, '1990-06-19', '普通'),
('MEM00039', '林美婷', '0934567898', '台北市中正區39號', 'member39@example.com', 75, '1992-09-09', '普通'),
('MEM00040', '蕭展宇', '0945678909', '台北市中正區40號', 'member40@example.com', 35, '1989-01-11', '普通');

INSERT INTO Employees (ManagerID, Name, Position, Permission, Password, Phone, Address, Email, HireDate, ResignDate) VALUES
('EMP01', '張三', '廚師', 'A', 'password1', '0912345678', '地址1', 'employee1@example.com', '2023-06-15 00:00:00', NULL),
('EMP02', '李四', '服務員', 'B', 'password2', '0923456789', '地址2', 'employee2@example.com', '2023-04-12 00:00:00', '2024-04-12 00:00:00'),
('EMP03', '王五', '經理', 'A', 'password3', '0934567890', '地址3', 'employee3@example.com', '2023-01-30 00:00:00', NULL),
('EMP04', '趙六', '清潔員', 'C', 'password4', '0945678901', '地址4', 'employee4@example.com', '2022-12-25 00:00:00', NULL),
('EMP05', '孫七', '廚師', 'B', 'password5', '0956789012', '地址5', 'employee5@example.com', '2023-08-10 00:00:00', '2024-07-10 00:00:00'),
('EMP06', '周八', '服務員', 'A', 'password6', '0967890123', '地址6', 'employee6@example.com', '2023-03-11 00:00:00', NULL),
('EMP07', '吳九', '經理', 'B', 'password7', '0978901234', '地址7', 'employee7@example.com', '2023-05-20 00:00:00', NULL),
('EMP08', '鄭十', '清潔員', 'C', 'password8', '0989012345', '地址8', 'employee8@example.com', '2022-11-17 00:00:00', NULL),
('EMP09', '何十一', '廚師', 'A', 'password9', '0912345679', '地址9', 'employee9@example.com', '2023-07-09 00:00:00', '2024-05-09 00:00:00'),
('EMP10', '林十二', '服務員', 'B', 'password10', '0923456790', '地址10', 'employee10@example.com', '2023-09-18 00:00:00', NULL),
('EMP11', '蔡十三', '經理', 'A', 'password11', '0934567901', '地址11', 'employee11@example.com', '2023-02-22 00:00:00', NULL),
('EMP12', '謝十四', '清潔員', 'C', 'password12', '0945679012', '地址12', 'employee12@example.com', '2023-04-30 00:00:00', '2024-03-30 00:00:00'),
('EMP13', '彭十五', '廚師', 'B', 'password13', '0956789123', '地址13', 'employee13@example.com', '2023-01-01 00:00:00', NULL),
('EMP14', '楊十六', '服務員', 'A', 'password14', '0967890234', '地址14', 'employee14@example.com', '2022-09-10 00:00:00', '2024-08-10 00:00:00'),
('EMP15', '陳十七', '經理', 'B', 'password15', '0978901345', '地址15', 'employee15@example.com', '2023-06-01 00:00:00', NULL),
('EMP16', '徐十八', '清潔員', 'C', 'password16', '0989012456', '地址16', 'employee16@example.com', '2022-08-20 00:00:00', NULL),
('EMP17', '馬十九', '廚師', 'A', 'password17', '0912345670', '地址17', 'employee17@example.com', '2023-03-30 00:00:00', '2024-02-28 00:00:00'),
('EMP18', '趙二十', '服務員', 'B', 'password18', '0923456781', '地址18', 'employee18@example.com', '2023-04-21 00:00:00', NULL),
('EMP19', '白二十一', '經理', 'A', 'password19', '0934567892', '地址19', 'employee19@example.com', '2022-10-15 00:00:00', '2024-09-15 00:00:00'),
('EMP20', '藍二十二', '清潔員', 'C', 'password20', '0945678903', '地址20', 'employee20@example.com', '2023-02-12 00:00:00', NULL);