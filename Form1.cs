using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExamenBanTrab
{
    public partial class frmMatriz : Form
    {
        int estado;
        double sumaEliminado = 0;
        public double[,] matriz;
        //matriz = new int[10, 3];


        public frmMatriz()
        {
            InitializeComponent();
            
        }

        private void frmMatriz_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Matriz de 10 x 3 (filas y columnas)";
            LlenarMatriz();
            estado = 0;
            
        }

        public void LlenarMatriz()
        {

            matriz = new double[10, 3];
            
            grdMatriz.Columns.Add("1", "1");
            grdMatriz.Columns.Add("2", "2");
            grdMatriz.Columns.Add("3", "3");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2]
                 });
            }
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            switch (estado)
            {
                case 0:
                    lblAyuda.Text = estado.ToString();
                    EstadoCero();
                    break;
                case 1:
                    lblAyuda.Text = estado.ToString();
                    EstadoUno();
                    break;
                case 2:
                    lblAyuda.Text = estado.ToString();
                    EstadoDos();
                    break;
                case 3:
                    lblAyuda.Text = estado.ToString();
                    EstadoTres();
                    break;
                case 4:
                    lblAyuda.Text = estado.ToString();
                    EstadoCuatro();
                    break;
                case 5:
                    lblAyuda.Text = estado.ToString();
                    EstadoCinco();
                    break;
                case 6:
                    lblAyuda.Text = estado.ToString();
                    EstadoSeis();
                    break;
                case 7:
                    lblAyuda.Text = estado.ToString();
                    EstadoSiete();
                    break;
                case 8:
                    lblAyuda.Text = estado.ToString();
                    EstadoOcho();
                    break;
                case 9:
                    lblAyuda.Text = estado.ToString();
                    EstadoNueve();
                    break;
                case 10:
                    lblAyuda.Text = estado.ToString();                   
                    break;
            }
        }

        private void EstadoCero()
        {
            lblTitulo.Text = "Agregar datos predeterminados a las columnas 1 y 2";

            Random rand = new Random();


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz[i, j] = rand.Next(0,100); 
                }
            }


            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], 0});
            }
            estado = 1;
        }

        private void EstadoUno()
        {
            lblTitulo.Text = "Llenar la columna 3 con la suma de las columnas 1 y 2";

           

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                    matriz[i, 2] = matriz[i, 0] + matriz[i, 1];
            }

            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2]
                 });
            }
            estado = 2;
        }

        private void EstadoDos()
        {
            lblTitulo.Text = "Calcular el total de la columna 3 en la variable 'total'";
            double suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma = suma + matriz[i, 2]; 
            }

            txtValor.Text = suma.ToString();
            estado = 3;
        }

        private void EstadoTres()
        {
            lblTitulo.Text = "Mostrar la matriz redimensionada";
            double[,] matrizCopia= matriz; ;
           
            matriz = new double[12, 4];
            // matriz = matrizCopia;

            txtMatrizC.Text = matriz.GetLength(0).ToString();
            aux1.Text = matriz.GetLength(1).ToString();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                   if (j<3 && i<10) 
                    {
                        matriz[i, j] = matrizCopia[i, j];
                    }
                    else
                    {
                        //matriz[i, j] = 0;
                    }
                    
                }
            }

            grdMatriz.Columns.Add("4", "4");
            


            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 4;

        }

        private void EstadoCuatro()
        {

            lblTitulo.Text = "Trasladar los valores de las [filas 1 y 2] [columna 1] hacia las filas nuevas";
            matriz[10, 0] = matriz[0, 0];
            matriz[11, 0] = matriz[1, 0];
            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 5;
        }

        private void EstadoCinco()
        {
            lblTitulo.Text = "Calcular el total de las [filas 1 y 2] [columna 2]";

            double suma = 0;

            suma = matriz[0, 0] + matriz[1, 0];



            txtTotal2.Text = suma.ToString();
            estado = 6;
        }

        private void EstadoSeis()
        {

            lblTitulo.Text = "Eliminar los valores de las[filas 1 y 2][columna 2]"; 
            sumaEliminado = matriz[0, 1] + matriz[1, 1];
            matriz[0, 1] = 0;
            matriz[1, 1] = 0;

            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 7;
        }

        private void EstadoSiete()
        {
            lblTitulo.Text = "Dividir el total del inciso anterior y colocar en partes iguales en las [filas 3 a 7][columna 4";
            double division = 0;
            division = sumaEliminado / 4;
            matriz[2, 3] = division;
            matriz[3, 3] = division;
            matriz[4, 3] = division;
            matriz[5, 3] = division;

            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 8;
        }

        private void EstadoOcho()
        {
            lblTitulo.Text = "Llenar la columna 3 con la suma de las columnas 1, 2 y 4";

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] + matriz[i, 1] + matriz[i, 3]; ;
            }

            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 9;
        }

        private void EstadoNueve()
        {
            lblTitulo.Text = "Mostrar la variable 'total'";
            double suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma = suma + matriz[i, 2];
            }

            aux1.Text = suma.ToString();
            grdMatriz.Rows.Clear();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                grdMatriz.Rows.Add(new object[] { matriz[i, 0], matriz[i, 1], matriz[i, 2],matriz[i, 3]
                 });
            }
            estado = 10;

        }

    }
}
