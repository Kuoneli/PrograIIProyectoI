

int[] cedula = new int [10], promedio = new int[10];
string[] nombre = new string [10], condicion= new string[10];

int menu = 0, posicion = 1;
Console.WriteLine("Bienvenido al sistema academico\n");

do
{
    Console.Clear();
    try	{
        Console.WriteLine("Selecccione de las siguientes opciones:\n1-Iniciar Vectores\n2-Incluir estudiantes\n3-Consultar Estudiantes\n4-Modificar Estudiantes\n5-Eliminar Estudiantes\n6-Submenu Reportes\n7-Salir");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case 1:
                InicializarVectores();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                do
                {
                    try
                    {
                        Console.WriteLine("Seleccione de las siguientes opcines de Reportes\n1-Estudiantes por Condiciones\n2-Todos los Datos\n3-Regresar a menu principal.");
                        menu = int.Parse(Console.ReadLine());
                        if (menu == 1)
                        {
                            Console.WriteLine("Estudiante\n1-Aprobados\n2-Reprobados\n3-Aplazados\n");
                            MostrarDatosPorCondicion();
                        }
                        else if (menu == 2)
                        {
                            MostrarTodosLosDatos();
                        }
                        else if (menu == 3)
                        {
                            Console.WriteLine("Regrasando al menu principal\n");
                        }
                        else
                        {
                            Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
                    }
                } while (menu != 3);
                break;
            case 7:
                Console.WriteLine("Saliendo del Sistema\nMi primera chamba!!");
                break;
            default:
                Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
                break;
        }
    }
	catch (FormatException) { 
	
        Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
        
    }
} while (menu != 7);

void InicializarVectores()
{
    cedula = Enumerable.Repeat(0, cedula.Length).ToArray();
    promedio = Enumerable.Repeat(0, promedio.Length).ToArray();
    nombre = Enumerable.Repeat("n/a", nombre.Length).ToArray();
    condicion = Enumerable.Repeat("n/a", condicion.Length).ToArray();
    Console.WriteLine($"Variable Inicializadas\n Presione \"ENTER\" para volver al menu principal");
    Console.ReadLine(); 
}

void MostrarDatosPorCondicion()
{

}
void MostrarTodosLosDatos()
{
    string sumacedula = "";
    Console.WriteLine("Cedula    Nombre    Promedio    Condicion\n=========================================================================\n");
    for (int x = 0;  x < nombre.Length; x++) {

        Console.WriteLine($"{cedula[x]}           {nombre[x]}        {promedio[x]}          {condicion[x]}");

    }
    Console.WriteLine("=========================================================================\r\n\n");

}