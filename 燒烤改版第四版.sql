USE BBQ10;
-- 類別資料表 (Category)
CREATE TABLE dCategory (
    CategoryID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- 類別編號
    CategoryName NVARCHAR(50) NOT NULL              -- 類別名稱
);

-- 產品資料表 (Product)
CREATE TABLE dProduct (
    ProductID NVARCHAR(20) PRIMARY KEY NOT NULL,    -- 產品編號 (主鍵，不可空值)
    ProductName NVARCHAR(100) NOT NULL,             -- 產品名稱
    CategoryID NVARCHAR(20) NOT NULL,               -- 類別編號 (外來鍵)
    UnitPrice INT NOT NULL,                          -- 單價 (整數，不可空值)
    Cost INT NOT NULL,                               -- 成本 (整數，不可空值)
    PStatus NVARCHAR(10) NOT NULL,                  -- 狀態 (不可空值，正常/下架/無庫存)
	PImage NVARCHAR(100) NULL,                       -- 產品圖片
	 IsDeleted BIT DEFAULT 0,

    -- 外來鍵約束
    CONSTRAINT FK_Product_Category FOREIGN KEY (CategoryID) REFERENCES dCategory(CategoryID)
);

-- 庫存資料表 (Stock)
CREATE TABLE dStock (
    ProductID NVARCHAR(20) PRIMARY KEY,              -- 商品編號 (主鍵，且作為外來鍵)
    StockQuantity INT NOT NULL,                       -- 庫存數量 (不可空值)
    sStatus NVARCHAR(10) NOT NULL,                    -- 狀態 (不可空值，正常/無庫存等)
    
    CONSTRAINT FK_Product_Stock FOREIGN KEY (ProductID) REFERENCES dProduct(ProductID)
);

-- 員工資料表 (Employees)
CREATE TABLE dEmployees (
    EmployeeID NVARCHAR(8) PRIMARY KEY NOT NULL,     -- 員工編號 (主鍵)
    EmpName NVARCHAR(30) NOT NULL,                       -- 姓名
    Position NVARCHAR(20),                            -- 職位
    Permission NVARCHAR(1),                           -- 權限 (A, B, C)
    EmpPassword NVARCHAR(16) NOT NULL,                  -- 密碼（只能包含英文和數字）
    EmpPhone NVARCHAR(20),                               -- 電話
    EmpAddress NVARCHAR(100),                            -- 住址
    EmpEmail NVARCHAR(50),                               -- EMAIL
    HireDate DATETIME NOT NULL,                       -- 到職日期
    ResignDate DATETIME NULL, -- 離職日期 (可為NULL)
	IsDeleted BIT DEFAULT 0 
);

-- 會員資料表 (Member)
CREATE TABLE dMember (
    MemberID NVARCHAR(20) PRIMARY KEY NOT NULL,        -- 會員編號 (主鍵，必填)
    MemName NVARCHAR(50) NOT NULL,                      -- 姓名 (必填)
    MemPassword NVARCHAR(50) NOT NULL,                 -- 密碼 (必填，新增)
    MemPhone NVARCHAR(20) NULL,                         -- 電話 (可為空值)
    MemAddress NVARCHAR(100) NULL,                      -- 住址 (可為空值)
    MemEmail NVARCHAR(100) NULL,                        -- EMAIL (可為空值)
    Points INT NULL,                                    -- 點數 (可為空值)
    MemBirthdate DATETIME NULL,                         -- 生日 (可為空值)
    MStatus NVARCHAR(10) NULL,                          -- 狀態 (可為空值，VIP或黑名單)
    IsDeleted BIT DEFAULT 0                             -- 是否已刪除 (邏輯刪除，預設為 0 表示未刪除)
);

