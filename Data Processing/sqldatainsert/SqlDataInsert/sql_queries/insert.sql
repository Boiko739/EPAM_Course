INSERT INTO city (id, name) 
VALUES (1, 'City1'), (2, 'City2'), (3, 'City3');

INSERT INTO street (id, name, city_id) 
VALUES (1, 'Street1', 1), (2, 'Street2', 1), (3, 'Street3', 2), (4, 'Street4', 2), (5, 'Street5', 3);

INSERT INTO supermarket (id, name, street_id, house_number) 
VALUES (1, 'Supermarket1', 1, '1A'), (2, 'Supermarket2', 2, '2B'), (3, 'Supermarket3', 3, '3C'), (4, 'Supermarket4', 4, '4D'), (5, 'Supermarket5', 5, '5E'), (6, 'Supermarket6', 1, '6F'), (7, 'Supermarket7', 2, '7G');

INSERT INTO person (id, name, surname, birth_date) 
VALUES (1, 'Person1', 'Surname1', '2000-01-01'), (2, 'Person2', 'Surname2', '2000-01-02'), (3, 'Person3', 'Surname3', '2000-01-03'), (4, 'Person4', 'Surname4', '2000-01-04'), (5, 'Person5', 'Surname5', '2000-01-05'), (6, 'Person6', 'Surname6', '2000-01-06'), (7, 'Person7', 'Surname7', '2000-01-07'), (8, 'Person8', 'Surname8', '2000-01-08'), (9, 'Person9', 'Surname9', '2000-01-09'), (10, 'Person10', 'Surname10', '2000-01-10');

INSERT INTO contact_type (id, name) 
VALUES (1, 'ContactType1'), (2, 'ContactType2');

INSERT INTO person_contact (id, person_id, contact_type_id, contact_value) 
VALUES (1, 1, 1, 'ContactValue1'), (2, 2, 2, 'ContactValue2'), (3, 3, 1, 'ContactValue3'), (4, 4, 2, 'ContactValue4'), (5, 5, 1, 'ContactValue5'), (6, 6, 2, 'ContactValue6'), (7, 7, 1, 'ContactValue7'), (8, 8, 2, 'ContactValue8'), (9, 9, 1, 'ContactValue9'), (10, 10, 2, 'ContactValue10'), (11, 1, 2, 'ContactValue11'), (12, 2, 1, 'ContactValue12'), (13, 3, 2, 'ContactValue13'), (14, 4, 1, 'ContactValue14'), (15, 5, 2, 'ContactValue15'), (16, 6, 1, 'ContactValue16'), (17, 7, 2, 'ContactValue17'), (18, 8, 1, 'ContactValue18'), (19, 9, 2, 'ContactValue19'), (20, 10, 1, 'ContactValue20');

INSERT INTO customer (person_id, card_number, discount) 
VALUES 
(1, 'CardNumber1', 0), 
(2, 'CardNumber2', 0), 
(3, 'CardNumber3', 0), 
(4, 'CardNumber4', 0), 
(5, 'CardNumber5', 0), 
(6, 'CardNumber6', 0), 
(7, 'CardNumber7', 0), 
(8, 'CardNumber8', 0), 
(9, 'CardNumber9', 0), 
(10, 'CardNumber10', 0);

INSERT INTO product_category (id, name) 
VALUES (1, 'ProductCategory1'), (2, 'ProductCategory2'), (3, 'ProductCategory3');

INSERT INTO product_title (title, product_category_id) 
VALUES ('ProductTitle1', 1), ('ProductTitle2', 1), ('ProductTitle3', 1), ('ProductTitle4', 2), ('ProductTitle5', 2), ('ProductTitle6', 2), ('ProductTitle7', 3), ('ProductTitle8', 3), ('ProductTitle9', 3), ('ProductTitle10', 1);

