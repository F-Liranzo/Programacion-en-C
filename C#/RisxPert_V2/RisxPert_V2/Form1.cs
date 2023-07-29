using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace RisxPert_V2
{
    public partial class Form1 : Form
    {
        private List<DataGridViewData> dataGrid1Data = new List<DataGridViewData>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class DataGridViewData
        {
            public int ID { get; set; }
            public string Nombrederiesgo { get; set; }
            public string Daño { get; set; }
            public string Activo { get; set; }
            public string Riesgo { get; set; }
            public int S { get; set; }
            public int P { get; set; }
            public int E { get; set; }
            public int A { get; set; }
            public int V { get; set; }

        }

        private void SaveDataGridViewData(DataGridView dataGridView, List<DataGridViewData> dataList)
        {
            dataList.Clear();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataGridViewData data = new DataGridViewData
                {
                    ID = Convert.ToInt32(row.Cells[0].Value),
                    Nombrederiesgo = Convert.ToString(row.Cells[1].Value),
                    Activo = Convert.ToString(row.Cells[2].Value),
                    Riesgo = Convert.ToString(row.Cells[3].Value),
                    Daño = Convert.ToString(row.Cells[4].Value),
                    S = Convert.ToInt32(row.Cells[5].Value),
                    P = Convert.ToInt32(row.Cells[6].Value),
                    E = Convert.ToInt32(row.Cells[7].Value),
                    A = Convert.ToInt32(row.Cells[8].Value),
                    V = Convert.ToInt32(row.Cells[9].Value),
                };
                   dataList.Add(data);
            }
        }        

            
       

        private void LoadDataGridViewData(DataGridView dataGridView, List<DataGridViewData> dataList)
        {
            dataGridView.Rows.Clear();

            foreach (DataGridViewData data in dataList)
            {
                dataGridView.Rows.Add(data.ID,data.Nombrederiesgo,data.Activo,data.Riesgo,data.Daño,data.S,data.P,data.E,data.A,data.V);
            }
        }

 
        private void btn_Guardar1_Click(object sender, EventArgs e)
        {
            SaveDataGridViewData(dataGridView1, dataGrid1Data);
        }

        private void btn_Abrir1_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView2, dataGrid1Data);
        }

        private void btn_Guardar2_Click(object sender, EventArgs e)
        {
            SaveDataGridViewData(dataGridView2, dataGrid1Data);
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView3, dataGrid1Data);
        }
    }
}