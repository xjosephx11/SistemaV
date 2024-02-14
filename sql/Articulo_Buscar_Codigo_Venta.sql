create proc articulo_buscar_codigo_venta
@valor varchar(50)
as
select idarticulo,codigo,nombre,precio_venta,stock
from articulo
where codigo=@valor and stock>0
go