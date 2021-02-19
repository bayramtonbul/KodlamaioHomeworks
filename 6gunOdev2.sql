SELECT 
P.ProductName 'URUN ADI',
SUM(OD.UnitPrice*OD.Quantity) 'KAZANILAN TOPLAM MIKTAR'
FROM [Order Details] OD 
JOIN Products P ON
OD.ProductID=P.ProductID
GROUP BY P.ProductName
ORDER BY 2 DESC