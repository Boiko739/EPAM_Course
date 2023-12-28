SELECT pe.surname, pe.name, COALESCE(SUM(od.price_with_discount * od.product_amount), 0) AS sum
FROM person pe
INNER JOIN customer c ON pe.id = c.person_id
LEFT JOIN customer_order co ON c.person_id = co.customer_id
LEFT JOIN order_details od ON co.id = od.customer_order_id
GROUP BY pe.surname, pe.name

UNION

SELECT NULL AS surname, NULL AS name, COALESCE(SUM(od.price_with_discount * od.product_amount), 0) AS sum
FROM order_details od
LEFT JOIN customer_order co ON co.id = od.customer_order_id
WHERE co.customer_id IS NULL

ORDER BY sum ASC, surname ASC;
