create database cosmetics_store;

USE cosmetics_store;

CREATE TABLE `clients` (
  `idclients` int NOT NULL AUTO_INCREMENT,
  `fio` varchar(200) NOT NULL,
  `phoneNumber` varchar(100) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `adress` varchar(1000) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`idclients`)
);

CREATE TABLE `discount_cards` (
  `iddiscount_cards` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `amount_of_discount` int NOT NULL,
  PRIMARY KEY (`iddiscount_cards`)
);

CREATE TABLE `clients-cards` (
  `idclients` int NOT NULL,
  `iddiscont_cards` int NOT NULL,
  KEY `fk_toclents_idx` (`idclients`),
  KEY `fk_tocards_idx` (`iddiscont_cards`),
  CONSTRAINT `fk_tocards` FOREIGN KEY (`iddiscont_cards`) REFERENCES `discount_cards` (`iddiscount_cards`),
  CONSTRAINT `fk_toclents` FOREIGN KEY (`idclients`) REFERENCES `clients` (`idclients`)
);

CREATE TABLE `customer_accounts` (
  `idcustomer_accounts` int NOT NULL AUTO_INCREMENT,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `idclients` int NOT NULL,
  PRIMARY KEY (`idcustomer_accounts`),
  KEY `fk_toclients_idx` (`idclients`),
  CONSTRAINT `fk_toclients` FOREIGN KEY (`idclients`) REFERENCES `clients` (`idclients`)
);

CREATE TABLE `providers` (
  `idproviders` int NOT NULL AUTO_INCREMENT,
  `firm` varchar(100) NOT NULL,
  `fio` varchar(100) NOT NULL,
  `adress` varchar(100) NOT NULL,
  `phoneNumber` varchar(100) NOT NULL,
  PRIMARY KEY (`idproviders`)
);

CREATE TABLE `deliveries` (
  `iddeliveries` int NOT NULL AUTO_INCREMENT,
  `datedeliveries` date NOT NULL,
  `idproviders` int NOT NULL,
  PRIMARY KEY (`iddeliveries`),
  KEY `fk_toproviders_idx` (`idproviders`),
  CONSTRAINT `fk_toproviders` FOREIGN KEY (`idproviders`) REFERENCES `providers` (`idproviders`)
);

CREATE TABLE `warehouses` (
  `idwarehouses` int NOT NULL AUTO_INCREMENT,
  `phoneNumber` varchar(100) NOT NULL,
  `adress` varchar(1000) NOT NULL,
  PRIMARY KEY (`idwarehouses`)
);

CREATE TABLE `products` (
  `idproducts` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `cost` varchar(1000) NOT NULL,
  `characteristic` longtext NOT NULL,
  `quantity` int NOT NULL,
  `idwarehouses` int NOT NULL,
  PRIMARY KEY (`idproducts`),
  KEY `fk_towarehouse_idx` (`idwarehouses`),
  CONSTRAINT `fk_towarehouse` FOREIGN KEY (`idwarehouses`) REFERENCES `warehouses` (`idwarehouses`)
);

CREATE TABLE `deliveries-products` (
  `iddeliveries` int NOT NULL,
  `idproducts` int NOT NULL,
  KEY `fk_todekiveries_idx` (`iddeliveries`),
  KEY `fk_toproducts_idx` (`idproducts`),
  CONSTRAINT `fk_todekiveries` FOREIGN KEY (`iddeliveries`) REFERENCES `deliveries` (`iddeliveries`),
  CONSTRAINT `fk_toproducts` FOREIGN KEY (`idproducts`) REFERENCES `products` (`idproducts`)
);

CREATE TABLE `employees` (
  `idemployees` int NOT NULL AUTO_INCREMENT,
  `fio` varchar(100) NOT NULL,
  `adress` varchar(1000) NOT NULL,
  `phoneNumber` varchar(100) NOT NULL,
  `position` varchar(100) NOT NULL,
  `dateOfBirth` date NOT NULL,
  PRIMARY KEY (`idemployees`)
);

CREATE TABLE `employees-clients` (
  `idemployees` int NOT NULL,
  `idclients` int NOT NULL,
  KEY `fk_toemloyees_idx` (`idemployees`),
  KEY `fk_toclients_idx` (`idclients`),
  CONSTRAINT `fk_toclients_clients` FOREIGN KEY (`idclients`) REFERENCES `clients` (`idclients`),
  CONSTRAINT `fk_toemployees` FOREIGN KEY (`idemployees`) REFERENCES `employees` (`idemployees`)
);

CREATE TABLE `place_of_issue_of_goods` (
  `idplace_of_issue_of_goods` int NOT NULL AUTO_INCREMENT,
  `adress` varchar(1000) NOT NULL,
  `phoneNumber` varchar(45) NOT NULL,
  PRIMARY KEY (`idplace_of_issue_of_goods`)
);

CREATE TABLE `orders` (
  `idorders` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `dateOrder` date NOT NULL,
  `return` tinyint NOT NULL,
  `cost` varchar(1000) NOT NULL,
  `idclients` int NOT NULL,
  `idplace_of_issue_of_goods` int NOT NULL,
  PRIMARY KEY (`idorders`),
  KEY `fk_toclients3_idx` (`idclients`),
  KEY `fk_toplace_of_issue_of_goods_idx` (`idplace_of_issue_of_goods`),
  CONSTRAINT `fk_toclients3` FOREIGN KEY (`idclients`) REFERENCES `clients` (`idclients`),
  CONSTRAINT `fk_toplace_of_issue_of_goods` FOREIGN KEY (`idplace_of_issue_of_goods`) REFERENCES `place_of_issue_of_goods` (`idplace_of_issue_of_goods`)
);

