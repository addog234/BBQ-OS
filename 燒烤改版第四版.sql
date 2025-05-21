USE BBQ10;
-- ���O��ƪ� (Category)
CREATE TABLE dCategory (
    CategoryID NVARCHAR(20) PRIMARY KEY NOT NULL,  -- ���O�s��
    CategoryName NVARCHAR(50) NOT NULL              -- ���O�W��
);

-- ���~��ƪ� (Product)
CREATE TABLE dProduct (
    ProductID NVARCHAR(20) PRIMARY KEY NOT NULL,    -- ���~�s�� (�D��A���i�ŭ�)
    ProductName NVARCHAR(100) NOT NULL,             -- ���~�W��
    CategoryID NVARCHAR(20) NOT NULL,               -- ���O�s�� (�~����)
    UnitPrice INT NOT NULL,                          -- ��� (��ơA���i�ŭ�)
    Cost INT NOT NULL,                               -- ���� (��ơA���i�ŭ�)
    PStatus NVARCHAR(10) NOT NULL,                  -- ���A (���i�ŭȡA���`/�U�[/�L�w�s)
	PImage NVARCHAR(100) NULL,                       -- ���~�Ϥ�
	 IsDeleted BIT DEFAULT 0,

    -- �~�������
    CONSTRAINT FK_Product_Category FOREIGN KEY (CategoryID) REFERENCES dCategory(CategoryID)
);

-- �w�s��ƪ� (Stock)
CREATE TABLE dStock (
    ProductID NVARCHAR(20) PRIMARY KEY,              -- �ӫ~�s�� (�D��A�B�@���~����)
    StockQuantity INT NOT NULL,                       -- �w�s�ƶq (���i�ŭ�)
    sStatus NVARCHAR(10) NOT NULL,                    -- ���A (���i�ŭȡA���`/�L�w�s��)
    
    CONSTRAINT FK_Product_Stock FOREIGN KEY (ProductID) REFERENCES dProduct(ProductID)
);

-- ���u��ƪ� (Employees)
CREATE TABLE dEmployees (
    EmployeeID NVARCHAR(8) PRIMARY KEY NOT NULL,     -- ���u�s�� (�D��)
    EmpName NVARCHAR(30) NOT NULL,                       -- �m�W
    Position NVARCHAR(20),                            -- ¾��
    Permission NVARCHAR(1),                           -- �v�� (A, B, C)
    EmpPassword NVARCHAR(16) NOT NULL,                  -- �K�X�]�u��]�t�^��M�Ʀr�^
    EmpPhone NVARCHAR(20),                               -- �q��
    EmpAddress NVARCHAR(100),                            -- ��}
    EmpEmail NVARCHAR(50),                               -- EMAIL
    HireDate DATETIME NOT NULL,                       -- ��¾���
    ResignDate DATETIME NULL, -- ��¾��� (�i��NULL)
	IsDeleted BIT DEFAULT 0 
);

-- �|����ƪ� (Member)
CREATE TABLE dMember (
    MemberID NVARCHAR(20) PRIMARY KEY NOT NULL,        -- �|���s�� (�D��A����)
    MemName NVARCHAR(50) NOT NULL,                      -- �m�W (����)
    MemPassword NVARCHAR(50) NOT NULL,                 -- �K�X (����A�s�W)
    MemPhone NVARCHAR(20) NULL,                         -- �q�� (�i���ŭ�)
    MemAddress NVARCHAR(100) NULL,                      -- ��} (�i���ŭ�)
    MemEmail NVARCHAR(100) NULL,                        -- EMAIL (�i���ŭ�)
    Points INT NULL,                                    -- �I�� (�i���ŭ�)
    MemBirthdate DATETIME NULL,                         -- �ͤ� (�i���ŭ�)
    MStatus NVARCHAR(10) NULL,                          -- ���A (�i���ŭȡAVIP�ζ¦W��)
    IsDeleted BIT DEFAULT 0                             -- �O�_�w�R�� (�޿�R���A�w�]�� 0 ��ܥ��R��)
);

