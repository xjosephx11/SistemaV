create proc ingreso_consulta_fechas
@fecha_inicio date,
@fecha_fin date
as
select i.idingreso as ID,i.idusuario,u.nombre as Usuario,p.nombre as Proveedor,
i.tipo_comprobante as Tipo_Comprobante,i.serie_comprobante as Serie,
i.num_comprobante as Numero,i.fecha as Fecha,i.impuesto as Impuesto,
i.total as Total,i.estado as Estado
from ingreso i inner join usuario u on i.idusuario=u.idusuario
inner join persona p on i.idproveedor =p.idpersona
where i.fecha>=@fecha_inicio and i.fecha<=@fecha_fin
Order by i.idingreso desc