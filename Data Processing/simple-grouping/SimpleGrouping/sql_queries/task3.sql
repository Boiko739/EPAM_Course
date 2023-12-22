SELECT SUM((order_details.price - order_details.price_with_discount) * order_details.product_amount) AS max_order_discount
FROM customer_order
JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE order_details.price_with_discount < order_details.price
GROUP BY customer_order.id
ORDER BY max_order_discount DESC
LIMIT 1;