-- �q���ƪ� (Orders)
CREATE TABLE dOrders (
    OrderID NVARCHAR(20) PRIMARY KEY NOT NULL,       -- �q��s�� (�D��)
    MemberID NVARCHAR(20) NULL,                      -- �|���s�� (�i�šA����D�|���q��)
    OrderDate DateTime NOT NULL,                         -- �q����
    OStatus NVARCHAR(10) NOT NULL,                   -- �q�檬�A (�i�Ҽ{�ϥ� ENUM �Ϊ��A�ѷӪ�)
    EmployeeID NVARCHAR(8) NULL,                     -- �س�H (�~����A���V���u��)
	TableNumber NVARCHAR(10) NULL,                   -- �ู (�s�W���A���\�ŭ�)
    TotalPriceBeforeDiscount INT NOT NULL DEFAULT 0, -- �馩�e���`��
    TotalPriceAfterDiscount INT NOT NULL DEFAULT 0,  -- �馩�᪺�`��
	IsDeleted BIT DEFAULT 0                             -- �O�_�w�R�� (�޿�R���A�w�]�� 0 ��ܥ��R��)

    -- �~�������
    CONSTRAINT FK_Order_Member FOREIGN KEY (MemberID) REFERENCES dMember(MemberID),
    CONSTRAINT FK_Order_Employee FOREIGN KEY (EmployeeID) REFERENCES dEmployees(EmployeeID)
);

-- �q����Ӫ� (OrderDetails)
CREATE TABLE dOrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,     -- �۰ʻ��W�D��
    OrderID NVARCHAR(20) NOT NULL,                   -- �q��s�� (�~����A�Ӧۭq���)
    ProductID NVARCHAR(20) NOT NULL,                 -- ���~�s�� (�~����A�Ӧ۲��~��)
    Quantity INT NOT NULL,                            -- ���~�ƶq
    UnitPrice INT NOT NULL,                           -- ��� (��ơA���i�ŭ�)
    
    -- �~�������
    CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES dOrders(OrderID),
    CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES dProduct(ProductID)
);

INSERT INTO dCategory (CategoryID, CategoryName) VALUES
    ('C0001', '����'),
    ('C0002', '�ަ�'),
    ('C0003', '�Ϧ�'),
    ('C0004', '���A'),
    ('C0005', '����'),
    ('C0006', '����'),
    ('C0007', '���I');

INSERT INTO dProduct (ProductID, ProductName, CategoryID, UnitPrice, Cost, PStatus, PImage, IsDeleted)
VALUES 
    ('P00001', '�ì���', 'C0001', 800, 400, '���`', '1.jpg', 0),
    ('P00002', '��Ԥ���', 'C0001', 750, 350, '���`', '2.jpg', 0),
    ('P00003', '���p��', 'C0001', 700, 300, '���`', '3.jpg', 0),
    ('P00004', '���ز�', 'C0001', 850, 450, '���`', '4.jpg', 0),
    ('P00005', '�¦w�洵����', 'C0001', 900, 500, '���`', '5.jpg', 0),
    ('P00006', '�ޤ����', 'C0002', 500, 250, '���`', '6.jpg', 0),
    ('P00007', '�ޤp��', 'C0002', 550, 280, '���`', '7.jpg', 0),
    ('P00008', '�ϱ�', 'C0003', 850, 400, '���`', '8.jpg', 0),
    ('P00009', '�æ����ϻL', 'C0003', 800, 380, '���`', '9.jpg', 0),
    ('P00010', '�j����', 'C0004', 800, 400, '���`', '10.jpg', 0),
    ('P00011', '���A�D��', 'C0004', 1000, 600, '���`', '11.jpg', 0),
    ('P00012', '���A����', 'C0004', 1200, 700, '���`', '12.jpg', 0),
    ('P00013', '���L��', 'C0005', 300, 150, '���`', '13.jpg', 0),
    ('P00014', '���ݦ�', 'C0005', 250, 120, '���`', '14.jpg', 0),
    ('P00015', '�A�^�G��', 'C0006', 100, 50, '���`', '15.jpg', 0),
    ('P00016', '��w��', 'C0006', 60, 30, '���`', '16.jpg', 0),
    ('P00017', '�һĶ���', 'C0006', 50, 25, '���`', '17.jpg', 0),
    ('P00018', '�~�ˤ�', 'C0006', 30, 15, '���`', '18.jpg', 0),
    ('P00019', '����', 'C0006', 70, 35, '���`', '19.jpg', 0),
    ('P00020', '�ĥ�', 'C0007', 150, 70, '���`', '20.jpg', 0),
    ('P00021', '�~�G���B', 'C0007', 120, 60, '���`', '21.jpg', 0),
    ('P00022', '���J�O', 'C0007', 180, 90, '���`', '22.jpg', 0),
    ('P00023', '���T', 'C0007', 200, 100, '���`', '23.jpg', 0),
    ('P00024', '���G�F��', 'C0007', 220, 115, '���`', '24.jpg', 0),
    ('P00025', '�p�̦�', 'C0003', 600, 300, '���`', '25.jpg', 0),
    ('P00026', '��������', 'C0001', 600, 280, '���`', '26.jpg', 0),
    ('P00027', '�e������', 'C0005', 300, 150, '���`', '27.jpg', 0),
    ('P00028', '���A�p�Ϫ�', 'C0003', 900, 450, '���`', '28.jpg', 0),
    ('P00029', '���A���x', 'C0005', 500, 250, '���`', '29.jpg', 0),
    ('P00030', '���꽼', 'C0004', 400, 200, '���`', '30.jpg', 0);

	INSERT INTO dMember (MemberID, MemName,MemPassword, MemPhone, MemAddress, MemEmail, Points, MemBirthdate, MStatus, IsDeleted) VALUES
