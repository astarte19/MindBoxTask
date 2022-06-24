SELECT prod.Name, cat.Name FROM Products prod LEFT JOIN ProductsCategories prodcat ON prod.Id = prodcat.ProductId LEFT JOIN Categories cat ON prodcat.CategoryId = cat.Id; ORDER BY prod.Name;