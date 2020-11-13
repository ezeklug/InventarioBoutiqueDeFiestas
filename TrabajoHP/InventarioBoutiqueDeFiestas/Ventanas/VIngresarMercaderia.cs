using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
using InventarioBoutiqueDeFiestas.Style;

namespace InventarioBoutiqueDeFiestas.Ventanas
{
    public partial class VIngresarMercaderia : Form
    {
        ControladorFachada controladorFachada = new ControladorFachada();
        List<int> Productos { get; set; }
        DataGridView Filas { get; set; }

        public VIngresarMercaderia(List<int> productos, DataGridView filas)
        {
            Productos = productos;
            Filas = filas;
            InitializeComponent();

        }

        private void Listo_Click(object sender, EventArgs e)
        {
            int idLote = 0;
            List<ProductoDTO> ListaProductoDTO = new List<ProductoDTO>();
            int i = 0;
            Boolean controlVence = true; //True si esta ok 
            Boolean controlDatos = false; //True si esta ok
            Dictionary<LoteDTO,int> lotesAGuardar = new Dictionary<LoteDTO, int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) == 0 | Convert.ToDouble(row.Cells[3].Value) == 0) //Chequeo que cantidad y precio de compra sean >0
                {
                    controlDatos = false;
                }
                else //Cantidad y Precio de compra ok
                {
                    ProductoDTO unProducto = controladorFachada.BuscarProducto((Convert.ToInt32(row.Cells[0].Value)));
                    unProducto.CantidadEnStock += Convert.ToInt32(row.Cells[2].Value);
                    unProducto.IdCategoria = unProducto.CategoriaProductoDTO.Id;
                    unProducto.PrecioDeCompra = Convert.ToDouble(row.Cells[3].Value);
                    if (row.Cells[4].Value != "------")
                    {
                        if (string.IsNullOrEmpty((row.Cells[4].Value).ToString())) //Si no colocó fechaVencimiento
                        {
                            controlVence = false;
                            
                        }
                        else
                        {
                            LoteDTO unLote = new LoteDTO();
                            unLote.CantidadProductos = Convert.ToInt32(row.Cells[2].Value);
                            unLote.FechaCompra = DateTime.Now; // ARREGLAME
                            unLote.FechaVencimiento = Convert.ToDateTime(row.Cells[4].Value);
                            controlVence = true; //fechaVencimiento    OK
                            if (unLote.FechaCompra < unLote.FechaVencimiento)
                            {
                                unLote.Vencido = false;
                            }
                            else
                            {
                                unLote.Vencido = true;
                            }

                            unLote.IdProducto = unProducto.Id;
                            lotesAGuardar.Add(unLote,i);

                            //idLote = controladorFachada.GuardarLote(unLote);
                            //dataGridView1.Rows[i].Cells[5].Value = idLote;

                        }
                    }
                    i++;

                    ListaProductoDTO.Add(unProducto);
                    controlDatos = true;
                }
                controladorFachada.IngresoMercarderias(ListaProductoDTO);
            }
             
                Listo.Visible = false;
                Cancelar.Visible = false;
                Agregar.Visible = false;
                Boolean vencen = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!vencen)
                {
                    if (row.Cells[4].Value != "------")
                    {
                        vencen = true;
                    }
                }
            }

            if (!controlDatos | !controlVence) //Si falta algun dato
            {
                if (!controlDatos)
                {
                    MessageBox.Show("Debe completar la cantidad a ingresar y el Precio de Compra");
                }
                if (!controlVence)
                {
                    MessageBox.Show("Debe ingresar una fecha de vencimiento");
                }
                
                Listo.Visible = true;
                Cancelar.Visible = true;
                Agregar.Visible = true;
            }
            else if (vencen)  //Esta todo Ok y vencen 
            {
                Console.WriteLine(dataGridView1.Rows.Count);
               // int j = 0;
                        foreach (KeyValuePair<LoteDTO,int> lote in lotesAGuardar)
                        {
                            idLote = controladorFachada.GuardarLote(lote.Key);
                            dataGridView1.Rows[lote.Value].Cells[5].Value = idLote;
                            //Console.WriteLine(lotesAGuardar.Count());
                           
                        }            
                
                Confirmar.Visible = true;
                ConfirmarText.Visible = true;
            }
            else { 
                this.Hide();
                VControlProducto vControlProducto = new VControlProducto();
                vControlProducto.ShowDialog();
                this.Close();
                     
            }
            

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto(dataGridView1);
            vControlProducto.ShowDialog();
            this.Close();
        }

        private void VIngresarMercaderia_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioCompra", "Precio de Compra");
            dataGridView1.Columns.Add("FechaVencimiento", "Fecha de Vencimiento dd/mm/aaaa");
            dataGridView1.Columns.Add("NroLote", "Nro Lote");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            Confirmar.Visible = false;
            ConfirmarText.Visible = false;
            Listo.Visible = true;
            Cancelar.Visible = true;
            Agregar.Visible = true;
            if (Filas.RowCount != 0)
            {
                foreach (DataGridViewRow row in Filas.Rows)
                {
                    string[] r = new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString() , row.Cells[5].Value.ToString()};
                    dataGridView1.Rows.Add(r);
                }
            }
            if (Productos != null)
            {
            //    Boolean existe = false;
                foreach (ProductoPresupuestoDTO p in controladorFachada.ListarProductosPresupuesto(Productos))
                {
           /*         foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        if (row1.Cells[0].Value.ToString() == p.Id.ToString())
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {*/
                        string[] row = new string[] { p.Id.ToString(), p.Nombre, "0", "0", "", "" };
                        dataGridView1.Rows.Add(row);
                    }
             //   }
            }
            foreach (DataGridViewRow row3 in dataGridView1.Rows)
            {
                if (controladorFachada.VerificarSiCategoriaVence(Convert.ToInt32(row3.Cells[0].Value)))
                {
                    row3.Cells[4].ReadOnly = false;
                }
                else
                {
                    row3.Cells[4].Value = "------";
                    row3.Cells[4].ReadOnly = true;
                }
            }
            _ = new DatagridStyle(dataGridView1);
        }

        private void Principal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VPrincipal vPrincipal = new VPrincipal();
            vPrincipal.ShowDialog();
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VControlProducto vControlProducto = new VControlProducto();
            vControlProducto.ShowDialog();
            this.Close();
        }
    }
}
