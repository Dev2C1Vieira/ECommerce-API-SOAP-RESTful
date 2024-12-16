Use ISISOAPECommerce
GO

-- 1. Tabela Categories (sem dependências)
CREATE TABLE Categories (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL
);

-- 2. Tabela Clients (sem dependências)
CREATE TABLE Clients (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    nif INT NOT NULL,
    phoneNumber INT NOT NULL,
    address VARCHAR(255),
    email VARCHAR(255) NOT NULL
);

-- 3. Tabela Products (depende de Categories)
CREATE TABLE Products (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255),
    unitPrice DECIMAL(10, 2) NOT NULL,
    stock INT NOT NULL,
    categoryID INT NOT NULL,
    FOREIGN KEY (categoryID) REFERENCES Categories(id)
);

-- 4. Tabela Orders (depende de Clients)
CREATE TABLE Orders (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    orderDate DATE NOT NULL,
    totalCost DECIMAL(10, 2) NOT NULL,
    status INT NOT NULL,
    clientsID INT NOT NULL,
    FOREIGN KEY (clientsID) REFERENCES Clients(id)
);

-- 5. Tabela OrdersDetails (depende de Products e Orders)
CREATE TABLE OrdersDetails (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    quantity INT NOT NULL,
    cost DECIMAL(10, 2) NOT NULL,
    productID INT NOT NULL,
    orderID INT NOT NULL,
    FOREIGN KEY (productID) REFERENCES Products(id),
    FOREIGN KEY (orderID) REFERENCES Orders(id)
);