-- 訂單資料表 (Orders)
CREATE TABLE dOrders (
    OrderID NVARCHAR(20) PRIMARY KEY NOT NULL,       -- 訂單編號 (主鍵)
    MemberID NVARCHAR(20) NULL,                      -- 會員編號 (可空，支持非會員訂單)
    OrderDate DateTime NOT NULL,                         -- 訂單日期
    OStatus NVARCHAR(10) NOT NULL,                   -- 訂單狀態 (可考慮使用 ENUM 或狀態參照表)
    EmployeeID NVARCHAR(8) NULL,                     -- 建單人 (外來鍵，指向員工表)
	TableNumber NVARCHAR(10) NULL,                   -- 桌號 (新增欄位，允許空值)
    TotalPriceBeforeDiscount INT NOT NULL DEFAULT 0, -- 折扣前的總價
    TotalPriceAfterDiscount INT NOT NULL DEFAULT 0,  -- 折扣後的總價
	IsDeleted BIT DEFAULT 0                             -- 是否已刪除 (邏輯刪除，預設為 0 表示未刪除)

    -- 外來鍵約束
    CONSTRAINT FK_Order_Member FOREIGN KEY (MemberID) REFERENCES dMember(MemberID),
    CONSTRAINT FK_Order_Employee FOREIGN KEY (EmployeeID) REFERENCES dEmployees(EmployeeID)
);

-- 訂單明細表 (OrderDetails)
CREATE TABLE dOrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,     -- 自動遞增主鍵
    OrderID NVARCHAR(20) NOT NULL,                   -- 訂單編號 (外來鍵，來自訂單表)
    ProductID NVARCHAR(20) NOT NULL,                 -- 產品編號 (外來鍵，來自產品表)
    Quantity INT NOT NULL,                            -- 產品數量
    UnitPrice INT NOT NULL,                           -- 單價 (整數，不可空值)
    
    -- 外來鍵約束
    CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES dOrders(OrderID),
    CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES dProduct(ProductID)
);

INSERT INTO dCategory (CategoryID, CategoryName) VALUES
    ('C0001', '牛肉'),
    ('C0002', '豬肉'),
    ('C0003', '羊肉'),
    ('C0004', '海鮮'),
    ('C0005', '雞肉'),
    ('C0006', '飲料'),
    ('C0007', '甜點');

INSERT INTO dProduct (ProductID, ProductName, CategoryID, UnitPrice, Cost, PStatus, PImage, IsDeleted)
VALUES 
    ('P00001', '紐約客', 'C0001', 800, 400, '正常', '1.jpg', 0),
    ('P00002', '莎朗牛排', 'C0001', 750, 350, '正常', '2.jpg', 0),
    ('P00003', '牛小排', 'C0001', 700, 300, '正常', '3.jpg', 0),
    ('P00004', '牛肋眼', 'C0001', 850, 450, '正常', '4.jpg', 0),
    ('P00005', '黑安格斯牛肉', 'C0001', 900, 500, '正常', '5.jpg', 0),
    ('P00006', '豬五花肉', 'C0002', 500, 250, '正常', '6.jpg', 0),
    ('P00007', '豬小排', 'C0002', 550, 280, '正常', '7.jpg', 0),
    ('P00008', '羊排', 'C0003', 850, 400, '正常', '8.jpg', 0),
    ('P00009', '紐西蘭羊腿', 'C0003', 800, 380, '正常', '9.jpg', 0),
    ('P00010', '大海蝦', 'C0004', 800, 400, '正常', '10.jpg', 0),
    ('P00011', '生鮮鮭魚', 'C0004', 1000, 600, '正常', '11.jpg', 0),
    ('P00012', '生鮮扇貝', 'C0004', 1200, 700, '正常', '12.jpg', 0),
    ('P00013', '雞腿肉', 'C0005', 300, 150, '正常', '13.jpg', 0),
    ('P00014', '雞胸肉', 'C0005', 250, 120, '正常', '14.jpg', 0),
    ('P00015', '鮮榨果汁', 'C0006', 100, 50, '正常', '15.jpg', 0),
    ('P00016', '氣泡水', 'C0006', 60, 30, '正常', '16.jpg', 0),
    ('P00017', '碳酸飲料', 'C0006', 50, 25, '正常', '17.jpg', 0),
    ('P00018', '瓶裝水', 'C0006', 30, 15, '正常', '18.jpg', 0),
    ('P00019', '紅茶', 'C0006', 70, 35, '正常', '19.jpg', 0),
    ('P00020', '酸奶', 'C0007', 150, 70, '正常', '20.jpg', 0),
    ('P00021', '芒果布丁', 'C0007', 120, 60, '正常', '21.jpg', 0),
    ('P00022', '巧克力', 'C0007', 180, 90, '正常', '22.jpg', 0),
    ('P00023', '奶酪', 'C0007', 200, 100, '正常', '23.jpg', 0),
    ('P00024', '水果沙拉', 'C0007', 220, 115, '正常', '24.jpg', 0),
    ('P00025', '小羔羊', 'C0003', 600, 300, '正常', '25.jpg', 0),
    ('P00026', '薄切牛肉', 'C0001', 600, 280, '正常', '26.jpg', 0),
    ('P00027', '蜜汁雞翅', 'C0005', 300, 150, '正常', '27.jpg', 0),
    ('P00028', '生鮮小羊肩', 'C0003', 900, 450, '正常', '28.jpg', 0),
    ('P00029', '生鮮雞肝', 'C0005', 500, 250, '正常', '29.jpg', 0),
    ('P00030', '泰國蝦', 'C0004', 400, 200, '正常', '30.jpg', 0);

	INSERT INTO dMember (MemberID, MemName,MemPassword, MemPhone, MemAddress, MemEmail, Points, MemBirthdate, MStatus, IsDeleted) VALUES
