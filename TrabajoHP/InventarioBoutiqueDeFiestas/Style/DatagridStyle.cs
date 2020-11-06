using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InventarioBoutiqueDeFiestas.Style
{
    public class DatagridStyle
    {
        public DatagridStyle(DataGridView datagridview1)
        {
            this.StyleDatagridView(datagridview1);
        }
        public void StyleDatagridView(DataGridView datagridview1)
        {
            datagridview1.BorderStyle = BorderStyle.None;
            datagridview1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            datagridview1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridview1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            datagridview1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            datagridview1.BackgroundColor = SystemColors.Control;
            datagridview1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagridview1.EnableHeadersVisualStyles = false;
            datagridview1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            datagridview1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            datagridview1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview1.DefaultCellStyle.Font = new Font("Century Gothic",9.5F);
        }
    }
}
