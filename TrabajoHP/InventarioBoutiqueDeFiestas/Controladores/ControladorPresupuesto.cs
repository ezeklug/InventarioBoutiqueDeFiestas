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
        public Presupuesto DTOAPresupuesto (PresupuestoDTO pPresupuesto)
        {
            Presupuesto pres = new Presupuesto();
            Repositorio repo = new Repositorio();

            pres.Id = pPresupuesto.Id;
            pres.FechaEntrega = pPresupuesto.FechaEntrega;
            pres.FechaEvento = pPresupuesto.FechaEvento;
            pres.FechaGeneracion = pPresupuesto.FechaGeneracion;
            pres.FechaVencimiento = pPresupuesto.FechaVencimiento;
            pres.Estado = pPresupuesto.Estado;
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

            return lin;
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
                    repo.Presupuestos.Add(presAAgregar);
                    repo.SaveChanges();
                    return presAAgregar.Id;
                }
                else  // Modificar Presupuesto (si existe)
                {
                    pres.Estado = presAAgregar.Estado;
                    pres.FechaEntrega = presAAgregar.FechaEntrega;
                    pres.FechaEvento = presAAgregar.FechaEvento;
                    pres.FechaVencimiento = presAAgregar.FechaVencimiento;
                    pres.FechaGeneracion = presAAgregar.FechaGeneracion;
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
                LineaPresupuesto lineapres = repo.LineaPresupuestos.Find(pLineaPresupuestoDTO.Id);
                LineaPresupuesto lineaAAgregar = this.DTOALineaPresupuesto(pLineaPresupuestoDTO);
                Producto pro = repo.Productos.Find(pLineaPresupuestoDTO.IdProducto);
                lineaAAgregar.Producto = pro;
                Presupuesto pres = repo.Presupuestos.Find(pLineaPresupuestoDTO.IdPresupuesto);
                lineaAAgregar.Presupuesto = pres;
                if (lineapres == null)  // Crear linea presupuesto (si no existe)
                {
                    repo.LineaPresupuestos.Add(lineaAAgregar);
                    repo.SaveChanges();
                    return lineaAAgregar.Id;
                }
                else  // Modificar linea presupuesto (si ya existe)
                {
                    lineapres.Id = lineaAAgregar.Id;
                    lineapres.Cantidad = lineaAAgregar.Cantidad;
                    lineapres.PorcentajeDescuento = lineaAAgregar.PorcentajeDescuento;
                    lineapres.Subtotal = lineaAAgregar.Subtotal;
                    return lineapres.Id;
                }

            }
        }

        /// <summary>
        /// Este metodo permite señar un presupuesto pasando como parámetro el id del presupuesto y el monto de la seña.
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pMontoSenia"></param>
        public void SeniarPresupuesto(int pIdPresupuesto, double pMontoSenia)
        {
            using(var repo = new Repositorio())
            {
                var presupuesto = repo.Presupuestos.Find(pIdPresupuesto);
                if (presupuesto == null)
                {
                    throw new Exception("Presupuesto" + pIdPresupuesto + " no existe");
                }
                var senia = new Senia(pMontoSenia, presupuesto);
                repo.Senias.Add(senia);
            }
        }

        /// <summary>
        /// Vende un presupuesto y guarda la venta en la base de datos
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        public void Vender(int pIdPresupuesto)
        {
            using (var repo = new Repositorio()) {
                var presupuesto = repo.Presupuestos.Find(pIdPresupuesto);
                if (presupuesto == null)
                {
                    throw new Exception("Presupuesto" + pIdPresupuesto + " no existe");
                }

                var venta = new Venta(presupuesto);
                presupuesto.Estado = EstadoPresupuesto.Vendido;

                repo.Ventas.Add(venta);
            }
        }   

        /// <summary>
        /// Este metodo permite asociar un cliente a un presupuesto, pasando como parámetro el id del presupuesto y el id del cliente.
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdPresupuesto"></param>
        public void AsociarCliente(int pIdCliente, int pIdPresupuesto)
        {
            using (var repo=new Repositorio())
            {
                Cliente cli=repo.Clientes.Find(pIdCliente);
                repo.Presupuestos.Find(pIdPresupuesto).Cliente=cli;
            }
        }

        /// <summary>
        /// Este método permite aplicar un descuento a todo un presupuesto, pasando como parámetro el id del presupuesto y el monto de descuento
        /// </summary>
        /// <param name="pIdPresupuesto"></param>
        /// <param name="pDescuento"></param>
        public void AplicarDescuentoTotal(int pIdPresupuesto, float pDescuento)
        {//PrecioConDescuento
            using (var repo=new Repositorio())
            {
                repo.Presupuestos.Find(pIdPresupuesto).Descuento=pDescuento;
            }
        }

        /// <summary>
        /// Este método permite listar todos los presupuestos guardados en BD.
        /// </summary>
        /// <returns></returns>
        public List<Presupuesto> ListarPresupuesto()
        {
            using(var repo=new Repositorio())
            {
                return repo.Presupuestos.ToList();
            }
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
            using(var repo = new Repositorio())
            {
                var linea = repo.LineaPresupuestos.Find(pIdLinea);
                if(linea == null)
                {
                    throw new Exception("Linea " + pIdLinea + " no existe");
                }
                linea.PorcentajeDescuento = (double)pDescuento;
            }
        }
    }
}
