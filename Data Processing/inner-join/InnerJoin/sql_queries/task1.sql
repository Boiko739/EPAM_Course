SELECT p.id AS id, pt.title AS title, p.price AS price
FROM product as p
INNER JOIN product_title AS pt ON p.product_title_id = pt.id
ORDER BY pt.title ASC;
