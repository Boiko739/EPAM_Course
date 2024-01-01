SELECT 
    p.id, 
    p.comment AS title, 
    COALESCE((SELECT SUM(od.product_amount) 
    FROM order_details od 
    JOIN customer_order co ON od.customer_order_id = co.id 
    JOIN customer c ON co.customer_id = c.person_id 
    WHERE c.discount > 5 AND p.id = od.product_id), 0) AS count_with_discount_5, 
    COALESCE((SELECT SUM(od.product_amount) FROM order_details od 
    JOIN customer_order co ON od.customer_order_id = co.id 
    JOIN customer c ON co.customer_id = c.person_id 
    WHERE (c.discount <= 5 OR c.discount IS NULL) AND p.id = od.product_id), 0) AS count_without_discount_5, 
    CAST (((COALESCE((SELECT SUM(od.product_amount) FROM order_details od 
    JOIN customer_order co ON od.customer_order_id = co.id 
    JOIN customer c ON co.customer_id = c.person_id 
    WHERE c.discount > 5 AND p.id = od.product_id), 0)
    - COALESCE((SELECT SUM(od.product_amount) FROM order_details od 
    JOIN customer_order co ON od.customer_order_id = co.id 
    JOIN customer c ON co.customer_id = c.person_id 
    WHERE (c.discount <= 5 OR c.discount IS NULL) AND p.id = od.product_id), 0)) 
    / MAX(COALESCE((SELECT SUM(od.product_amount) FROM order_details od 
    JOIN customer_order co ON od.customer_order_id = co.id 
    JOIN customer c ON co.customer_id = c.person_id 
    WHERE (c.discount <= 5 OR c.discount IS NULL) AND p.id = od.product_id), 1), 1))
    * 100 AS REAL) AS difference
FROM product AS p
JOIN product_title AS pt ON p.product_title_id = pt.id
GROUP BY p.id, pt.title
ORDER BY p.id ASC;