INSERT INTO manufacturer (id, name) 
VALUES (1, 'Manufacturer1'), (2, 'Manufacturer2'), (3, 'Manufacturer3'), (4, 'Manufacturer4');

INSERT INTO product (id, manufacturer_id, product_title_id, price, comment) 
VALUES 
(1, 1, 1, 100, 'Comment1'), 
(2, 2, 1, 200, 'Comment2'), 
(3, 3, 2, 300, 'Comment3'), 
(4, 4, 2, 400, 'Comment4'), 
(5, 1, 3, 500, 'Comment5'), 
(6, 2, 3, 600, 'Comment6'), 
(7, 3, 1, 700, 'Comment7'), 
(8, 4, 1, 800, 'Comment8'), 
(9, 1, 2, 900, 'Comment9'), 
(10, 2, 2, 1000, 'Comment10'), 
(11, 3, 3, 1100, 'Comment11'), 
(12, 4, 3, 1200, 'Comment12'), 
(13, 1, 1, 1300, 'Comment13'), 
(14, 2, 1, 1400, 'Comment14'), 
(15, 3, 2, 1500, 'Comment15'), 
(16, 4, 2, 1600, 'Comment16'), 
(17, 1, 3, 1700, 'Comment17'), 
(18, 2, 3, 1800, 'Comment18'), 
(19, 3, 1, 1900, 'Comment19'), 
(20, 4, 1, 2000, 'Comment20');

INSERT INTO customer_order (id, operation_time, supermarket_id, customer_id) 
VALUES 
(1, '2023-01-01 00:00:00', 1, 1), 
(2, '2023-01-02 00:00:00', 1, 1), 
(3, '2023-01-03 00:00:00', 2, 2), 
(4, '2023-01-04 00:00:00', 2, 2), 
(5, '2023-01-05 00:00:00', 3, 3), 
(6, '2023-01-06 00:00:00', 3, 3), 
(7, '2023-01-07 00:00:00', 4, 4), 
(8, '2023-01-08 00:00:00', 4, 4), 
(9, '2023-01-09 00:00:00', 5, 5), 
(10, '2023-01-10 00:00:00', 5, 5), 
(11, '2023-01-11 00:00:00', 6, 6), 
(12, '2023-01-12 00:00:00', 6, 6), 
(13, '2023-01-13 00:00:00', 7, 7), 
(14, '2023-01-14 00:00:00', 7, 7), 
(15, '2023-01-15 00:00:00', 1, 1), 
(16, '2023-01-16 00:00:00', 1, 1), 
(17, '2023-01-17 00:00:00', 2, 2), 
(18, '2023-01-18 00:00:00', 2, 2), 
(19, '2023-01-19 00:00:00', 3, 3), 
(20, '2023-01-20 00:00:00', 3, 3);

INSERT INTO order_details (id, customer_order_id, product_id, price, price_with_discount, product_amount) 
VALUES 
(1, 1, 1, 100, 90, 1), 
(2, 2, 2, 200, 180, 1), 
(3, 3, 1, 300, 270, 1), 
(4, 4, 2, 400, 360, 1), 
(5, 5, 1, 500, 450, 1), 
(6, 6, 2, 600, 540, 1), 
(7, 7, 1, 700, 630, 1), 
(8, 8, 2, 800, 720, 1), 
(9, 9, 1, 900, 810, 1), 
(10, 10, 2, 1000, 900, 1), 
(11, 11, 1, 1100, 990, 1), 
(12, 12, 2, 1200, 1080, 1), 
(13, 13, 1, 1300, 1170, 1), 
(14, 14, 2, 1400, 1260, 1), 
(15, 15, 1, 1500, 1350, 1), 
(16, 16, 2, 1600, 1440, 1), 
(17, 17, 1, 1700, 1530, 1), 
(18, 18, 2, 1800, 1620, 1), 
(19, 19, 1, 1900, 1710, 1), 
(20, 20, 2, 2000, 1800, 1);