('MEM00001', '���p��', 'password123', '0912345678', '�x�_���_���1��', 'member1@example.com', 150, '1995-06-22', 'VIP', 0),
('MEM00002', '���p��', 'password123', '0923456789', '�x�_���j�w��2��', 'member2@example.com', 30, '1990-01-15', '���q', 0),
('MEM00003', '���j��', 'password123', '0934567890', '�x�_�������3��', 'member3@example.com', 80, '1987-05-30', '���q', 0),
('MEM00004', '�i�Ѧt', 'password123', '0945678901', '�s�_���O����4��', 'member4@example.com', 200, '1986-11-05', 'VIP', 0),
('MEM00005', '�\�ө�', 'password123', '0956789012', '�s�_���O����5��', 'member5@example.com', 60, '1980-07-19', '���q', 0),
('MEM00006', '�B�R��', 'password123', '0967890123', '�x�_���H�q��6��', 'member6@example.com', 25, '1992-03-24', '���q', 0),
('MEM00007', '�P�ӱj', 'password123', '0978901234', '�x�_���H�q��7��', 'member7@example.com', 300, '1985-08-12', 'VIP', 0),
('MEM00008', '�G��l', 'password123', '0989012345', '��������s��8��', 'member8@example.com', 110, '1991-12-09', 'VIP', 0),
('MEM00009', '���p�g', 'password123', '0912345679', '��������s��9��', 'member9@example.com', 75, '1983-01-17', '���q', 0),
('MEM00010', '�^�l��', 'password123', '0923456790', '�����������10��', 'member10@example.com', 45, '1996-06-30', '���q', 0),
('MEM00011', '���a��', 'password123', '0934567901', '�x�������s��11��', 'member11@example.com', 150, '1984-02-11', 'VIP', 0),
('MEM00012', '���a��', 'password123', '0945679012', '�x�������s��12��', 'member12@example.com', 5, '1993-10-20', '���q', 0),
('MEM00013', '�d�亽', 'password123', '0956789123', '�������Z�L��13��', 'member13@example.com', 60, '1986-09-13', '���q', 0),
('MEM00014', '����', 'password123', '0967890234', '���������t��14��', 'member14@example.com', 100, '1990-03-02', '���q', 0),
('MEM00015', '��ç�', 'password123', '0978901345', '�������ҥP��15��', 'member15@example.com', 20, '1988-04-30', '���q', 0),
('MEM00016', '�}���@', 'password123', '0989012456', '�x�_���h�L��16��', 'member16@example.com', 90, '1994-12-11', '���q', 0),
('MEM00017', '�G�a�Y', 'password123', '0912345670', '�x�_���h�L��17��', 'member17@example.com', 66, '1981-05-19', '���q', 0),
('MEM00018', '�d���m', 'password123', '0923456781', '�x�_���j�P��18��', 'member18@example.com', 10, '1995-08-29', '���q', 0),
('MEM00019', '������', 'password123', '0934567892', '�x�_�����s��19��', 'member19@example.com', 200, '1989-07-07', 'VIP', 0),
('MEM00020', '��ӱj', 'password123', '0945678903', '�x�_�����s��20��', 'member20@example.com', 50, '1992-06-15', '���q', 0),
('MEM00021', '�L�a��', 'password123', '0912345789', '�x�_���U�ذ�21��', 'member21@example.com', 90, '1988-11-20', '���q', 0),
('MEM00022', '�G����', 'password123', '0923456780', '�x�_���H�q��22��', 'member22@example.com', 300, '1985-09-02', 'VIP', 0),
('MEM00023', '�J�F��', 'password123', '0934567891', '�x�_���j�w��23��', 'member23@example.com', 120, '1991-02-05', 'VIP', 0),
('MEM00024', '����w', 'password123', '0945678902', '�s�_�����M��24��', 'member24@example.com', 70, '1994-05-08', '���q', 0),
('MEM00025', '������', 'password123', '0956789013', '�s�_�����M��25��', 'member25@example.com', 45, '1993-06-15', '���q', 0),
('MEM00026', '���a��', 'password123', '0967890124', '�s�_���H����26��', 'member26@example.com', 22, '1992-07-29', '���q', 0),
('MEM00027', '�����p', 'password123', '0978901235', '�s�_���H����27��', 'member27@example.com', 100, '1991-03-18', '���q', 0),
('MEM00028', '���p�@', 'password123', '0989012346', '�s�_���s����28��', 'member28@example.com', 89, '1990-01-04', '���q', 0),
('MEM00029', '�B�ة�', 'password123', '0912345678', '�s�_���s����29��', 'member29@example.com', 120, '1989-09-25', 'VIP', 0),
('MEM00030', '���t��', 'password123', '0923456789', '�s�_���s����30��', 'member30@example.com', 60, '1993-04-22', '���q', 0),
('MEM00031', '�d�ֱ�', 'password123', '0934567890', '�s�_���g����31��', 'member31@example.com', 105, '1985-10-12', 'VIP', 0),
('MEM00032', '�P����', 'password123', '0945678901', '�s�_���g����32��', 'member32@example.com', 15, '1996-06-28', '���q', 0),
('MEM00033', '�G�ӻ�', 'password123', '0956789012', '�s�_����L��33��', 'member33@example.com', 80, '1988-12-17', '���q', 0),
('MEM00034', '��ذ�', 'password123', '0967890123', '�x��������34��', 'member34@example.com', 40, '1994-01-22', '���q', 0),
('MEM00035', '�B�l��', 'password123', '0978901234', '�x��������35��', 'member35@example.com', 200, '1987-05-03', 'VIP', 0),
('MEM00036', '�i�Q��', 'password123', '0989012345', '�x�����j�w36��', 'member36@example.com', 70, '1981-03-13', '���q', 0),
('MEM00037', '��䧱', 'password123', '0912345676', '�x�_��������37��', 'member37@example.com', 22, '1993-04-14', '���q', 0),
('MEM00038', '��õ�', 'password123', '0923456787', '�x�_��������38��', 'member38@example.com', 50, '1990-06-19', '���q', 0),
('MEM00039', '�L���@', 'password123', '0934567898', '�x�_��������39��', 'member39@example.com', 75, '1992-09-09', '���q', 0),
('MEM00040', '���i�t', 'password123', '0945678909', '�x�_��������40��', 'member40@example.com', 35, '1989-01-11', '���q', 0);

