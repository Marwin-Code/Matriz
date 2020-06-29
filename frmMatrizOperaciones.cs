using ExamenBanTrab.Clases;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*   Hecho por:  Marwin Joaquin Vasquez Tejada
         Fecha:  27/06/2020 
   Descripcion:  Pantalla para mostrar matriz y realizar pasos de rutina propuesta                      
 */

namespace ExamenBanTrab
{

    public partial class frmMatrizOperaciones : Form
    {
       //Se declara variable estado para control de pasos de la rutina 
        int estado = 0;
        //se instancia la clase Matriz para uso de esta pantalla
        private Matriz matriz = new Matriz();
       //se instancia la clase Log para guardar log de bitacora y errores
        private Log log = new Log();
          

        public frmMatrizOperaciones()
        {
            InitializeComponent();
        }


        // Carga del formulario crea una matriz de 10 filas x 3 columnas 
        private void frmMatrizOperaciones_Load(object sender, EventArgs e)
        {
            try
            {
                btnInicio.Enabled = false;
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "Matriz de 10 x 3 (filas y columnas)";
               //Se coloca el nombre de encabezado de las columnas
                grdDatos.Columns.Add("1", "Col1");
                grdDatos.Columns.Add("2", "Col2");
                grdDatos.Columns.Add("3", "Col3");

                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.CargaInicial(), 1);
               
                //throw new DivideByZeroException();
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this,"Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion","Error");
                log.GuardarLogError(this,ex);
            }
            
        }

         //metodo que llena el datagrid con la informacion d ela matriz segun su estado  con los parametros
         //MatrizCarga--> Matriz a cargar
         //operacion--> Operacion a realizar segun dimension de la matriz
        private void LlenarMatrizInicial(double[,] MatrizCarga,int operacion)
        {
            try
            {
                //Se limpia el datagrid
                grdDatos.Rows.Clear();
                //Si operacion es 1 carga la matriz de 10 filas x 3 columnas
                if (operacion == 1)
                {
                    for (int i = 0; i < MatrizCarga.GetLength(0); i++)
                    {
                        grdDatos.Rows.Add(new object[] { MatrizCarga[i, 0], MatrizCarga[i, 1], MatrizCarga[i, 2] });
                    }
                }
                //Si operacion es 2 carga la matriz de 12 filas x 4 columnas
                if (operacion == 2)
                {
                    for (int i = 0; i < MatrizCarga.GetLength(0); i++)
                    {
                        grdDatos.Rows.Add(new object[] { MatrizCarga[i, 0], MatrizCarga[i, 1], MatrizCarga[i, 2], MatrizCarga[i, 3] });
                    }
                }
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }

        }

        //Metodo que controla el boton siguiente, segun el estado realiza la operacion
        private void btnOperacion_Click(object sender, EventArgs e)
        {

            try
            {
                switch (estado)
                {
                    case 0:
                        //Realizar la operacion de estado 0
                        EstadoCero();
                        break;
                    case 1:
                        //Realizar la operacion de estado 1
                        EstadoUno();
                        break;
                    case 2:
                        //Realizar la operacion de estado 2
                        EstadoDos();
                        break;
                    case 3:
                        //Realizar la operacion de estado 3
                        EstadoTres();
                        break;
                    case 4:
                        //Realizar la operacion de estado 4
                        EstadoCuatro();
                        break;
                    case 5:
                        //Realizar la operacion de estado 5
                        EstadoCinco();
                        break;
                    case 6:
                        //Realizar la operacion de estado 6
                        EstadoSeis();
                        break;
                    case 7:
                        //Realizar la operacion de estado 7
                        EstadoSiete();
                        break;
                    case 8:
                        //Realizar la operacion de estado 8
                        EstadoOcho();
                        break;
                    case 9:
                        //Realizar la operacion de estado 9
                        EstadoNueve();
                        break;
                    case 10:
                        //Realizar la operacion de estado 10
                        EstadoDiez();
                        break;
                    default:
                        break;
                }
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
        }

        //Metodo que realiza la operacion de estado 0 segun el requerimiento de la rutina de la matriz.
        private void EstadoCero()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Agregar datos predeterminados a las columnas 1 y 2 \r\n*Mostrar la matriz con los datos";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.AgregaDatos(), 1);
                //Manipula colores de columnas segun estado
                grdDatos.Columns[0].DefaultCellStyle.BackColor = Color.Red;
                grdDatos.Columns[1].DefaultCellStyle.BackColor = Color.Red;

                //Se establece el estado a 1
                estado = 1;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
           
        }

        //Metodo que realiza la operacion de estado 1 segun el requerimiento de la rutina de la matriz.
        private void EstadoUno()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Llenar la columna 3 con la suma de las columnas 1 y 2";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.SumarColumnas1y2(), 1);
                //Manipula colores de columnas segun estado
                grdDatos.Columns[0].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Columns[1].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Columns[2].DefaultCellStyle.BackColor = Color.Red;
                //Se establece el estado a 2
                estado = 2;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 2 segun el requerimiento de la rutina de la matriz.
        private void EstadoDos()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Calcular el total de la columna 3 en la variable 'total'\r\n*Mostrar la variable 'total'";               
                //Coloca la suma de columna 3 en el campo txtTotal
                txtTotal.Text = matriz.SumaColumna3().ToString();
                txtTotal.BackColor = Color.Red;
                grdDatos.Columns[2].DefaultCellStyle.BackColor = Color.White;
                //Se establece el estado a 3
                estado = 3;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
           
        }

        //Metodo que realiza la operacion de estado 3 segun el requerimiento de la rutina de la matriz.
        private void EstadoTres()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*crear dos filas (vacías)\r\n*crear una columna nueva (vacía)\r\n*mostrar la matriz redimensionada";
               //Coloca el nombre 4 a la nueva columna
                grdDatos.Columns.Add("4", "Col4");
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.AgregaFilasColumnas(), 2);
                //Manipula colores de objetos segun estado
                txtTotal.BackColor = Color.White;
                grdDatos.Columns[0].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Columns[1].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Columns[2].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Columns[3].DefaultCellStyle.BackColor = Color.Red;
                grdDatos.Rows[10].DefaultCellStyle.BackColor = Color.Red;
                grdDatos.Rows[11].DefaultCellStyle.BackColor = Color.Red;
                //Se establece el estado a 4
                estado = 4;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 4 segun el requerimiento de la rutina de la matriz.
        private void EstadoCuatro()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Trasladar los valores de las [filas 1 y 2] [columna 1] hacia las filas nuevas";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.TrasladarValores(), 2);
                
                grdDatos.Columns[3].DefaultCellStyle.BackColor = Color.White;
                grdDatos.Rows[0].Cells[0].Style.BackColor = Color.Orange;
                grdDatos.Rows[1].Cells[0].Style.BackColor = Color.Orange;
                grdDatos.Rows[10].Cells[0].Style.BackColor = Color.Red;
                grdDatos.Rows[11].Cells[0].Style.BackColor = Color.Red;

                //Se establece el estado a 5
                estado = 5;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 5 segun el requerimiento de la rutina de la matriz.
        private void EstadoCinco()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Calcular el total de las [filas 1 y 2] [columna 2]";
                //Coloca el total de las filas 1 y2 y columna 2 en txtFila
                txtFila.Text = matriz.CalcularTotal().ToString();
                txtFila.BackColor = Color.Red;

                grdDatos.Rows[0].Cells[0].Style.BackColor = Color.White;
                grdDatos.Rows[1].Cells[0].Style.BackColor = Color.White;
                grdDatos.Rows[10].Cells[0].Style.BackColor = Color.White;
                grdDatos.Rows[11].Cells[0].Style.BackColor = Color.White;
                //Se establece el estado a 6
                estado = 6;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 6 segun el requerimiento de la rutina de la matriz.
        private void EstadoSeis()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Eliminar los valores de las [filas 1 y 2] [columna 2]";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.EliminarValores(), 2);

                grdDatos.Rows[0].Cells[1].Style.BackColor = Color.Red;
                grdDatos.Rows[1].Cells[1].Style.BackColor = Color.Red;
                txtFila.BackColor = Color.White;
                //Se establece el estado a 7
                estado = 7;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 7 segun el requerimiento de la rutina de la matriz.
        private void EstadoSiete()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Dividir el total del inciso anterior y colocar en partes iguales en las [filas 3 a 7][columna 4";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.DividirValores(), 2);

                grdDatos.Rows[0].Cells[1].Style.BackColor = Color.White;
                grdDatos.Rows[1].Cells[1].Style.BackColor = Color.White;
                grdDatos.Rows[2].Cells[3].Style.BackColor = Color.Red;
                grdDatos.Rows[3].Cells[3].Style.BackColor = Color.Red;
                grdDatos.Rows[4].Cells[3].Style.BackColor = Color.Red;
                grdDatos.Rows[5].Cells[3].Style.BackColor = Color.Red;


                //Se establece el estado a 8
                estado = 8;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 8 segun el requerimiento de la rutina de la matriz.
        private void EstadoOcho()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Llenar la columna 3 con la suma de las columnas 1, 2 y 4";
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.SumarColumnas1y2y4(), 2);

                grdDatos.Rows[2].Cells[3].Style.BackColor = Color.White;
                grdDatos.Rows[3].Cells[3].Style.BackColor = Color.White;
                grdDatos.Rows[4].Cells[3].Style.BackColor = Color.White;
                grdDatos.Rows[5].Cells[3].Style.BackColor = Color.White;
                grdDatos.Columns[2].DefaultCellStyle.BackColor = Color.Red;

                //Se establece el estado a 9
                estado = 9;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 9 segun el requerimiento de la rutina de la matriz.
        private void EstadoNueve()
        {
            try
            {
                //Desplega descripcion de la operacion que se esta haciendo
                txtNotificacion.Text = "*Calcular el total de la columna 3 en la variable 'total'\r\n*Mostrar la variable 'total'\r\n*Mostrar la matriz con los datos";
                //Coloca la suma de la columna 3 en txtTotal
                txtTotal.Text = matriz.SumaColumna3().ToString();
                //Se carga el datagrid con la informacion de la matriz
                LlenarMatrizInicial(matriz.CargarMatriz(), 2);

                txtTotal.BackColor = Color.Red;
                grdDatos.Columns[2].DefaultCellStyle.BackColor = Color.White;
                //Se establece el estado a 10
                estado = 10;
                //Se guarda en bitacora la operacion realizada
                log.GuardarBitacora(this, "Proceso Exitoso");
            }
            catch (Exception ex)
            {
                //Muestra en pantalla que dio error la aplicacion y guarda log de error
                MessageBox.Show("Ocurrio un error en la apliacion", "Error");
                log.GuardarLogError(this, ex);
            }
            
        }

        //Metodo que realiza la operacion de estado 10 segun el requerimiento de la rutina de la matriz.
        private void EstadoDiez()
        {
            //Desplega descripcion de la operacion que se esta haciendo
            txtTotal.BackColor = Color.White;
            txtNotificacion.Text = "*FIN DE RUTINA SOLICITADA";
            btnInicio.Enabled = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            matriz.ReinicioMatriz();
            grdDatos.Rows.Clear();
            grdDatos.Columns.Clear();
            grdDatos.DataSource = null;
            txtFila.BackColor = Color.White;
            txtTotal.BackColor = Color.White;
            txtFila.Text = "";
            txtTotal.Text = "";
            estado = 0;
            frmMatrizOperaciones_Load(sender, e);
        }
    }
}
