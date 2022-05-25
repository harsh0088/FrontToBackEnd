use LaptopDb
go
create table Laptop
(laptop_id int identity(1,1) primary key not null,
laptop_name nvarchar(100),
laptop_brand nvarchar(30),
laptop_size nvarchar(10),
laptop_storage nvarchar(30),
laptop_price nvarchar(30),
);

insert into Laptop values
('Apple 16-Inch MacBook Pro M1 Max', 'Apple', '16 inch', '1 Tb', 'Rs. 309,990'),
('Dell XPS 13 (9310)', 'Dell', '13 inch', '1 Tb', 'Rs. 201,990'),
('ASUS ROG Flow x13', 'Asus', '13 inch', '1 Tb', 'Rs. 154,990'),
('Apple MacBook Air M1', 'Apple', '13 inch', '512 GB', 'Rs. 86,990'),
('Lenovo Yoga Slim 7i Carbon', 'Lenovo', '14 inch', '512 GB', 'Rs. 109,990'),
('ASUS ExpertBook B9400', 'Asus', '14 inch', '512 GB', 'Rs. 167,994'),
('Acer Nitro 5', 'Acer', '17 inch', '1 Tb', 'Rs. 95,990'),
('Acer Aspire 7 Gaming', 'Acer', '15 inch', '2 Tb', 'Rs. 53,490'),
('MSI Pulse GL66', 'MSI', '15 inch', '1 Tb', 'Rs. 1,79,990'),
('ASUS ROG Zephyrus G14', 'Asus', '14 inch', '1 TB', 'Rs. 144,990');
