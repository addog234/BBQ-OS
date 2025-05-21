USE BBQ;
CREATE TABLE Employees (
    ManagerID NVARCHAR(8) PRIMARY KEY,  -- �޲z�̽s���A8�X�A�D��
    Name NVARCHAR(30) NOT NULL,         -- �m�W
    Position NVARCHAR(20),              -- ¾��
    Permission NVARCHAR(1),             -- �v�� (A, B, C)
    Password NVARCHAR(16) NOT NULL,     -- �K�X�]�u��]�t�^��M�Ʀr�^
    Phone NVARCHAR(20),                 -- �q��
    Address NVARCHAR(100),              -- ��}
    Email NVARCHAR(50),                 -- EMAIL
    HireDate DATETIME NOT NULL,         -- ��¾���
    ResignDate DATETIME                 -- ��¾��� (�i��NULL)
);

-- �|����ƪ� (Member)
CREATE TABLE Member (
    MemberID NVARCHAR(20) PRIMARY KEY,   -- �|���s�� (�D��A����)
    Name NVARCHAR(50) NOT NULL,          -- �m�W (����)
    Phone NVARCHAR(20) NULL,             -- �q�� (�i���ŭ�)
    Address NVARCHAR(100) NULL,          -- ��} (�i���ŭ�)
    Email NVARCHAR(100) NULL,            -- EMAIL (�i���ŭ�)
    Points INT NULL,                     -- �I�� (�i���ŭ�)
    Birthdate DATE NULL,                 -- �ͤ� (�i���ŭ�)
    Status NVARCHAR(10) NULL             -- ���A (�i���ŭȡAVIP�ζ¦W��)
);

-- ���~��ƪ� (Product)
CREATE TABLE Product (
    ProductID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- ���~�s�� (�D��A���i�ŭ�)
	 ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,               -- ���~���O (���i�ŭ�)
    UnitPrice DECIMAL(10, 0) NOT NULL,            -- ��� (���i�ŭ�)
    Cost DECIMAL(10, 0) NOT NULL,                 -- ���� (���i�ŭ�)
    Status NVARCHAR(10) NOT NULL                  -- ���A (���i�ŭȡA���`/�U�[/�L�w�s)
);

-- �w�s��ƪ� (Stock)
CREATE TABLE Stock (
    ProductID NVARCHAR(20) PRIMARY KEY,           -- �ӫ~�s�� (�D��A�B�@���~����)
    StockQuantity INT NOT NULL,                   -- �w�s�ƶq (���i�ŭ�)
    Status NVARCHAR(10) NOT NULL,                 -- ���A (���i�ŭȡA���`/�L�w�s��)
    
    CONSTRAINT FK_Product_Stock FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- �q���ƪ� (Orders)
CREATE TABLE Orders (
    OrderID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- �q��s�� (�D��)
    MemberID NVARCHAR(20) NOT NULL,             -- �|���s�� (�~����)
    OrderDate DATE NOT NULL,                    -- �q���� (���i��)
    Status NVARCHAR(10) NOT NULL,               -- �q�檬�A (���i��)
    EmployeeID NVARCHAR(8) NULL,                -- �س�H (���u�s���A�i��)
	TotalPriceBeforeDiscount DECIMAL(10, 0) NOT NULL DEFAULT 0,  -- �馩�e���`��
    TotalPriceAfterDiscount DECIMAL(10, 0) NOT NULL DEFAULT 0, -- �馩�᪺�`��

    -- �~�������
    CONSTRAINT FK_Order_Member FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
    CONSTRAINT FK_Order_Employee FOREIGN KEY (EmployeeID) REFERENCES Employees(ManagerID)
);

-- �q����Ӫ� (OrderDetails)
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1) , -- �q����ӽs���A�۰ʻ��W�@���D��
    OrderID NVARCHAR(20) NOT NULL,               -- �q��s�� (�~����A�Ӧۭq���)
    ProductID NVARCHAR(20) NOT NULL,             -- ���~�s�� (�~����A�Ӧ۲��~��)
    Quantity INT NOT NULL,                       -- ���~�ƶq (���i�ŭ�)
    UnitPrice DECIMAL(10, 0) NOT NULL,           -- ��� (���i�ŭ�)


    -- �~�������
    CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
	);
	select * from Orders;
	INSERT INTO Product (ProductID, ProductName, Category, UnitPrice, Cost, Status)
