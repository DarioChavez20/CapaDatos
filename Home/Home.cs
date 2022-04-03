using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //    while (var datos in CapaNeg.Productos.Obtener()) {
            dataGridView1.DataSource = CapaNeg.Libros.Obtener();
            // }
        }
        public void exportToExcel(DataGridView listado)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listado.Columns)
            {
                indexColumn++;
                app.Cells[1, indexColumn] = columna.Name;
            }
            int indexRow = 0;
            foreach (DataGridViewRow fila in listado.Rows)
            {
                indexRow++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listado.Columns)
                {
                    indexColumn++;
                    app.Cells[indexRow + 1, indexColumn] = fila.Cells[columna.Name].Value;
                }
            }
            app.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            exportToExcel(dataGridView1);
        }
        public void exportToWord(DataGridView listado)
        {
           /* var app = new Microsoft.Office.Interop.Word.Application();
            //var doc = app.Documents.add();

            object missing = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Document document = app.Documents.Add(ref missing, ref missing, ref missing, ref missing, listado.RowCount + 1, listado.);

            document.Content.SetRange(0, 0);
            document.Content.Text = "Exportar archivos a word" + Environment.NewLine;

            for (var columna = 0; columna < listado.ColumnCount; columna++)
            {
                
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
