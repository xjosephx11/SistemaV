CREATE TRIGGER Venta_ActualizarStock
   ON detalle_venta
   FOR INSERT
   AS
   UPDATE a SET a.stock=a.stock-d.cantidad
   FROM articulo AS a INNER JOIN
   INSERTED AS d ON d.idarticulo=a.idarticulo
go
