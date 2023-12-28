SELECT pc.name AS category, pt.title AS product
FROM product pr
INNER JOIN product_title pt ON pr.product_title_id = pt.id
LEFT JOIN product_category pc ON pt.product_category_id = pc.id
LEFT JOIN order_details od ON pr.id = od.product_id
WHERE od.product_id IS NULL
ORDER BY pr.id ASC;