using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenBanTrab.Clases
{
    class Matriz
    {
       //Variable para guardar suma de variables que se eliminan
        double sumaEliminado;
        //Se declara la variable matriz
        private double[,] matriz;
      
        //Funcion que carga Matriz sin modificaciones
        public double[,] CargarMatriz()
        {
            return matriz;
        }

        //Funcion que carga Matriz y la dimensiona a 10 filas x 3 columnas
        public double[,] CargaInicial()
        {
            //throw new DivideByZeroException();
            matriz = new double[10, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }
            return matriz;
        }

        //Funcion que carga Matriz y llena las columnas 1 y 2 con valores aleatorios entre 1 y 100 
        public double[,] AgregaDatos()
        {
            Random rand = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz[i, j] = rand.Next(0, 100);
                }
            }
            return matriz;
        }

        //Funcion que carga Matriz y suma las columnas 1 y 2 y pone el total de la suma en la columna 3 
        public double[,] SumarColumnas1y2()
        {

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] + matriz[i, 1];
            }
            return matriz;
        }

        //Funcion que suma los valores de la columna 3 de la matriz
        public double SumaColumna3()
        {

            double suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                suma = suma + matriz[i, 2];
            }
            return suma;
        }

        //Funcion que carga Matriz sacando una copia y redimensiona la matriz a 12 columnas y 4 columnas
        public double[,] AgregaFilasColumnas()
        {

            double[,] matrizCopia = matriz; ;

            matriz = new double[12, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j < 3 && i < 10)
                    {
                        matriz[i, j] = matrizCopia[i, j];
                    }
                    else
                    {
                        //matriz[i, j] = 0;
                    }
                }
            }
            return matriz;
        }

        //Funcion que traslada los valores de filas 1 y 2 de la columna 1 hacia filas 11 y 12 de la columna 1
        public double[,] TrasladarValores()
        {
            matriz[10, 0] = matriz[0, 0];
            matriz[11, 0] = matriz[1, 0];
            return matriz;
        }

        //Funcion que calcula la suma de las filas 1 y 2 de la columna 2 
        public double CalcularTotal()
        {

            double suma = 0;

            suma = matriz[0, 0] + matriz[1, 0];
            return suma;
        }

        //Funcion que carga Matriz y elimina los valores de las filas 1 y 2 de la columna 2
        public double[,] EliminarValores()
        {
            sumaEliminado = matriz[0, 1] + matriz[1, 1];
            matriz[0, 1] = 0;
            matriz[1, 1] = 0;
            return matriz;
        }

        //Funcion que carga Matriz y divide la suma de las filas 1 y 2 de la columna 2 entre 4
        //el resultado se coloca en partes iguales en las filas 3 a 7 de la columna 4
        public double[,] DividirValores()
        {
            double division = 0;
            division = sumaEliminado / 4;
            matriz[2, 3] = division;
            matriz[3, 3] = division;
            matriz[4, 3] = division;
            matriz[5, 3] = division;
            return matriz;
        }

        //Funcion que carga Matriz y realiza la suma de columna q,2 y4 y lo coloca en la columna 3
        public double[,] SumarColumnas1y2y4()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 2] = matriz[i, 0] + matriz[i, 1] + matriz[i, 3]; ;
            }
            return matriz;
        }

        //Funcion que carga Matriz sin modificaciones
        public double[,] ReinicioMatriz()
        {
            matriz = null;
            return matriz;
        }

    }
}
