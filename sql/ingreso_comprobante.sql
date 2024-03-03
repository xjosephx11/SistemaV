create proc ingreso_comprobante
@idingreso int
as
select p.nombre as Proveedor, p.direccion, p.telefono, p.email,
u.nombre as Usuario, i.tipo_comprobante, i.serie_comprobante, i.num_comprobante,
i.fecha, i.impuesto, i.total,
a.nombre as articulo, d.cantidad, d.precio
from ingreso i inner join persona p on i.idproveedor = p.idpersona
inner join usuario u on i.idusuario = u.idusuario
inner join detalle_ingreso d on i.idingreso = d.idingreso
inner join articulo a on d.idarticulo = a.idarticulo
where i.idingreso = @idingreso
go