('MEM00001', '王小明', 'password123', '0912345678', '台北市北投區1號', 'member1@example.com', 150, '1995-06-22', 'VIP', 0),
('MEM00002', '李小華', 'password123', '0923456789', '台北市大安區2號', 'member2@example.com', 30, '1990-01-15', '普通', 0),
('MEM00003', '陳大文', 'password123', '0934567890', '台北市內湖區3號', 'member3@example.com', 80, '1987-05-30', '普通', 0),
('MEM00004', '張天宇', 'password123', '0945678901', '新北市板橋區4號', 'member4@example.com', 200, '1986-11-05', 'VIP', 0),
('MEM00005', '許志明', 'password123', '0956789012', '新北市板橋區5號', 'member5@example.com', 60, '1980-07-19', '普通', 0),
('MEM00006', '劉靜怡', 'password123', '0967890123', '台北市信義區6號', 'member6@example.com', 25, '1992-03-24', '普通', 0),
('MEM00007', '周志強', 'password123', '0978901234', '台北市信義區7號', 'member7@example.com', 300, '1985-08-12', 'VIP', 0),
('MEM00008', '鄭文彬', 'password123', '0989012345', '高雄市鳳山區8號', 'member8@example.com', 110, '1991-12-09', 'VIP', 0),
('MEM00009', '蔡小君', 'password123', '0912345679', '高雄市鳳山區9號', 'member9@example.com', 75, '1983-01-17', '普通', 0),
('MEM00010', '彭子瑜', 'password123', '0923456790', '高雄市左營區10號', 'member10@example.com', 45, '1996-06-30', '普通', 0),
('MEM00011', '廖家豪', 'password123', '0934567901', '台中市中山區11號', 'member11@example.com', 150, '1984-02-11', 'VIP', 0),
('MEM00012', '黃家樂', 'password123', '0945679012', '台中市中山區12號', 'member12@example.com', 5, '1993-10-20', '普通', 0),
('MEM00013', '吳思瑤', 'password123', '0956789123', '高雄市茂林區13號', 'member13@example.com', 60, '1986-09-13', '普通', 0),
('MEM00014', '鍾文華', 'password123', '0967890234', '高雄市六龜區14號', 'member14@example.com', 100, '1990-03-02', '普通', 0),
('MEM00015', '賴永志', 'password123', '0978901345', '高雄市甲仙區15號', 'member15@example.com', 20, '1988-04-30', '普通', 0),
('MEM00016', '徐雅婷', 'password123', '0989012456', '台北市士林區16號', 'member16@example.com', 90, '1994-12-11', '普通', 0),
('MEM00017', '鄭家欣', 'password123', '0912345670', '台北市士林區17號', 'member17@example.com', 66, '1981-05-19', '普通', 0),
('MEM00018', '吳文煒', 'password123', '0923456781', '台北市大同區18號', 'member18@example.com', 10, '1995-08-29', '普通', 0),
('MEM00019', '陳瑤瑤', 'password123', '0934567892', '台北市中山區19號', 'member19@example.com', 200, '1989-07-07', 'VIP', 0),
('MEM00020', '何志強', 'password123', '0945678903', '台北市中山區20號', 'member20@example.com', 50, '1992-06-15', '普通', 0),
('MEM00021', '林家銘', 'password123', '0912345789', '台北市萬華區21號', 'member21@example.com', 90, '1988-11-20', '普通', 0),
('MEM00022', '鄭雅雯', 'password123', '0923456780', '台北市信義區22號', 'member22@example.com', 300, '1985-09-02', 'VIP', 0),
('MEM00023', '胡政勳', 'password123', '0934567891', '台北市大安區23號', 'member23@example.com', 120, '1991-02-05', 'VIP', 0),
('MEM00024', '賴明德', 'password123', '0945678902', '新北市中和區24號', 'member24@example.com', 70, '1994-05-08', '普通', 0),
('MEM00025', '宋美華', 'password123', '0956789013', '新北市中和區25號', 'member25@example.com', 45, '1993-06-15', '普通', 0),
('MEM00026', '陳冠儀', 'password123', '0967890124', '新北市淡水區26號', 'member26@example.com', 22, '1992-07-29', '普通', 0),
('MEM00027', '李易峰', 'password123', '0978901235', '新北市淡水區27號', 'member27@example.com', 100, '1991-03-18', '普通', 0),
('MEM00028', '王小婷', 'password123', '0989012346', '新北市新莊區28號', 'member28@example.com', 89, '1990-01-04', '普通', 0),
('MEM00029', '劉建明', 'password123', '0912345678', '新北市新莊區29號', 'member29@example.com', 120, '1989-09-25', 'VIP', 0),
('MEM00030', '陳宇辰', 'password123', '0923456789', '新北市新莊區30號', 'member30@example.com', 60, '1993-04-22', '普通', 0),
('MEM00031', '吳少梅', 'password123', '0934567890', '新北市土城區31號', 'member31@example.com', 105, '1985-10-12', 'VIP', 0),
('MEM00032', '周莉莉', 'password123', '0945678901', '新北市土城區32號', 'member32@example.com', 15, '1996-06-28', '普通', 0),
('MEM00033', '鄭志豪', 'password123', '0956789012', '新北市樹林區33號', 'member33@example.com', 80, '1988-12-17', '普通', 0),
('MEM00034', '鍾建國', 'password123', '0967890123', '台中市中區34號', 'member34@example.com', 40, '1994-01-22', '普通', 0),
('MEM00035', '劉子瑜', 'password123', '0978901234', '台中市中區35號', 'member35@example.com', 200, '1987-05-03', 'VIP', 0),
('MEM00036', '張淑芳', 'password123', '0989012345', '台中市大安36號', 'member36@example.com', 70, '1981-03-13', '普通', 0),
('MEM00037', '何思妤', 'password123', '0912345676', '台北市中正區37號', 'member37@example.com', 22, '1993-04-14', '普通', 0),
('MEM00038', '賴永華', 'password123', '0923456787', '台北市中正區38號', 'member38@example.com', 50, '1990-06-19', '普通', 0),
('MEM00039', '林美婷', 'password123', '0934567898', '台北市中正區39號', 'member39@example.com', 75, '1992-09-09', '普通', 0),
('MEM00040', '蕭展宇', 'password123', '0945678909', '台北市中正區40號', 'member40@example.com', 35, '1989-01-11', '普通', 0);

