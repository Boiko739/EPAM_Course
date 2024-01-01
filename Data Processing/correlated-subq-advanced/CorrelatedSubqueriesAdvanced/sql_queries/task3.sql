WITH product_counts AS (
    SELECT 
        p.product_title_id, 
        p.manufacturer_id, 
        COUNT(*) AS cnt
    FROM 
        product AS p
    JOIN 
        order_details AS od ON p.id = od.product_id
    GROUP BY 
        p.product_title_id, 
        p.manufacturer_id
),
max_counts AS (
    SELECT 
        product_title_id, 
        MAX(cnt) AS max_cnt
    FROM 
        product_counts
    GROUP BY 
        product_title_id
),
ranked_manufacturers AS (
    SELECT 
        pc.product_title_id,
        pc.manufacturer_id,
        ROW_NUMBER() OVER(PARTITION BY pc.product_title_id ORDER BY pc.cnt DESC, pc.manufacturer_id ASC) as rn
    FROM 
        product_counts AS pc
    JOIN 
        max_counts AS mc ON pc.product_title_id = mc.product_title_id AND pc.cnt = mc.max_cnt
)
SELECT 
    pt.id AS product_id, 
    pt.title, 
    m.id AS manufacturer_id, 
    m.name AS manufacturer
FROM 
    product_title AS pt
LEFT JOIN 
    ranked_manufacturers AS rm ON pt.id = rm.product_title_id AND rm.rn = 1
LEFT JOIN 
    manufacturer AS m ON rm.manufacturer_id = m.id
ORDER BY 
    pt.id ASC;
