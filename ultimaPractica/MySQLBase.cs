using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace ultimaPractica
{
	public class MySQLBase
	{
		public MySqlConnection myConnection;
		public MySQLBase ()
		{
		}

		public void abrirConexion(){
			string connectionString =
          		"Server=127.0.0.1;" +
	          	"Database=escuela;" +
	          	"User ID=root;" +
	          	"Password=daniela19;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
	       
		}

		public void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
	//Cervantes Acosta Daniela Codigo: 213266778
}