CREATE TABLE `pick-up staff` (
  `idemployees` int NOT NULL,
  `idplace_of_issue_of_goods` int NOT NULL,
  KEY `fk_toemployees2_idx` (`idemployees`),
  KEY `fk_toplace_of_issue)of_goods2_idx` (`idplace_of_issue_of_goods`),
  CONSTRAINT `fk_toemployees2` FOREIGN KEY (`idemployees`) REFERENCES `employees` (`idemployees`),
  CONSTRAINT `fk_toplace_of_issue)of_goods2` FOREIGN KEY (`idplace_of_issue_of_goods`) REFERENCES `place_of_issue_of_goods` (`idplace_of_issue_of_goods`)
);

CREATE TABLE `products-orders` (
  `idproducts` int NOT NULL,
  `idorders` int NOT NULL,
  `quantity` int NOT NULL,
  KEY `fk_toproducts_idx` (`idproducts`),
  KEY `fk_toproducts2_idx` (`idproducts`),
  KEY `fk_toorders1_idx` (`idorders`),
  CONSTRAINT `fk_toorders1` FOREIGN KEY (`idorders`) REFERENCES `orders` (`idorders`),
  CONSTRAINT `fk_toproducts2` FOREIGN KEY (`idproducts`) REFERENCES `products` (`idproducts`)
);

CREATE TABLE `warehouse_employee` (
  `idemloyees` int NOT NULL,
  `idwarehouses` int NOT NULL,
  KEY `fk_toemployees4_idx` (`idemloyees`),
  KEY `fk_towarehoses_idx` (`idwarehouses`),
  CONSTRAINT `fk_toemployees4` FOREIGN KEY (`idemloyees`) REFERENCES `employees` (`idemployees`),
  CONSTRAINT `fk_towarehoses` FOREIGN KEY (`idwarehouses`) REFERENCES `warehouses` (`idwarehouses`)
);

----------------------------------------------------------------------

ALTER TABLE `orders`
CHANGE COLUMN `name` `name` varchar(150) NOT NULL;
ALTER TABLE `place_of_issue_of_goods`
CHANGE COLUMN `adress` `adress` varchar(1100) NOT NULL;
ALTER TABLE `employees`
CHANGE COLUMN `fio` `full_name` varchar(100) NOT NULL;
ALTER TABLE `products`
CHANGE COLUMN `name` `name` varchar(150) NOT NULL,
CHANGE COLUMN `characteristic` `characteristic` varchar(1000) NOT NULL,
CHANGE COLUMN `cost` `cost` bigint NOT NULL;
ALTER TABLE `warehouses`
CHANGE COLUMN `adress` `adress` varchar(900) NOT NULL;
ALTER TABLE `providers`
CHANGE COLUMN `fio` `full_name` varchar(100) NOT NULL;
ALTER TABLE `customer_accounts`
CHANGE COLUMN `login` `login` varchar(90) NOT NULL;
ALTER TABLE `discount_cards`
CHANGE COLUMN `name` `full_name` varchar(150) NOT NULL;
ALTER TABLE `clients`
CHANGE COLUMN `fio` `full_name` varchar(100) NOT NULL;
ALTER TABLE `orders`
CHANGE COLUMN `cost` `cost` bigint NOT NULL;

----------------------------------------------------------------------

INSERT INTO `clients` VALUE (1,'Воробьёв Арсений Тарасович', '+7 (958) 245-04-28', '1978-01-01', '386246, г. Дебесы, ул. Конный пер, дом 125, квартира 695', 'ArseniyVorobev760@gmail.com');
INSERT INTO `customer_accounts` VALUE(2, 'ArseniyVorobev760', 'GFIkv5iBTx99', 1);
INSERT INTO `providers` VALUE(3, 'ООО Поставщик', 'Литковский Юрий Ермакович', '368938, г. Лысьва, ул. Гоголевский б-р, дом 59, квартира 900', '+7 (938) 488-43-23');
INSERT INTO `deliveries` VALUE(4, '2021-02-02', 3);
INSERT INTO `warehouses` VALUE(5, '+7 (993) 719-84-99', '607719, г. Заостровье, ул. Верхний 6-й пер, дом 163, квартира 548');
INSERT INTO `products` VALUE(6, 'Духи', '15000', 'С ароматом малины', '2', 5);
INSERT INTO `deliveries-products` VALUE(4,6);
INSERT INTO `discount_cards` VALUE(7, 'Воробьёв Арсений Тарасович', 20);
INSERT INTO `employees` VALUE(8, 'Изофатов Мирон Алексеевич', '624270, г. Шумерля, ул. Серафимовича 4-й пер, дом 145, квартира 964', '+7 (909) 587-61-26', 'Кассир', '1998-02-01');
INSERT INTO `employees-clients` VALUE(8,1);

-----------------------------------------------------------------------

ALTER TABLE `employees` RENAME COLUMN `position` TO `post`;
RENAME TABLE `pick-up staff` TO `pick-up_staff`;
RENAME TABLE `products` TO `product`;

-----------------------------------------------------------------------

DROP TABLE `clients`;
DROP TABLE `clients-cards`;
DROP TABLE `customer_accounts`;
DROP TABLE `deliveries`;
DROP TABLE `deliveries-products`;
DROP TABLE `discount_cards`;
DROP TABLE `employees`;
DROP TABLE `employees-clients`;
DROP TABLE `orders`;
DROP TABLE `pick-up_staff`;
DROP TABLE `place_of_issue_of_goods`;
DROP TABLE `product`;
DROP TABLE `products-orders`;
DROP TABLE `providers`;
DROP TABLE `warehouse_employee`;
DROP TABLE `warehouses`;
DROP DATABASE `cosmetics_store`;