VALUES 
    ('P00001', '�ì���', '����', 800, 400, '���`'),
    ('P00002', '��Ԥ���', '����', 750, 350, '���`'),
    ('P00003', '���p��', '����', 700, 300, '���`'),
    ('P00004', '���ز�', '����', 850, 450, '���`'),
    ('P00005', '�¦w�洵����', '����', 900, 500, '���`'),
    ('P00006', '�ޤ����', '�ަ�', 500, 250, '���`'),
    ('P00007', '�ޤp��', '�ަ�', 550, 280, '���`'),
    ('P00008', '�ϱ�', '�Ϧ�', 850, 400, '���`'),
    ('P00009', '�æ����ϻL', '�Ϧ�', 800, 380, '���`'),
    ('P00010', '�j����', '���A', 800, 400, '���`'),
    ('P00011', '���A�D��', '���A', 1000, 600, '���`'),
    ('P00012', '���A����', '���A', 1200, 700, '���`'),
    ('P00013', '���L��', '����', 300, 150, '���`'),
    ('P00014', '���ݦ�', '����', 250, 120, '���`'),
    
    ('P00015', '�A�^�G��', '����', 100, 50, '���`'),
    ('P00016', '��w��', '����', 60, 30, '���`'),
    ('P00017', '�һĶ���', '����', 50, 25, '���`'),
    ('P00018', '�~�ˤ�', '����', 30, 15, '���`'),
    ('P00019', '����', '����', 70, 35, '���`'),

    ('P00020', '�ĥ�', '���I', 150, 70, '���`'),
    ('P00021', '�~�G���B', '���I', 120, 60, '���`'),
    ('P00022', '���J�O', '���I', 180, 90, '���`'),
    ('P00023', '���T', '���I', 200, 100, '���`'),
    ('P00024', '���G�F��', '���I', 220, 115, '���`'),

    ('P00025', '�p�̦�', '�Ϧ�', 600, 300, '���`'),
    ('P00026', '��������', '����', 600, 280, '���`'),
    ('P00027', '�e������', '����', 300, 150, '���`'),
    ('P00028', '���A�p�Ϫ�', '�Ϧ�', 900, 450, '���`'),
    ('P00029', '���A���x', '����', 500, 250, '���`'),

    ('P00030', '���꽼', '���A', 400, 200, '���`');

	INSERT INTO Stock (ProductID, StockQuantity, Status)
VALUES 
    ('P00001', 150, '���`'),
    ('P00002', 100, '���`'),
    ('P00003', 80, '���`'),
    ('P00004', 200, '���`'),
    ('P00005', 120, '���`'),
    ('P00006', 170, '���`'),
    ('P00007', 90, '���`'),
    ('P00008', 160, '���`'),
    ('P00009', 110, '���`'),
    ('P00010', 200, '���`'),
    ('P00011', 150, '���`'),
    ('P00012', 130, '���`'),
    ('P00013', 100, '���`'),
    ('P00014', 80, '���`'),
    
    ('P00015', 150, '���`'),
    ('P00016', 120, '���`'),
    ('P00017', 90, '���`'),
    ('P00018', 200, '���`'),
    ('P00019', 80, '���`'),

    ('P00020', 60, '���`'),
    ('P00021', 100, '���`'),
    ('P00022', 70, '���`'),
    ('P00023', 150, '���`'),
    ('P00024', 80, '���`'),

    ('P00025', 110, '���`'),
    ('P00026', 140, '���`'),
    ('P00027', 90, '���`'),
    ('P00028', 130, '���`'),
    ('P00029', 70, '���`'),

    ('P00030', 200, '���`');
	select * from Stock;


INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
('202410180001', 'P00001', 2, 800.00),  -- ���ì��ȳ�� 800.00�A�ƶq 2
('202410180001', 'P00002', 1, 750.00),  -- ��Ԥ��Ƴ�� 750.00�A�ƶq 1
('202410180002', 'P00004', 1, 850.00),  -- ���ز���� 850.00�A�ƶq 1
('202410180002', 'P00006', 3, 500.00),  -- �ޤ���׳�� 500.00�A�ƶq 3
('202410180003', 'P00010', 2, 800.00),  -- ���A����� 800.00�A�ƶq 2
('202410180003', 'P00012', 1, 1200.00), -- ���A������� 1200.00�A�ƶq 1
('202410180004', 'P00014', 2, 250.00),  -- ���ݦ׳�� 250.00�A�ƶq 2
('202410180004', 'P00020', 1, 150.00),  -- �ĥ���� 150.00�A�ƶq 1
('202410180005', 'P00025', 1, 600.00),  -- ���A�Ϧפ���� 600.00�A�ƶq 1
('202410180005', 'P00029', 2, 500.00);  -- ���A���ͳ�� 500.00�A�ƶq 2

INSERT INTO Orders (OrderID, MemberID, OrderDate, Status, EmployeeID, TotalPriceBeforeDiscount, TotalPriceAfterDiscount)
VALUES
-- ���p���O VIP�A�q���`�B (800*2 + 750 = 2350)�A�� 95 ����`�B�� 2232.5
('202410180001', 'MEM00001', '2024-10-01', '�w����', NULL, 2350, 2232.5),

-- ���p�جO���q�|���A�q���`�B (850*1 + 500*3 = 2350)�A�L�馩
('202410180002', 'MEM00002', '2024-10-02', '�w����', NULL, 2350, 2350),

-- �P�ӱj�O VIP�A�q���`�B (800*2 + 1200 = 2800)�A�� 95 ����`�B�� 2660
('202410180003', 'MEM00007', '2024-10-03', '�w����', NULL, 2800, 2660),

-- �^�l��O���q�|���A�q���`�B (250*2 + 150 = 650)�A�L�馩
('202410180004', 'MEM00010', '2024-10-04', '�w����', NULL, 650, 650),

