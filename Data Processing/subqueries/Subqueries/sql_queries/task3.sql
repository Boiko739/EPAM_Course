SELECT co.id AS order_id, COUNT(od.product_id) AS items_count
FROM customer_order co
INNER JOIN order_details od ON co.id = od.customer_order_id
WHERE strftime('%Y', co.operation_time) = '2021'
GROUP BY co.id
HAVING items_count > (SELECT AVG(items_count) FROM (
    SELECT COUNT(od.product_id) AS items_count
    FROM customer_order co
    INNER JOIN order_details od ON co.id = od.customer_order_id
    GROUP BY co.id
) subquery)
ORDER BY items_count ASC, order_id ASC;
