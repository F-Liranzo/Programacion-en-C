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
        private int resultadoERValue;

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
            public int F { get; set; }
            public int S { get; set; }
            public int P { get; set; }
            public int E { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            public int C { get; set; }
            public int PB { get; set; }
            public int ER { get; set; }
            public string Clase { get; set; }
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
                    

                    F = Convert.ToInt32(row.Cells[5].Value),
                    S = Convert.ToInt32(row.Cells[6].Value),
                    P = Convert.ToInt32(row.Cells[7].Value),
                    E = Convert.ToInt32(row.Cells[8].Value),
                    A = Convert.ToInt32(row.Cells[9].Value),
                    V = Convert.ToInt32(row.Cells[10].Value),
                    C = Convert.ToInt32(row.Cells[11].Value),
                    PB = Convert.ToInt32(row.Cells[12].Value),
                    ER = Convert.ToInt32(row.Cells[13].Value),
                    //Clase = Convert.ToString(row.Cells[14].Value),

                };
                dataList.Add(data);
            }
        }

        private void LoadDataGridViewData(DataGridView dataGridView, List<DataGridViewData> dataList)
        {
            dataGridView.Rows.Clear();

            foreach (DataGridViewData data in dataList)
            {
                dataGridView.Rows.Add(data.ID, data.Nombrederiesgo, data.Activo, data.Riesgo, data.Daño, data.F, data.S, data.P, data.E, data.A, data.V);
            }
            
        }
        

        private void CalcularResultados(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int F = Convert.ToInt32(row.Cells[5].Value),
                    S = Convert.ToInt32(row.Cells[6].Value),
                    P = Convert.ToInt32(row.Cells[7].Value),
                    E = Convert.ToInt32(row.Cells[8].Value),
                    A = Convert.ToInt32(row.Cells[9].Value),
                    V = Convert.ToInt32(row.Cells[10].Value);
                //string Clase = Convert.ToString(row.Cells[14].Value);

                // Realizar los cálculos
                int resultado1 = F * S;
                int resultado2 = P * E;
                int resultadoC = resultado1 + resultado2;
                int resultadoPB = A * V;
                int resultadoER = resultadoC * resultadoPB;

                // Mostrar el resultado en la columna "C" en la misma fila
                row.Cells[11].Value = resultadoC;
                row.Cells[12].Value = resultadoPB;
                row.Cells[13].Value = resultadoER;

                // bucle if para cambiar el color de la celdas 
                //F
                if (F <= 2)
                {
                    row.Cells[5].Style.BackColor = Color.Green;
                }
                else if (F <= 4)
                {
                    row.Cells[5].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[5].Style.BackColor = Color.Red;
                }

                // S
                if (S <= 2)
                {
                    row.Cells[6].Style.BackColor = Color.Green;
                }
                else if (S <= 4)
                {
                    row.Cells[6].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[6].Style.BackColor = Color.Red;
                }

                //P 
                if (P <= 2)
                {
                    row.Cells[7].Style.BackColor = Color.Green;
                }
                else if (P <= 4)
                {
                    row.Cells[7].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[7].Style.BackColor = Color.Red;
                }

                //E
                if (E <= 2)
                {
                    row.Cells[8].Style.BackColor = Color.Green;
                }
                else if (E <= 4)
                {
                    row.Cells[8].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[8].Style.BackColor = Color.Red;
                }

                //A
                if (A <= 2)
                {
                    row.Cells[9].Style.BackColor = Color.Green;
                }
                else if (A <= 4)
                {
                    row.Cells[9].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[9].Style.BackColor = Color.Red;
                }

                //V
                if (V <= 2)
                {
                    row.Cells[10].Style.BackColor = Color.Green;
                }
                else if (V <= 4)
                {
                    row.Cells[10].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[10].Style.BackColor = Color.Red;
                }




                //Cambiar color de ER y Colocar el valor de la clase de riesgo en la fase 4 

                if (resultadoER <= 250)
                {
                    //row.Cells[14].Value = "Muy Pequeño";
                    row.Cells[13].Style.BackColor = Color.Green;
                }
                else if (resultadoER <= 500)
                {
                    //row.Cells[14].Value = "Pequeño";
                    row.Cells[13].Style.BackColor = Color.Green;
                }
                else if (resultadoER <= 750)
                {
                    //row.Cells[14].Value = "Normal";
                    row.Cells[13].Style.BackColor = Color.Yellow;
                }
                else if (resultadoER <= 1000)
                {
                    //row.Cells[14].Value = "Grande";
                    row.Cells[13].Style.BackColor = Color.Orange;
                }
                else
                {
                    //row.Cells[14].Value = "Elevado";
                    row.Cells[13].Style.BackColor = Color.Red;
                }
                
                
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
            CalcularResultados(dataGridView3); // Calcular y mostrar los resultados al cargar
        }

        private void Btn_abri_Fase4_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView4, dataGrid1Data);
            CalcularResultados(dataGridView4);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

