SELECT DISTINCT pt.title, pr.price
FROM order_details od
INNER JOIN product pr ON od.product_id = pr.id
INNER JOIN product_title pt ON pr.product_title_id = pt.id
INNER JOIN customer_order co ON od.customer_order_id = co.id
INNER JOIN customer c ON co.customer_id = c.person_id
INNER JOIN person pe ON c.person_id = pe.id
WHERE pe.birth_date BETWEEN '2000-01-01' AND '2010-12-31'
ORDER BY pt.title ASC, pr.price ASC;