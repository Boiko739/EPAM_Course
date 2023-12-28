SELECT pe.surname, pe.name, pe.birth_date
FROM person pe
LEFT JOIN customer c ON pe.id = c.person_id
LEFT JOIN customer_order co ON c.person_id = co.customer_id
WHERE co.id IS NULL AND c.person_id IS NOT NULL
ORDER BY pe.surname ASC, pe.birth_date ASC;

