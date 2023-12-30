SELECT id, name
FROM city
WHERE id NOT IN (SELECT DISTINCT city_id FROM street)
ORDER BY name ASC;
