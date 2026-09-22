using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Esta libreria es para usar bases de datos
using System.Data.SqlClient; //Esta libreria permite usar SQLSever

namespace Tabla_de_meses_acumulados
{
    class conexion {
        //Definir los niembro, atributo y metodos de la clase 
        public SqlConnection objConexion = new SqlConnection(); //conectrme a la BD
        public SqlConnection objComando = new SqlConnection(); //Ejucutar consultas (Insert, uddate, delete, select) SQL en la BD
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter(); //un puente entre la la DB y la apicacion.
        DataSet objDs = new DataSet(); //Representa ua copiaen memoria de la arquitectura BD

        public Conexion() { //Contructor e inicializador de los niembros de la clase 
            String cadenaCoenxion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaCoenxion;
            objConexion.Open(); //abrir la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el datase.
            objComando.Connection = objConexion;//Establcer la conexion para ejecutar consultas a la BD

            objDataAdapter.SelectCommand = objComando;
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos"); //tomamos los datos de la BD y llenamos el ds

            return objDs;
        }