INSERT INTO dEmployees (EmployeeID, EmpName, Position, Permission, EmpPassword, EmpPhone, EmpAddress, EmpEmail, HireDate, ResignDate, IsDeleted) VALUES
('EMP01', '柔成員', '經理', 'A', 'password1', '0912345678', '台北市北投區公館路100號', 'employee1@example.com', '2023-06-15 00:00:00', NULL, 0),
('EMP02', '李四', '服務員', 'B', 'password2', '0923456789', '台北市中山區98號', 'employee2@example.com', '2023-04-12 00:00:00', '2024-04-12 00:00:00', 0),
('EMP03', '王五', '經理', 'A', 'password3', '0934567890', '台北市松山區97號', 'employee3@example.com', '2023-01-30 00:00:00', NULL, 0),
('EMP04', '趙六', '清潔員', 'C', 'password4', '0945678901', '台北市中正區48號', 'employee4@example.com', '2022-12-25 00:00:00', NULL, 0),
('EMP05', '孫七', '廚師', 'B', 'password5', '0956789012', '台北市中正區89號', 'employee5@example.com', '2023-08-10 00:00:00', '2024-07-10 00:00:00', 0),
('EMP06', '周八', '服務員', 'B', 'password6', '0967890123', '台北市信義區70號', 'employee6@example.com', '2023-03-11 00:00:00', NULL, 0),
('EMP07', '吳九', '經理', 'A', 'password7', '0978901234', '台北市中山區33號', 'employee7@example.com', '2023-05-20 00:00:00', NULL, 0),
('EMP08', '鄭十', '清潔員', 'C', 'password8', '0989012345', '台北市大安109號', 'employee8@example.com', '2022-11-17 00:00:00', NULL, 0),
('EMP09', '何十一', '廚師', 'A', 'password9', '0912345679', '台北市文山區40號', 'employee9@example.com', '2023-07-09 00:00:00', '2024-05-09 00:00:00', 0),
('EMP10', '林十二', '服務員', 'B', 'password10', '0923456790', '台北市北投區公館路99號', 'employee10@example.com', '2023-09-18 00:00:00', NULL, 0),
('EMP11', '蔡十三', '經理', 'A', 'password11', '0934567901', '新北市淡水區777號', 'employee11@example.com', '2023-02-22 00:00:00', NULL, 0),
('EMP12', '謝十四', '清潔員', 'C', 'password12', '0945679012', '新北市淡水區201號', 'employee12@example.com', '2023-04-30 00:00:00', '2024-03-30 00:00:00', 0),
('EMP13', '彭十五', '廚師', 'B', 'password13', '0956789123', '新北市土城區27號', 'employee13@example.com', '2023-01-01 00:00:00', NULL, 0),
('EMP14', '楊十六', '服務員', 'B', 'password14', '0967890234', '新北市新莊區77號', 'employee14@example.com', '2022-09-10 00:00:00', '2024-08-10 00:00:00', 0),
('EMP15', '陳十七', '經理', 'A', 'password15', '0978901345', '新北市三重區27號', 'employee15@example.com', '2023-06-01 00:00:00', NULL, 0),
('EMP16', '徐十八', '清潔員', 'C', 'password16', '0989012456', '新北市三峽區40號', 'employee16@example.com', '2022-08-20 00:00:00', NULL, 0),
('EMP17', '馬十九', '廚師', 'A', 'password17', '0912345670', '新北市淡水區97號', 'employee17@example.com', '2023-03-30 00:00:00', '2024-02-28 00:00:00', 0),
('EMP18', '趙二十', '服務員', 'B', 'password18', '0923456781', '地址18', 'employee18@example.com', '2023-04-21 00:00:00', NULL, 0),
('EMP19', '白二十一', '經理', 'A', 'password19', '0934567892', '地址19', 'employee19@example.com', '2022-10-15 00:00:00', '2024-09-15 00:00:00', 0),
('EMP20', '藍二十二', '清潔員', 'C', 'password20', '0945678903', '地址20', 'employee20@example.com', '2023-02-12 00:00:00', NULL, 0);

