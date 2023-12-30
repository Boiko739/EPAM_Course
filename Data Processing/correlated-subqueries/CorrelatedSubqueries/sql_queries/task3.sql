SELECT p.id, p.comment as title, p.price
FROM product p
JOIN product_title pt ON p.product_title_id = pt.id
JOIN (
    SELECT pt.product_category_id, AVG(p.price) as avg_price
    FROM product p
    JOIN product_title pt ON p.product_title_id = pt.id
    GROUP BY pt.product_category_id
) subq ON pt.product_category_id = subq.product_category_id
WHERE p.price > subq.avg_price
ORDER BY p.id ASC;
