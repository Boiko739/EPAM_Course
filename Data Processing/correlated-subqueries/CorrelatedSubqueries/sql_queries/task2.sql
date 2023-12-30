SELECT product_category.id, product_category.name
FROM product_category
JOIN product_title ON product_category.id = product_title.product_category_id
JOIN product ON product_title.id = product.product_title_id
GROUP BY product_category.id, product_category.name
HAVING COUNT(DISTINCT product.id) = (
    SELECT COUNT(DISTINCT product_id)
    FROM order_details
    WHERE product_id IN (
        SELECT id
        FROM product
        WHERE product_title_id IN (
            SELECT id
            FROM product_title
            WHERE product_category_id = product_category.id
        )
    )
)
ORDER BY product_category.id ASC;