INSERT INTO dStock (ProductID, StockQuantity, sStatus)
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

	INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount ,IsDeleted)
VALUES
-- 王小明是 VIP，訂單總額 (800*2 + 750 = 2350)，打 95 折後總額為 2232.5
('2024092801', 'MEM00001', '2024-09-28', '已完成', NULL, 'A01', 2350, 2232.5,0),

-- 李小華是普通會員，訂單總額 (850*1 + 500*3 = 2350)，無折扣
('2024100402', 'MEM00002', '2024-10-04', '已完成', NULL, 'B02', 2350, 2350,0),

-- 周志強是 VIP，訂單總額 (800*2 + 1200 = 2800)，打 95 折後總額為 2660
('2024101903', 'MEM00007', '2024-10-19', '已完成', NULL, 'C03', 2800, 2660,0),

-- 彭子瑜是普通會員，訂單總額 (250*2 + 150 = 650)，無折扣
('2024101904', 'MEM00010', '2024-10-19', '已完成', NULL, 'D04', 650, 650,0),

-- 鄭家欣是普通會員，訂單總額 (600*1 + 500*2 = 1600)，無折扣
('2024101905', 'MEM00017', '2024-10-19', '已完成', NULL, 'E05', 1600, 1600,0);


INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
('2024092801', 'P00001', 2, 800.00),  -- 牛紐約客單價 800.00，數量 2
('2024092801', 'P00002', 1, 750.00),  -- 莎朗牛排單價 750.00，數量 1
('2024100402', 'P00004', 1, 850.00),  -- 牛肋眼單價 850.00，數量 1
('2024100402', 'P00006', 3, 500.00),  -- 豬五花肉單價 500.00，數量 3
('2024101903', 'P00010', 2, 800.00),  -- 大海蝦單價 800.00，數量 2
('2024101903', 'P00012', 1, 1200.00), -- 生鮮扇貝單價 1200.00，數量 1
('2024101904', 'P00014', 2, 250.00),  -- 雞胸肉單價 250.00，數量 2
('2024101904', 'P00020', 1, 150.00),  -- 酸奶單價 150.00，數量 1
('2024101905', 'P00025', 1, 600.00),  -- 小羔羊單價 600.00，數量 1
('2024101905', 'P00029', 2, 500.00);  -- 生鮮雞肝單價 500.00，數量 2

