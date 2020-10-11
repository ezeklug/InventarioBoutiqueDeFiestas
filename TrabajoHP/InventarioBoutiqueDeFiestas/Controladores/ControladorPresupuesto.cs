using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Database;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{
    public class ControladorPresupuesto
    {
        public Presupuesto DTOAPresupuesto(PresupuestoDTO pPresupuesto)
        {
            Presupuesto pres = new Presupuesto();
            Repositorio repo = new Repositorio();

            pres.Id = pPresupuesto.Id;
            pres.FechaGeneracion = pPresupuesto.FechaGeneracion;
            pres.FechaVencimiento = pPresupuesto.FechaVencimiento;
            pres.Descuento = pPresupuesto.Descuento;
            Cliente cliente = repo.Clientes.Find(pPresupuesto.IdCliente);
            if (cliente == null)
            {
                throw new Exception("Id " + pPresupuesto.IdCliente + " no existe en Clientes");
            }
            pres.Cliente = cliente;
            return pres;
        }

        public Senia DTOASenia(SeniaDTO pSenia)  // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            Senia senia = new Senia();
            Repositorio repo = new Repositorio();

            senia.Id = pSenia.Id;
            senia.Fecha = pSenia.Fecha;
            senia.Monto = pSenia.Monto;
            Presupuesto presupuesto = repo.Presupuestos.Find(pSenia.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pSenia.IdPresupuesto + " no existe en Presupuestos");
            }

            senia.Presupuesto = presupuesto;
            return senia;
        }

        public Venta DTOAVenta(VentaDTO pVenta)  // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            Venta ven = new Venta();
            Repositorio repo = new Repositorio();

            ven.Id = pVenta.Id;
            ven.FechaDeVenta = pVenta.FechaDeVenta;
            Presupuesto presupuesto = repo.Presupuestos.Find(pVenta.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pVenta.IdPresupuesto + " no existe en Presupuestos");
            }

            ven.Presupuesto = presupuesto;
            return ven;
        }

        public LineaPresupuesto DTOALineaPresupuesto(LineaPresupuestoDTO pLinea) // TESTEAR CUANDO HAYA UN PRESUPUESTO EN BASE DE DATOS
        {
            LineaPresupuesto lin = new LineaPresupuesto();
            Repositorio repo = new Repositorio();

            lin.Id = pLinea.Id;
            lin.Cantidad = pLinea.Cantidad;
            lin.PorcentajeDescuento = pLinea.PorcentajeDescuento;
            Presupuesto presupuesto = repo.Presupuestos.Find(pLinea.IdPresupuesto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pLinea.IdPresupuesto + " no existe en Presupuestos");
            }
            lin.Presupuesto = presupuesto;
            Producto producto = repo.Productos.Find(pLinea.IdProducto);
            if (presupuesto == null)
            {
                throw new Exception("Id " + pLinea.IdProducto + " no existe en Productos");
            }
            lin.Producto = producto;
            lin.Subtotal = pLinea.Subtotal;
            return lin;
        }



        /// <summary>
        /// Modifica una senia de la db
        /// </summary>
        /// <param name="senia"></param>
        public void ModificarSenia(SeniaDTO senia)
        {
            if (senia.Id == 0)
            {
                throw new Exception("El id de la senia es 0");
            }
            using (var repo = new Repositorio())
            {
                var seniadb = repo.Senias.Find(senia.Id);
                seniadb.Monto = senia.Monto;
                seniadb.Fecha = senia.Fecha;
            }
        }


        /// <summary>
        /// Devuelve la senia si el prespuesto tiene una
        /// Si no tiene devuelve null
        /// </summary>
        /// <param name="pIdPrespupuesto"></param>
        /// <returns></returns>
        public SeniaDTO PresupuestoTieneSenia(int pIdPrespupuesto)
        {
            Senia senia = null;
            using (var repo = new Repositorio())
            {
                try
                {
                    senia = repo.Senias.Include("Presupuesto").Where(s => s.Presupuesto.Id == pIdPrespupuesto).First();
                }
                catch (InvalidOperationException e)
                {
                }
            }


            if (senia != null)
            {
                var dto = new SeniaDTO();
                dto.Id = senia.Id;
                dto.IdPresupuesto = senia.Presupuesto.Id;
                dto.Monto = senia.Monto;
                dto.Fecha = senia.Fecha;
                return dto;
            }
            else
            {
                return null;
            }
        }

        public ControladorPresupuesto()
        {


        }
        /// <summary>
        /// Método que permite agregar un presupuesto pasando sus parámetros para crearlo y guardarlo en db.
        /// </summary>
        /// <param name="presupuesto"></param>
        public int AgregarModificarPresupuesto(PresupuestoDTO pPrespuestoDTO)
        {
            using (var repo = new Repositorio())
            {
                Presupuesto pres = repo.Presupuestos.Find(pPrespuestoDTO.Id);
                Presupuesto presAAgregar = this.DTOAPresupuesto(pPrespuestoDTO);
                Cliente cli = repo.Clientes.Find(pPrespuestoDTO.IdCliente);
                presAAgregar.Cliente = cli;
                if (pres == null)  // Crear presupuesto (si no existe)
                {
                    presAAgregar.Estado = EstadoPresupuesto.Presupuestado;
                    repo.Presupuestos.Add(presAAgregar);
                    repo.SaveChanges();
                    return presAAgregar.Id;
                }
                else  // Modificar Presupuesto (si existe)
                {
                    pres.FechaEntrega = presAAgregar.FechaEntrega;
                    pres.FechaEvento = presAAgregar.FechaEvento;
                    pres.FechaVencimiento = presAAgregar.FechaVencimiento;
                    pres.FechaGeneracion = presAAgregar.FechaGeneracion;
                    pres.Descuento = presAAgregar.Descuento;
                    repo.SaveChanges();
                    return pres.Id;
                }
            }
        }

        /// <summary>
        /// Método que permite agregar una línea correspondiente a un presupuesto y un producto, pasando los siguientes parámetros.
        /// </summary>
        /// <param name="pPrecioVenta"></param>
        /// <param name="pCantidad"></param>
        /// <param name="pDescripcion"></param>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pIdProducto"></param>
        public int AgregarModificarLinea(LineaPresupuestoDTO pLineaPresupuestoDTO)
        {
            using (var repo = new Repositorio())
            {
                List<LineaPresupuesto> lineapresupuestos = repo.LineaPresupuestos.Include("Presupuesto").Include("Producto").Where(p=>p.Presupuesto.Id==pLineaPresupuestoDTO.IdPresupuesto && p.Producto.Id==pLineaPresupuestoDTO.IdProducto).ToList();
                LineaPresupuesto lineapres=new LineaPresupuesto();
                if(lineapresupuestos.Count!=0)
                {
                    lineapres = lineapresupuestos.First();
                }
                LineaPresupuesto lineaAAgregar = this.DTOALineaPresupuesto(pLineaPresupuestoDTO);
                Producto pro = repo.Productos.Find(pLineaPresupuestoDTO.IdProducto);
                lineaAAgregar.Producto = pro;
                Presupuesto pres = repo.Presupuestos.Find(pLineaPresupuestoDTO.IdPresupuesto);
                lineaAAgregar.Presupuesto = pres;
                if (lineapres.Id == 0)  // Crear linea presupuesto (si no existe)
                {
                    repo.LineaPresupuestos.Add(lineaAAgregar);
                    repo.SaveChanges();
                    return lineaAAgregar.Id;
                }
                else  // Modificar linea presupuesto (si ya existe)
                {
                    lineapres.Cantidad = lineaAAgregar.Cantidad;
                    lineapres.PorcentajeDescuento = lineaAAgregar.PorcentajeDescuento;
                    lineapres.Subtotal = lineaAAgregar.Subtotal;
                    return lineapres.Id;
                }

            }
        }



        /// <summary>
        /// Dada una id, devuelve el objeto presupuesto
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <returns></returns>
        public Presupuesto BuscarPresupuesto(int pIdPresupuesto)
        {
            using (var repo = new Repositorio())
            {
                return repo.Presupuestos.Include("Lineas").Where(p => p.Id == pIdPresupuesto).First();
            }
        }

        /// <summary>
        /// Este metodo permite señar un presupuesto pasando como parámetro el id del presupuesto y el monto de la seña.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pMontoSenia"></param>
        public void SeniarPresupuesto(SeniaDTO pSenia)
        {
            using (var repo = new Repositorio())
            {
                var presupuesto = repo.Presupuestos.Find(pSenia.IdPresupuesto);
                if (presupuesto == null)
                {
                    throw new Exception("Presupuesto" + pSenia.IdPresupuesto + " no existe");
                }
                var senia = new Senia(pSenia.Monto, presupuesto);
                senia.Fecha = pSenia.Fecha;
                senia.ValidoHasta = pSenia.ValidoHasta;
                presupuesto.Estado = EstadoPresupuesto.Seniado;
                repo.Senias.Add(senia);
            }
        }

        /// <summary>
        /// Vende un presupuesto y guarda la venta en la base de datos
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        public List<Tuple<string, int, int>> Vender(int pIdPresupuesto)
        {
            List<Tuple<string,int,int>> productosSinStockSuficiente = new List<Tuple<string,int,int>>();
            using (var repo = new Repositorio()) {
                Presupuesto presupuesto = repo.Presupuestos.Find(pIdPresupuesto);
                if (presupuesto == null)
                {
                    throw new Exception("Presupuesto" + pIdPresupuesto + " no existe");
                }
                List<LineaPresupuesto> lineas = repo.LineaPresupuestos.Include("Presupuesto").Include("Producto").Where(p => p.Presupuesto.Id == pIdPresupuesto).ToList();
                foreach(LineaPresupuesto linea in lineas)
                {
                    Producto producto = repo.Productos.Find(linea.Producto.Id);
                    if(producto.CantidadEnStock>=linea.Cantidad)
                    {
                        producto.CantidadEnStock -= linea.Cantidad;
                    }
                    else
                    {
                        productosSinStockSuficiente.Add(Tuple.Create(producto.Nombre,producto.CantidadEnStock,linea.Cantidad-producto.CantidadEnStock));
                    }
                }
                if (productosSinStockSuficiente.Count==0)
                {
                    Venta venta = new Venta(presupuesto);
                    presupuesto.Estado = EstadoPresupuesto.Vendido;
                    repo.Ventas.Add(venta);
                }
                return productosSinStockSuficiente;
            }
        }

        /// <summary>
        /// Este metodo permite asociar un cliente a un presupuesto, pasando como parámetro el id del presupuesto y el id del cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdPresupuesto"></param>
        public void AsociarCliente(int pIdCliente, int pIdPresupuesto)
        {
            using (var repo = new Repositorio())
            {
                Cliente cli = repo.Clientes.Find(pIdCliente);
                repo.Presupuestos.Find(pIdPresupuesto).Cliente = cli;
            }
        }

        /// <summary>
        /// Este método permite aplicar un descuento a todo un presupuesto, pasando como parámetro el id del presupuesto y el monto de descuento
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoTotal(int pIdPresupuesto, float pDescuento)
        {
            using (var repo = new Repositorio())
            {
                repo.Presupuestos.Find(pIdPresupuesto).Descuento = pDescuento;
            }
        }

        /// <summary>
        /// Este método permite listar todos los presupuestos guardados en BD.
        /// </summary>
        /// <returns></returns>
        public List<PresupuestoDTO> ListarPresupuesto()
        {
            List<Presupuesto> presupuestos = new List<Presupuesto>();
            List<PresupuestoDTO> presupuestoDTOs = new List<PresupuestoDTO>();
            using (var repo = new Repositorio())
            {
                presupuestos = repo.Presupuestos.Include("Cliente").ToList();
            }
            foreach (Presupuesto pre in presupuestos)
            {
                PresupuestoDTO pDTO = this.PresupuestoADTO(pre);
                presupuestoDTOs.Add(pDTO);
            }
            return presupuestoDTOs;
        }

        private PresupuestoDTO PresupuestoADTO(Presupuesto pre)
        {
            PresupuestoDTO pDTO = new PresupuestoDTO();
            pDTO.Id = pre.Id;
            pDTO.FechaGeneracion = pre.FechaGeneracion;
            pDTO.FechaVencimiento = pre.FechaVencimiento;
            pDTO.Estado = pre.Estado;
            pDTO.IdCliente = pre.Cliente.Id;
            pDTO.Descuento = pre.Descuento;
            return pDTO;
        }

        /// <summary>
        /// Aplica el descento a una linea
        /// pDescuento debe estar entre [0,1]. 0.2 significa que queda un 80% del precio total
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="idProducto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoLinea(int pIdLinea, float pDescuento)
        {
            using (var repo = new Repositorio())
            {
                var linea = repo.LineaPresupuestos.Find(pIdLinea);
                if (linea == null)
                {
                    throw new Exception("Linea " + pIdLinea + " no existe");
                }
                linea.PorcentajeDescuento = (double)pDescuento;
            }
        }

        public List<LineaPresupuestoDTO> ListarLineasPresupuesto(int pIdPresupuesto)
        {
            List<LineaPresupuestoDTO> ADevolver = new List<LineaPresupuestoDTO>();
            List<LineaPresupuesto> lineas = new List<LineaPresupuesto>();
            using (var repo = new Repositorio())
            {
                lineas = repo.LineaPresupuestos.Include("Producto").Where(p => p.Presupuesto.Id == pIdPresupuesto).ToList();
            }
            foreach (LineaPresupuesto lin in lineas)
            {
                LineaPresupuestoDTO lineaPresupuestoDTO = this.LineaPresupuestoADTO(lin);
                ADevolver.Add(lineaPresupuestoDTO);
            }
            return ADevolver;
        }

        public LineaPresupuestoDTO LineaPresupuestoADTO(LineaPresupuesto lineaPresupuesto)
        {
            LineaPresupuestoDTO linea = new LineaPresupuestoDTO();
            linea.Id = lineaPresupuesto.Id;
            linea.Cantidad = lineaPresupuesto.Cantidad;
            linea.PorcentajeDescuento = lineaPresupuesto.PorcentajeDescuento;
            linea.IdProducto = lineaPresupuesto.Producto.Id;
            linea.Subtotal = lineaPresupuesto.Subtotal;
            linea.NombreProducto = lineaPresupuesto.Producto.Nombre;
            linea.PrecioUnitario = lineaPresupuesto.Producto.PrecioVenta();
            return linea;
        }

        public List<LineaPresupuestoDTO> ListarLineasConLotePresupuesto(int pIdPresupuesto)
        {
            ControladorFachada controladorFachada = new ControladorFachada();
            List<LineaPresupuestoDTO> ADevolver = new List<LineaPresupuestoDTO>();
            List<LineaPresupuesto> lineas = new List<LineaPresupuesto>();
            using (var repo = new Repositorio())
            {
                lineas = repo.LineaPresupuestos.Include("Producto").Where(p => p.Presupuesto.Id == pIdPresupuesto).ToList();
            }
            foreach (LineaPresupuesto lin in lineas)
            {
                if (controladorFachada.VerificarSiCategoriaVence(lin.Producto.Id))
                {
                    LineaPresupuestoDTO lineaPresupuestoDTO = new LineaPresupuestoDTO();
                    lineaPresupuestoDTO.NombreProducto = lin.Producto.Nombre;
                    lineaPresupuestoDTO.Cantidad = lin.Cantidad;
                    Tuple<string, Dictionary<int, int>> Lotes = DeterminarLotes(lin.Producto.Id, lin.Cantidad);
                    lineaPresupuestoDTO.Lotes = Lotes.Item1;
                    lineaPresupuestoDTO.LoteYCantidad = Lotes.Item2;
                    ADevolver.Add(lineaPresupuestoDTO);
                }
            }
            return ADevolver;
        }

        public Tuple<string,Dictionary<int,int>> DeterminarLotes(int pIdProducto, int pCantidad)
        {
            Dictionary<int, int> loteYCantidad = new Dictionary<int, int>();
            string ADevolver = "";
            List<Lote> lotes = new List<Lote>();
            using (var repo=new Repositorio())
            {
                lotes=repo.Lotes.Include("Producto").Where(l => l.Producto.Id == pIdProducto && !l.Vencido).OrderBy(p=>p.FechaVencimiento).ToList();
            }
            int i = 0;
            while(pCantidad>0 && lotes.Count>i)
            {
                if(pCantidad>= lotes[i].CantidadProductos)
                {
                    pCantidad -= lotes[i].CantidadProductos;
                    loteYCantidad.Add(lotes[i].Id, lotes[i].CantidadProductos);
                }
                else
                {
                    loteYCantidad.Add(lotes[i].Id, pCantidad);
                    pCantidad -= pCantidad;
                }
                ADevolver += lotes[i].Id.ToString();
                if (pCantidad>0)
                {
                    ADevolver += ", ";
                }
                else
                {
                    ADevolver += ".";
                }
                i++;
            }
            return Tuple.Create(ADevolver,loteYCantidad);
        }
    }
}
