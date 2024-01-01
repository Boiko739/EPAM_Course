SELECT p.name, p.surname, 
    ROUND(subq.avg_purchase, 2) AS avg_purchase, 
    subq.sum_purchase
FROM (
    SELECT co.customer_id, 
        AVG(od.price_with_discount * od.product_amount) AS avg_purchase, 
        SUM(od.price_with_discount * od.product_amount) AS sum_purchase
    FROM customer_order co
    JOIN order_details od ON co.id = od.customer_order_id
    WHERE od.price > 0
    GROUP BY co.customer_id
    HAVING AVG(od.price_with_discount * od.product_amount) > 70
) subq 
LEFT JOIN person p ON subq.customer_id = p.id
ORDER BY subq.sum_purchase ASC, p.surname ASC;