INSERT INTO dEmployees (EmployeeID, EmpName, Position, Permission, EmpPassword, EmpPhone, EmpAddress, EmpEmail, HireDate, ResignDate, IsDeleted) VALUES
('EMP01', '�X����', '�g�z', 'A', 'password1', '0912345678', '�x�_���_��Ϥ��]��100��', 'employee1@example.com', '2023-06-15 00:00:00', NULL, 0),
('EMP02', '���|', '�A�ȭ�', 'B', 'password2', '0923456789', '�x�_�����s��98��', 'employee2@example.com', '2023-04-12 00:00:00', '2024-04-12 00:00:00', 0),
('EMP03', '����', '�g�z', 'A', 'password3', '0934567890', '�x�_���Q�s��97��', 'employee3@example.com', '2023-01-30 00:00:00', NULL, 0),
('EMP04', '����', '�M���', 'C', 'password4', '0945678901', '�x�_��������48��', 'employee4@example.com', '2022-12-25 00:00:00', NULL, 0),
('EMP05', '�]�C', '�p�v', 'B', 'password5', '0956789012', '�x�_��������89��', 'employee5@example.com', '2023-08-10 00:00:00', '2024-07-10 00:00:00', 0),
('EMP06', '�P�K', '�A�ȭ�', 'B', 'password6', '0967890123', '�x�_���H�q��70��', 'employee6@example.com', '2023-03-11 00:00:00', NULL, 0),
('EMP07', '�d�E', '�g�z', 'A', 'password7', '0978901234', '�x�_�����s��33��', 'employee7@example.com', '2023-05-20 00:00:00', NULL, 0),
('EMP08', '�G�Q', '�M���', 'C', 'password8', '0989012345', '�x�_���j�w109��', 'employee8@example.com', '2022-11-17 00:00:00', NULL, 0),
('EMP09', '��Q�@', '�p�v', 'A', 'password9', '0912345679', '�x�_����s��40��', 'employee9@example.com', '2023-07-09 00:00:00', '2024-05-09 00:00:00', 0),
('EMP10', '�L�Q�G', '�A�ȭ�', 'B', 'password10', '0923456790', '�x�_���_��Ϥ��]��99��', 'employee10@example.com', '2023-09-18 00:00:00', NULL, 0),
('EMP11', '���Q�T', '�g�z', 'A', 'password11', '0934567901', '�s�_���H����777��', 'employee11@example.com', '2023-02-22 00:00:00', NULL, 0),
('EMP12', '�¤Q�|', '�M���', 'C', 'password12', '0945679012', '�s�_���H����201��', 'employee12@example.com', '2023-04-30 00:00:00', '2024-03-30 00:00:00', 0),
('EMP13', '�^�Q��', '�p�v', 'B', 'password13', '0956789123', '�s�_���g����27��', 'employee13@example.com', '2023-01-01 00:00:00', NULL, 0),
('EMP14', '���Q��', '�A�ȭ�', 'B', 'password14', '0967890234', '�s�_���s����77��', 'employee14@example.com', '2022-09-10 00:00:00', '2024-08-10 00:00:00', 0),
('EMP15', '���Q�C', '�g�z', 'A', 'password15', '0978901345', '�s�_���T����27��', 'employee15@example.com', '2023-06-01 00:00:00', NULL, 0),
('EMP16', '�}�Q�K', '�M���', 'C', 'password16', '0989012456', '�s�_���T�l��40��', 'employee16@example.com', '2022-08-20 00:00:00', NULL, 0),
('EMP17', '���Q�E', '�p�v', 'A', 'password17', '0912345670', '�s�_���H����97��', 'employee17@example.com', '2023-03-30 00:00:00', '2024-02-28 00:00:00', 0),
('EMP18', '���G�Q', '�A�ȭ�', 'B', 'password18', '0923456781', '�a�}18', 'employee18@example.com', '2023-04-21 00:00:00', NULL, 0),
('EMP19', '�դG�Q�@', '�g�z', 'A', 'password19', '0934567892', '�a�}19', 'employee19@example.com', '2022-10-15 00:00:00', '2024-09-15 00:00:00', 0),
('EMP20', '�ŤG�Q�G', '�M���', 'C', 'password20', '0945678903', '�a�}20', 'employee20@example.com', '2023-02-12 00:00:00', NULL, 0);

