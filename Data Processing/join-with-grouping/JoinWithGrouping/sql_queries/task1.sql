SELECT pc.name AS category, COUNT(pr.id) AS count
FROM product_category pc
INNER JOIN product_title pt ON pc.id = pt.product_category_id
INNER JOIN product pr ON pt.id = pr.product_title_id
GROUP BY pc.name
HAVING COUNT(pr.id) > 0
ORDER BY pc.name ASC;
