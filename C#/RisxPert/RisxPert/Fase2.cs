using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RisxPert.Fase1;

namespace RisxPert
{
    public partial class Fase2 : Form
    {
        private DataStore dataStore;
        public Fase2()
        {
            InitializeComponent();
            this.dataStore = dataStore;
        }

        public Fase2(DataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        private void Tabla2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de cargar los datos
            Tabla2.DataSource = null;
            Tabla2.Rows.Clear();
            Tabla2.Columns.Clear();

            // Cargar los datos almacenados en DataStore en el nuevo DataGridView (dataGridView2)
            Tabla2.DataSource = dataStore.Data.Copy();
        }
    }
}