INSERT INTO dStock (ProductID, StockQuantity, sStatus)
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

	INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount ,IsDeleted)
VALUES
-- ���p���O VIP�A�q���`�B (800*2 + 750 = 2350)�A�� 95 ����`�B�� 2232.5
('2024092801', 'MEM00001', '2024-09-28', '�w����', NULL, 'A01', 2350, 2232.5,0),

-- ���p�جO���q�|���A�q���`�B (850*1 + 500*3 = 2350)�A�L�馩
('2024100402', 'MEM00002', '2024-10-04', '�w����', NULL, 'B02', 2350, 2350,0),

-- �P�ӱj�O VIP�A�q���`�B (800*2 + 1200 = 2800)�A�� 95 ����`�B�� 2660
('2024101903', 'MEM00007', '2024-10-19', '�w����', NULL, 'C03', 2800, 2660,0),

-- �^�l��O���q�|���A�q���`�B (250*2 + 150 = 650)�A�L�馩
('2024101904', 'MEM00010', '2024-10-19', '�w����', NULL, 'D04', 650, 650,0),

-- �G�a�Y�O���q�|���A�q���`�B (600*1 + 500*2 = 1600)�A�L�馩
('2024101905', 'MEM00017', '2024-10-19', '�w����', NULL, 'E05', 1600, 1600,0);


INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES
('2024092801', 'P00001', 2, 800.00),  -- ���ì��ȳ�� 800.00�A�ƶq 2
('2024092801', 'P00002', 1, 750.00),  -- ��Ԥ��Ƴ�� 750.00�A�ƶq 1
('2024100402', 'P00004', 1, 850.00),  -- ���ز���� 850.00�A�ƶq 1
('2024100402', 'P00006', 3, 500.00),  -- �ޤ���׳�� 500.00�A�ƶq 3
('2024101903', 'P00010', 2, 800.00),  -- �j������� 800.00�A�ƶq 2
('2024101903', 'P00012', 1, 1200.00), -- ���A������� 1200.00�A�ƶq 1
('2024101904', 'P00014', 2, 250.00),  -- ���ݦ׳�� 250.00�A�ƶq 2
('2024101904', 'P00020', 1, 150.00),  -- �ĥ���� 150.00�A�ƶq 1
('2024101905', 'P00025', 1, 600.00),  -- �p�̦ϳ�� 600.00�A�ƶq 1
('2024101905', 'P00029', 2, 500.00);  -- ���A���x��� 500.00�A�ƶq 2

-- ���j��O���q�|���A�q���`�B (700*1 + 300*2 = 1300)�A�L�馩
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102106', 'MEM00003', '2024-10-21', '�w����', NULL, 'F06', 1300, 1300, 0);

