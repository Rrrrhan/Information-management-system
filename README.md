# Information-management-system

Create a database first

create DATABASE productdb;

CREATE TABLE `products` (
  `id` int NOT NULL AUTO_INCREMENT COMMENT 'product ID',
  `name` varchar(255) NOT NULL COMMENT 'product name',
  `code` varchar(255) NOT NULL COMMENT 'product code',
  `specification` varchar(255) NOT NULL COMMENT 'product specification',
  `inventory` int NOT NULL COMMENT 'number of products in stock',
  `created_at` timestamp NOT NULL COMMENT 'creation time',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb3;

INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (1, 'Computer', 'JH-001', 'Intel Core i7-10700K', 100, '2023-03-05 01:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (2, 'Smartphone', 'IP-002', 'iPhone 12 Pro Max', 50, '2023-03-05 02:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (3, 'Tablet', 'SG-003', 'iPad Air', 30, '2023-03-05 03:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (4, 'Television', 'LG-001', 'OLED55CX', 20, '2023-03-05 04:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (5, 'Camera', 'CN-001', 'Canon EOS R5', 15, '2023-03-05 05:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (6, 'Game Console', 'PS-004', 'PlayStation 5', 10, '2023-03-10 06:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (7, 'Air Conditioner', 'MI-003', 'Xiaomi Air Conditioner 3', 25, '2023-03-01 07:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (8, 'Washing Machine', 'SN-002', 'Samsung Fully Automatic Washing Machine', 35, '2023-03-05 08:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (9, 'Refrigerator', 'HA-002', 'Haier Refrigerator', 18, '2023-03-02 09:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (10, 'Speaker', 'BO-003', 'Bose SoundLink Revolve', 45, '2023-03-05 10:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (11, 'Computer', 'JH-002', 'Intel Core i5-9400H', 20, '2023-03-05 03:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (12, 'Computer', 'JH-002', 'Intel Core i7-9700H', 20, '2023-03-05 03:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (13, 'Computer', 'JH-004', 'AMD', 20, '2023-03-05 03:00:00');
INSERT INTO `productdb`.`products` (`id`, `name`, `code`, `specification`, `inventory`, `created_at`) VALUES (14, 'Computer', 'JH-002', 'Intel Core i5-8300H', 20, '2023-03-05 03:00:00');
