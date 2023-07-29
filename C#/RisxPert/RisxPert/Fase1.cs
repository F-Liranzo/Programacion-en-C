using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RisxPert
{
    public partial class Fase1 : Form
    {
        private DataStore dataStore;
        public Fase1()
        {
            InitializeComponent();
            dataStore = new DataStore(); // Instancia de DataStore

        }


        // Clase para almacenar los datos //
        public class DataStore  
        {
            public DataTable Data { get; set; }

            public DataStore()
            {
                Data = new DataTable();
            }
        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            dataStore.Data = (DataTable)Tabla1.DataSource;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Fase2 fase2 = new Fase2(dataStore); // Pasar la instancia de DataStore
            fase2.Show();
        }
    }
    lblID
}
