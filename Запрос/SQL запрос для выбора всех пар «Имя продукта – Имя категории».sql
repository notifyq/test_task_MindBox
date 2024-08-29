use test_db;

select products.product_name as "Товар", categories.category_name as "Категория"
from products_categories
left join categories on categories.category_id = products_categories.category_id
right join products on products.product_id = products_categories.product_id
ORDER BY products.product_name;

