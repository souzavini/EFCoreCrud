SELECT t1.idVendedor, COUNT(*),IdProduto FROM test.venda t1
INNER JOIN test.vendaitem t2 ON t1.id = t2.idvenda
GROUP BY t1.idVendedor;

SELECT idVendedor,
    (SELECT 
            t2.idproduto AS qtde
        FROM
            test.venda t1
                INNER JOIN
            test.vendaitem t2 ON t1.id = t2.idvenda
        WHERE
            t1.idVendedor = v.idvendedor
            
        GROUP BY t1.Idvendedor ORDER BY COUNT(t2.idproduto) DESC
        LIMIT 1) AS teste
FROM
    test.venda v ;
    
    SELECT * FROM vendaitem;