-- �\�ө��O���q�|���A�q���`�B (500*3 + 850 = 2350)�A�L�馩
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102107', 'MEM00005', '2024-10-21', '�w����', NULL, 'G07', 2350, 2350, 0);

-- �B�R�ɬO���q�|���A�q���`�B (800*2 + 500 = 2100)�A�L�馩
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102208', 'MEM00006', '2024-10-22', '�w����', NULL, 'H08', 2100, 2100, 0);

-- �G��l�O VIP�A�q���`�B (1000*2 + 150 = 2150)�A�� 95 ����`�B�� 2042.5
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102309', 'MEM00008', '2024-10-23', '�w����', NULL, 'I09', 2150, 2042.5, 0);

-- �i�Ѧt�O VIP�A�q���`�B (1200*1 + 600*1 + 220 = 2020)�A�� 95 ����`�B�� 1919
INSERT INTO dOrders (OrderID, MemberID, OrderDate, OStatus, EmployeeID, TableNumber, TotalPriceBeforeDiscount, TotalPriceAfterDiscount, IsDeleted)
VALUES ('2024102310', 'MEM00004', '2024-10-23', '�w����', NULL, 'J10', 2020, 1919, 0);


-- �q�� 2024102106 ����
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102106', 'P00003', 1, 700.00),  -- ���p�Ƴ�� 700.00�A�ƶq 1
('2024102106', 'P00013', 2, 300.00);  -- ���L�׳�� 300.00�A�ƶq 2

-- �q�� 2024102107 ����
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102107', 'P00006', 3, 500.00),  -- �ޤ���׳�� 500.00�A�ƶq 3
('2024102107', 'P00004', 1, 850.00);  -- ���ز���� 850.00�A�ƶq 1

-- �q�� 2024102208 ����
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102208', 'P00010', 2, 800.00),  -- �j������� 800.00�A�ƶq 2
('2024102208', 'P00006', 1, 500.00);  -- �ޤ���׳�� 500.00�A�ƶq 1

-- �q�� 2024102309 ����
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102309', 'P00011', 2, 1000.00), -- ���A�D����� 1000.00�A�ƶq 2
('2024102309', 'P00020', 1, 150.00);  -- �ĥ���� 150.00�A�ƶq 1

-- �q�� 2024102310 ����
INSERT INTO dOrderDetails (OrderID, ProductID, Quantity, UnitPrice)
VALUES 
('2024102310', 'P00012', 1, 1200.00), -- ���A������� 1200.00�A�ƶq 1
('2024102310', 'P00025', 1, 600.00),  -- �p�̦ϳ�� 600.00�A�ƶq 1
('2024102310', 'P00024', 1, 220.00);  -- ���G�F�Գ�� 220.00�A�ƶq 1
ALTER TABLE dOrders
ADD IsDeleted BIT NOT NULL DEFAULT 0;

SELECT * FROM dProduct 

select * from dEmployees;
select * from dMember;
select * from dOrderDetails;
select * from dOrders;
select * from dProduct;
select * from dStock;

