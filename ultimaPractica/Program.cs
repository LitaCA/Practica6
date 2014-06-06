using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace ultimaPractica
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion = 5;
			
			do
				{

				Console.WriteLine("\t MENU \n");
				Console.WriteLine("1.- Ver\n2.- Agregar");
				Console.WriteLine("3.- Editar\n4.- Eliminar");
				Console.WriteLine("5.- Salir\n");
				
				Console.WriteLine("Ingresa la opción deseada: ");
				
				opcion = int.Parse(Console.ReadLine());
				Profesor profe = new Profesor();

				switch(opcion)
				{
						case 1:
									Console.Write(" \tVER \n");
									profe.mostrarTodos();
									break;

						case 2:
									Console.Write(" \tAGREGAR \n");
									Console.WriteLine("Ingresa el código: ");
									String codigo = Console.ReadLine();
									Console.WriteLine("Ingresa el nombre: ");
									String nombre = Console.ReadLine();
									profe.insertarRegistroNuevo(codigo, nombre);

									break;

						case 3:
									Console.Write(" \tEDITAR \n");
									Console.WriteLine("Ingresa el ID de registro: ");
									string id = Console.ReadLine();


									if(profe.Buscarid(id))
									{
										Console.WriteLine("ID, Nombre ");
										Console.WriteLine("¿Seguro que desea editar esos datos? \nS/N ");
										string resp = Console.ReadLine();
										if(resp == "s")
										{
											Console.WriteLine("Ingresa el nuevo ID: ");
											codigo = Console.ReadLine();
											Console.WriteLine("Ingresa el nuevo nombre: ");
											nombre = Console.ReadLine();
											profe.editarNombreRegistro(id, nombre);						
										}
									}
									else {
										Console.WriteLine( "El ID no existe");
										Console.ReadLine();
									}
									break;

						case 4:
									Console.Write(" \tELIMINAR \n");
									Console.WriteLine("Ingresa el ID de registro: ");
									id = Console.ReadLine();
									if(profe.Buscarid(id))
									{

										Console.WriteLine("¿Seguro que desea eliminar? \nS/N ");
										string respue = Console.ReadLine();
										if(respue == "s")
											profe.eliminarRegistroPorId(id);
									}
									else {
										Console.WriteLine( "No existe");
										Console.ReadLine();
									}
									break;

						case 5:
									break;

				}
					Console.WriteLine("\nPresiona una tecla para continuar ");
					Console.ReadLine();
			}
				while(opcion < 5);
		}
	}
		//Cervantes Acosta Daniela Codigo: 213266778
}