-- 陳大文是普通會員，訂單總額 (700*1 + 300*2 = 1300)，無折扣
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102106', 'MEM00003', '2024-10-21', '已完成', NULL, 'F06', 1300, 1300, 0);

-- 許志明是普通會員，訂單總額 (500*3 + 850 = 2350)，無折扣
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102107', 'MEM00005', '2024-10-21', '已完成', NULL, 'G07', 2350, 2350, 0);

-- 劉靜怡是普通會員，訂單總額 (800*2 + 500 = 2100)，無折扣
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102208', 'MEM00006', '2024-10-22', '已完成', NULL, 'H08', 2100, 2100, 0);

-- 鄭文彬是 VIP，訂單總額 (1000*2 + 150 = 2150)，打 95 折後總額為 2042.5
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102309', 'MEM00008', '2024-10-23', '已完成', NULL, 'I09', 2150, 2042.5, 0);

-- 張天宇是 VIP，訂單總額 (1200*1 + 600*1 + 220 = 2020)，打 95 折後總額為 1919
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102310', 'MEM00004', '2024-10-23', '已完成', NULL, 'J10', 2020, 1919, 0);


-- 訂單 2024102106 明細
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102106', 'P00003', 1, 700.00),  -- 牛小排單價 700.00，數量 1
('2024102106', 'P00013', 2, 300.00);  -- 雞腿肉單價 300.00，數量 2

-- 訂單 2024102107 明細
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102107', 'P00006', 3, 500.00),  -- 豬五花肉單價 500.00，數量 3
('2024102107', 'P00004', 1, 850.00);  -- 牛肋眼單價 850.00，數量 1

-- 訂單 2024102208 明細
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102208', 'P00010', 2, 800.00),  -- 大海蝦單價 800.00，數量 2
('2024102208', 'P00006', 1, 500.00);  -- 豬五花肉單價 500.00，數量 1

-- 訂單 2024102309 明細
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102309', 'P00011', 2, 1000.00), -- 生鮮鮭魚單價 1000.00，數量 2
('2024102309', 'P00020', 1, 150.00);  -- 酸奶單價 150.00，數量 1

-- 訂單 2024102310 明細
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102310', 'P00012', 1, 1200.00), -- 生鮮扇貝單價 1200.00，數量 1
('2024102310', 'P00025', 1, 600.00),  -- 小羔羊單價 600.00，數量 1
('2024102310', 'P00024', 1, 220.00);  -- 水果沙拉單價 220.00，數量 1
ALTER TABLE dOrders
ADD IsDeleted BIT NOT NULL DEFAULT 0;

SELECT * FROM dProduct 

select * from dEmployees;
select * from dMember;
select * from dOrderDetails;
select * from dOrders;
select * from dProduct;
select * from dStock;

