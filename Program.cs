// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Linq.Expressions;

int menu = 0;
Console.WriteLine("Bienvenido al sistema academico\n");
do
{
   
	try	{
        Console.WriteLine("Selecccione de las siguientes opciones:\n1-Iniciar Vectores\n2-Incluir estudiantes\n3-Consultar Estudiantes\n4-Modificar Estudiantes\n5-Eliminar Estudiantes\n6-Submenu Reportes\n7-Salir");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case 1:
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
                break;
            case 7:
                Console.WriteLine("Saliendo del Sistema\nMi primera chamba!!");
                break;
            default:
                Console.WriteLine("Opcion Invalida\nIntente de nuevo\n");
                break;
        }
    }
	catch (FormatException letra)
	{
        Console.Clear();
        Console.WriteLine("No se admiten letras\nIntente de nuevo\n");
        
    }
} while (menu != 7);
