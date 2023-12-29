SELECT pe.surname, pe.name, SUM(od.price_with_discount * od.product_amount) AS total_expenses
FROM person pe
INNER JOIN customer c ON pe.id = c.person_id
INNER JOIN customer_order co ON c.person_id = co.customer_id
INNER JOIN order_details od ON co.id = od.customer_order_id
WHERE pe.birth_date BETWEEN '2000-01-01' AND '2010-12-31'
GROUP BY pe.surname, pe.name
HAVING total_expenses >= (SELECT AVG(total_expenses) FROM (
    SELECT SUM(od.price_with_discount * od.product_amount) AS total_expenses
    FROM customer_order co
    INNER JOIN order_details od ON co.id = od.customer_order_id
    WHERE co.customer_id IS NOT NULL
    GROUP BY co.customer_id
) subquery)
ORDER BY total_expenses ASC, pe.surname ASC;
