using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace RisxPert_V2
{
    public partial class Form1 : Form
    {
        private List<DataGridViewData> dataGrid1Data = new List<DataGridViewData>();
        private int resultadoERValue;
        private LiteDatabase _liteDb;

        public Form1()
        {
            InitializeComponent();
            string databasePath = @"C:\Users\Fraia\Desktop\basdatos\MyDatabase.db";
            _liteDb = new LiteDatabase(databasePath);

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

            SaveDataToDatabase(dataList);
        }

        private void SaveDataToDatabase(List<DataGridViewData> dataList)
        {
            var collection = _liteDb.GetCollection<DataGridViewData>("dataGrid1Data");
            collection.DeleteAll(); // Eliminar datos existentes

            foreach (var data in dataList)
            {
                collection.Insert(data);
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

        /*
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

                // Cambiar el color de las celdas utilizando switch-case
                ChangeCellBackColor(row.Cells[5], F);
                ChangeCellBackColor(row.Cells[6], S);
                ChangeCellBackColor(row.Cells[7], P);
                ChangeCellBackColor(row.Cells[8], E);
                ChangeCellBackColor(row.Cells[9], A);
                ChangeCellBackColor(row.Cells[10], V);
                
                // Revisar si el Numero es mayor a 5 si no da el error 
                CheckAndHandleError(F, row.Cells[5], "F");
                CheckAndHandleError(S, row.Cells[6], "S");
                CheckAndHandleError(P, row.Cells[7], "P");
                CheckAndHandleError(E, row.Cells[8], "E");
                CheckAndHandleError(A, row.Cells[9], "A");
                CheckAndHandleError(V, row.Cells[10], "V");
                // Cambiar color de ER y colocar el valor de la clase de riesgo en la fase 4
                ChangeERColorAndValue(row.Cells[13], row.Cells[14], resultadoER);
            }
        }

        

        // Mensaje de error si el valor es mayor a 5 
        private void CheckAndHandleError(int value, DataGridViewCell cell, string cellName)
        {
            if (value > 5)
            {
                MessageBox.Show($"Error: El valor en la celda {cellName} es mayor a 6. El número se borrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cell.Value = DBNull.Value;
            }
        }

        */


        private void CalcularResultados(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (IsValidCellValue(row.Cells[5]) && IsValidCellValue(row.Cells[6]) && IsValidCellValue(row.Cells[7]) &&
                    IsValidCellValue(row.Cells[8]) && IsValidCellValue(row.Cells[9]) && IsValidCellValue(row.Cells[10]))
                {
                    int F = Convert.ToInt32(row.Cells[5].Value),
                        S = Convert.ToInt32(row.Cells[6].Value),
                        P = Convert.ToInt32(row.Cells[7].Value),
                        E = Convert.ToInt32(row.Cells[8].Value),
                        A = Convert.ToInt32(row.Cells[9].Value),
                        V = Convert.ToInt32(row.Cells[10].Value);

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

                    // Cambiar el color de las celdas utilizando switch-case
                    ChangeCellBackColor(row.Cells[5], F);
                    ChangeCellBackColor(row.Cells[6], S);
                    ChangeCellBackColor(row.Cells[7], P);
                    ChangeCellBackColor(row.Cells[8], E);
                    ChangeCellBackColor(row.Cells[9], A);
                    ChangeCellBackColor(row.Cells[10], V);

                    // Revisar si el Numero es mayor a 5 si no da el error 
                    CheckAndHandleError(F, row.Cells[5], "F");
                    CheckAndHandleError(S, row.Cells[6], "S");
                    CheckAndHandleError(P, row.Cells[7], "P");
                    CheckAndHandleError(E, row.Cells[8], "E");
                    CheckAndHandleError(A, row.Cells[9], "A");
                    CheckAndHandleError(V, row.Cells[10], "V");

                    // Cambiar color de ER 
                    ChangeERColorAndValue(row.Cells[13], row.Cells[14], resultadoER);
                }
            }
        }
        // Mensaje de error si el valor es mayor a 5 
        private void CheckAndHandleError(int value, DataGridViewCell cell, string cellName)
        {
            if (value > 5)
            {
                MessageBox.Show($"Error: El valor en la celda {cellName} es mayor a 6. El número se borrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cell.Value = DBNull.Value;
            }
        }

        private bool IsValidCellValue(DataGridViewCell cell)
        {
            if (int.TryParse(cell.Value?.ToString(), out int value))
            {
                return value >= 1 && value <= 5;
            }
            return false;
        }

        

        private void ChangeCellBackColor(DataGridViewCell cell, int value)
        {
            switch (value)
            {
                case 0:
                    cell.Style.BackColor = Color.White;
                    break;
                case int n when (n <= 2):
                    cell.Style.BackColor = Color.Green;
                    break;
                case int n when (n <= 4):
                    cell.Style.BackColor = Color.Orange;
                    break;
                default:
                    cell.Style.BackColor = Color.Red;
                    break;
            }
        }

        private void ChangeERColorAndValue(DataGridViewCell erCell, DataGridViewCell claseCell, int resultadoER)
        {
            if (resultadoER <= 250)
            {
                erCell.Style.BackColor = Color.Green;
                claseCell.Value = "Muy pequeño";
            }
            else if (resultadoER <= 500)
            {
                erCell.Style.BackColor = Color.Green;
                claseCell.Value = "Pequeño";
            }
            else if (resultadoER <= 750)
            {
                erCell.Style.BackColor = Color.Yellow;
                claseCell.Value = "Normal";
            }
            else if (resultadoER <= 1000)
            {
                erCell.Style.BackColor = Color.Orange;
                claseCell.Value = "Grande";
            }
            else
            {
                erCell.Style.BackColor = Color.Red;
                claseCell.Value = "Elevado";
            }
        }
        // METODO PARA VALIDAR EL DATO DE LAS CELDAS (DATAGRIDVIEW2)//
        
        private void ValidateCellValues()
        {
            DataGridView dataGridView = dataGridView2;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int columnIndex = 5; columnIndex <= 10; columnIndex++)
                {
                    if (row.Cells[columnIndex].Value != null)
                    {
                        if (!int.TryParse(row.Cells[columnIndex].Value.ToString(), out int cellValue))
                        {
                            MessageBox.Show($"Error: El valor en la celda [{row.Index}, {columnIndex}] no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            row.Cells[columnIndex].Value = DBNull.Value;
                        }
                        else
                        {
                            if (cellValue < 0 || cellValue > 5)
                            {
                                MessageBox.Show($"Error: El valor en la celda [{row.Index}, {columnIndex}] debe estar en el rango del 1 al 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                row.Cells[columnIndex].Value = DBNull.Value;
                            }
                        }
                    }
                }
            }
        }
        


        ///******* BOTONES ********///

        private void btn_Guardar1_Click(object sender, EventArgs e)
        {
            SaveDataGridViewData(dataGridView1, dataGrid1Data);
        }

       
        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView3, dataGrid1Data);
            CalcularResultados(dataGridView3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            CalcularResultados(dataGridView2);
            ValidateCellValues();
        }

        private void Btn_abri_Fase4_Click(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView4, dataGrid1Data);
            CalcularResultados(dataGridView4);
        }

        private void btn_Guardar2_Click(object sender, EventArgs e)
        {
            SaveDataGridViewData(dataGridView2, dataGrid1Data);
        }

        private void btn_Abrir1_Click_1(object sender, EventArgs e)
        {
            LoadDataGridViewData(dataGridView2, dataGrid1Data);
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

           

        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           /* DataGridView dataGridView = (DataGridView)sender;

            // Verificar si la celda está en las columnas 5 al 10 del DataGridView 2
            if (e.RowIndex >= 0 && e.ColumnIndex >= 5 && e.ColumnIndex <= 10)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int newValue)) // Verificar si el valor es un número entero
                {
                    dataGridView.Rows[e.RowIndex].ErrorText = "Error: Ingrese un número entero válido.";
                    e.Cancel = true; // Cancelar la edición
                }
                else
                {
                    if (newValue < 1 || newValue > 5)
                    {
                        dataGridView.Rows[e.RowIndex].ErrorText = "Error: El valor debe estar en el rango del 1 al 5.";
                        e.Cancel = true; // Cancelar la edición
                    }
                    else
                    {
                        dataGridView.Rows[e.RowIndex].ErrorText = ""; // Limpiar el mensaje de error
                    }
                }
            }*/
        }
    }
}