-- �G�a�Y�O���q�|���A�q���`�B (600*1 + 500*2 = 1600)�A�L�馩
('202410180005', 'MEM00017', '2024-10-05', '�w����', NULL, 1600, 1600);

INSERT INTO Member (MemberID, Name, Phone, Address, Email, Points, Birthdate, Status) VALUES
('MEM00001', '���p��', '0912345678', '�x�_��������1��', 'member1@example.com', 150, '1995-06-22', 'VIP'),
('MEM00002', '���p��', '0923456789', '�x�_��������2��', 'member2@example.com', 30, '1990-01-15', '���q'),
('MEM00003', '���j��', '0934567890', '�x�_��������3��', 'member3@example.com', 80, '1987-05-30', '���q'),
('MEM00004', '�i�Ѧt', '0945678901', '�x�_��������4��', 'member4@example.com', 200, '1986-11-05', 'VIP'),
('MEM00005', '�\�ө�', '0956789012', '�x�_��������5��', 'member5@example.com', 60, '1980-07-19', '���q'),
('MEM00006', '�B�R��', '0967890123', '�x�_��������6��', 'member6@example.com', 25, '1992-03-24', '���q'),
('MEM00007', '�P�ӱj', '0978901234', '�x�_��������7��', 'member7@example.com', 300, '1985-08-12', 'VIP'),
('MEM00008', '�G��l', '0989012345', '�x�_��������8��', 'member8@example.com', 110, '1991-12-09', 'VIP'),
('MEM00009', '���p�g', '0912345679', '�x�_��������9��', 'member9@example.com', 75, '1983-01-17', '���q'),
('MEM00010', '�^�l��', '0923456790', '�x�_��������10��', 'member10@example.com', 45, '1996-06-30', '���q'),
('MEM00011', '���a��', '0934567901', '�x�_��������11��', 'member11@example.com', 150, '1984-02-11', 'VIP'),
('MEM00012', '���a��', '0945679012', '�x�_��������12��', 'member12@example.com', 5, '1993-10-20', '���q'),
('MEM00013', '�d�亽', '0956789123', '�x�_��������13��', 'member13@example.com', 60, '1986-09-13', '���q'),
('MEM00014', '����', '0967890234', '�x�_��������14��', 'member14@example.com', 100, '1990-03-02', '���q'),
('MEM00015', '��ç�', '0978901345', '�x�_��������15��', 'member15@example.com', 20, '1988-04-30', '���q'),
('MEM00016', '�}���@', '0989012456', '�x�_��������16��', 'member16@example.com', 90, '1994-12-11', '���q'),
('MEM00017', '�G�a�Y', '0912345670', '�x�_��������17��', 'member17@example.com', 66, '1981-05-19', '���q'),
('MEM00018', '�d���m', '0923456781', '�x�_��������18��', 'member18@example.com', 10, '1995-08-29', '���q'),
('MEM00019', '������', '0934567892', '�x�_��������19��', 'member19@example.com', 200, '1989-07-07', 'VIP'),
('MEM00020', '��ӱj', '0945678903', '�x�_��������20��', 'member20@example.com', 50, '1992-06-15', '���q'),
('MEM00021', '�L�a��', '0912345789', '�x�_��������21��', 'member21@example.com', 90, '1988-11-20', '���q'),
('MEM00022', '�G����', '0923456780', '�x�_��������22��', 'member22@example.com', 300, '1985-09-02', 'VIP'),
('MEM00023', '�J�F��', '0934567891', '�x�_��������23��', 'member23@example.com', 120, '1991-02-05', 'VIP'),
('MEM00024', '����w', '0945678902', '�x�_��������24��', 'member24@example.com', 70, '1994-05-08', '���q'),
('MEM00025', '������', '0956789013', '�x�_��������25��', 'member25@example.com', 45, '1993-06-15', '���q'),
('MEM00026', '���a��', '0967890124', '�x�_��������26��', 'member26@example.com', 22, '1992-07-29', '���q'),
('MEM00027', '�����p', '0978901235', '�x�_��������27��', 'member27@example.com', 100, '1991-03-18', '���q'),
('MEM00028', '���p�@', '0989012346', '�x�_��������28��', 'member28@example.com', 89, '1990-01-04', '���q'),
('MEM00029', '�B�ة�', '0912345678', '�x�_��������29��', 'member29@example.com', 120, '1989-09-25', 'VIP'),
('MEM00030', '���t��', '0923456789', '�x�_��������30��', 'member30@example.com', 60, '1993-04-22', '���q'),
('MEM00031', '�d�ֱ�', '0934567890', '�x�_��������31��', 'member31@example.com', 105, '1985-10-12', 'VIP'),
('MEM00032', '�P����', '0945678901', '�x�_��������32��', 'member32@example.com', 15, '1996-06-28', '���q'),
('MEM00033', '�G�ӻ�', '0956789012', '�x�_��������33��', 'member33@example.com', 80, '1988-12-17', '���q'),
('MEM00034', '��ذ�', '0967890123', '�x�_��������34��', 'member34@example.com', 40, '1994-01-22', '���q'),
('MEM00035', '�B�l��', '0978901234', '�x�_��������35��', 'member35@example.com', 200, '1987-05-03', 'VIP'),
('MEM00036', '�i�Q��', '0989012345', '�x�_��������36��', 'member36@example.com', 70, '1981-03-13', '���q'),
('MEM00037', '��䧱', '0912345676', '�x�_��������37��', 'member37@example.com', 22, '1993-04-14', '���q'),
('MEM00038', '��õ�', '0923456787', '�x�_��������38��', 'member38@example.com', 50, '1990-06-19', '���q'),
('MEM00039', '�L���@', '0934567898', '�x�_��������39��', 'member39@example.com', 75, '1992-09-09', '���q'),
('MEM00040', '���i�t', '0945678909', '�x�_��������40��', 'member40@example.com', 35, '1989-01-11', '���q');

INSERT INTO Employees (ManagerID, Name, Position, Permission, Password, Phone, Address, Email, HireDate, ResignDate) VALUES
('EMP01', '�i�T', '�p�v', 'A', 'password1', '0912345678', '�a�}1', 'employee1@example.com', '2023-06-15 00:00:00', NULL),
('EMP02', '���|', '�A�ȭ�', 'B', 'password2', '0923456789', '�a�}2', 'employee2@example.com', '2023-04-12 00:00:00', '2024-04-12 00:00:00'),
('EMP03', '����', '�g�z', 'A', 'password3', '0934567890', '�a�}3', 'employee3@example.com', '2023-01-30 00:00:00', NULL),
('EMP04', '����', '�M���', 'C', 'password4', '0945678901', '�a�}4', 'employee4@example.com', '2022-12-25 00:00:00', NULL),
('EMP05', '�]�C', '�p�v', 'B', 'password5', '0956789012', '�a�}5', 'employee5@example.com', '2023-08-10 00:00:00', '2024-07-10 00:00:00'),
('EMP06', '�P�K', '�A�ȭ�', 'A', 'password6', '0967890123', '�a�}6', 'employee6@example.com', '2023-03-11 00:00:00', NULL),
('EMP07', '�d�E', '�g�z', 'B', 'password7', '0978901234', '�a�}7', 'employee7@example.com', '2023-05-20 00:00:00', NULL),
('EMP08', '�G�Q', '�M���', 'C', 'password8', '0989012345', '�a�}8', 'employee8@example.com', '2022-11-17 00:00:00', NULL),
('EMP09', '��Q�@', '�p�v', 'A', 'password9', '0912345679', '�a�}9', 'employee9@example.com', '2023-07-09 00:00:00', '2024-05-09 00:00:00'),
('EMP10', '�L�Q�G', '�A�ȭ�', 'B', 'password10', '0923456790', '�a�}10', 'employee10@example.com', '2023-09-18 00:00:00', NULL),
('EMP11', '���Q�T', '�g�z', 'A', 'password11', '0934567901', '�a�}11', 'employee11@example.com', '2023-02-22 00:00:00', NULL),
('EMP12', '�¤Q�|', '�M���', 'C', 'password12', '0945679012', '�a�}12', 'employee12@example.com', '2023-04-30 00:00:00', '2024-03-30 00:00:00'),
('EMP13', '�^�Q��', '�p�v', 'B', 'password13', '0956789123', '�a�}13', 'employee13@example.com', '2023-01-01 00:00:00', NULL),
('EMP14', '���Q��', '�A�ȭ�', 'A', 'password14', '0967890234', '�a�}14', 'employee14@example.com', '2022-09-10 00:00:00', '2024-08-10 00:00:00'),
('EMP15', '���Q�C', '�g�z', 'B', 'password15', '0978901345', '�a�}15', 'employee15@example.com', '2023-06-01 00:00:00', NULL),
('EMP16', '�}�Q�K', '�M���', 'C', 'password16', '0989012456', '�a�}16', 'employee16@example.com', '2022-08-20 00:00:00', NULL),
('EMP17', '���Q�E', '�p�v', 'A', 'password17', '0912345670', '�a�}17', 'employee17@example.com', '2023-03-30 00:00:00', '2024-02-28 00:00:00'),
('EMP18', '���G�Q', '�A�ȭ�', 'B', 'password18', '0923456781', '�a�}18', 'employee18@example.com', '2023-04-21 00:00:00', NULL),
('EMP19', '�դG�Q�@', '�g�z', 'A', 'password19', '0934567892', '�a�}19', 'employee19@example.com', '2022-10-15 00:00:00', '2024-09-15 00:00:00'),
('EMP20', '�ŤG�Q�G', '�M���', 'C', 'password20', '0945678903', '�a�}20', 'employee20@example.com', '2023-02-12 00:00:00', NULL);