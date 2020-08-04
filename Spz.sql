




SELECT temp_tab.datap,MAX(temp_tab.resultado) AS maximo , MIN(temp_tab.resultado) AS menor
FROM
(SELECT vendas.DataPedido AS datap , SUM(Quantidade) AS resultado
FROM vendas GROUP BY vendas.DataPedido) AS temp_tab;
 

SELECT vendas.DataPedido AS datap , SUM(Quantidade) AS resultado
FROM vendas
GROUP BY vendas.DataPedido;

SELECT * FROM vendas;

SELECT dataPedido,SUM(quantidade) FROM vendas
GROUP BY dataPedido;

SELECT  FROM vendas;

SELECT * FROM 
