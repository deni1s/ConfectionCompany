CREATE Table [Users]
(
 id int primary key identity(1,1) not null,
 [Login] nvarchar(255) unique not null,
 [Password] nvarchar(255) not null
);

CREATE Table [Sessions]
(
 id int primary key identity(1,1) not null,
 [UserId] int not null FOREIGN KEY REFERENCES [Users](id) ON DELETE CASCADE ON UPDATE CASCADE,
 [EnterDate] datetime not null
);

CREATE Table [Confections]
(
 id int primary key identity(1,1) not null,
 [Name] nvarchar(255) unique not null,
 [Price] decimal(18,4) not null CHECK([Price] > 0) DEFAULT 0,
 [Info] nvarchar(255) null
);

CREATE Table [Products]
(
 id int primary key identity(1,1) not null,
 [Name] nvarchar(255) unique not null,
 [Info] nvarchar(255) null
);


CREATE Table [Warehouse]
(
 id int primary key identity(1,1) not null,
 [ConfectionId] int not null unique FOREIGN KEY REFERENCES [Confections](id) ON DELETE CASCADE ON UPDATE CASCADE,
 [ConfectionCount] int not null CHECK (ConfectionCount >= 0) DEFAULT 0,
 [BestBefore] date not null
);

CREATE Table [Orders]
(
 id int primary key identity(1,1) not null,
 [ConfectionId] int not null FOREIGN KEY REFERENCES [Confections](id) ON DELETE CASCADE ON UPDATE CASCADE,
 [ConfectionCount] int not null CHECK (ConfectionCount >= 0) DEFAULT 0,
 [OrderDate] datetime not null
);

CREATE Table [ConfectionProducts]
(
 id int primary key identity(1,1) not null,
 [ConfectionId] int not null FOREIGN KEY REFERENCES [Confections](id) ON DELETE CASCADE ON UPDATE CASCADE,
 [ProductId] int not null FOREIGN KEY REFERENCES [Products](id) ON DELETE CASCADE ON UPDATE CASCADE
);