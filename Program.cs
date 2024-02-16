
//Variables
using System.Diagnostics;
using System.Diagnostics.Contracts;

int[] cedula = new int[10], promedio = new int[10];
string[] nombre = new string[10], condicion = new string[10];
int menu = 0, seleccion = 0, contador=0;
bool error = false;

//Menu
Console.WriteLine("Bienvenido al sistema academico\n");
do
{
    Console.Clear();
    try
    {
        Console.WriteLine("Selecccione de las siguientes opciones:\n1-Iniciar Vectores\n2-Incluir estudiantes\n3-Consultar Estudiantes\n4-Modificar Estudiantes\n5-Eliminar Estudiantes\n6-Submenu Reportes\n7-Salir");
        menu = int.Parse(Console.ReadLine());
        switch (menu)
        {
            case 1:
                InicializarVectores();
                break;
            case 2:
                IncluirEstudiantes();
                break;
            case 3:
                ConsultarEstudiantes();
                break;
            case 4:
                ModificarEstudiante();
                break;
            case 5:
                EliminarEstudiantes();
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
    catch (FormatException)
    {

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
    contador = 0;
    Console.ReadKey();
}

void MostrarDatosPorCondicion()
{
    try
    {
        Console.WriteLine("Seleccione la condición respectiva a los datos de los estudiantes.\n1 - Estudiantes Aprobados\n2 - Estudiantes Reprobados");
        int SelectCondiDatos = 0;
        SelectCondiDatos = int.Parse(Console.ReadLine());

        switch (SelectCondiDatos)
        {
            case 1:
                Console.WriteLine("Cédula    Nombre    Condición\n=========================================================================\n");
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (condicion[i] == "APROBADO")
                    {
                        Console.WriteLine($"{cedula[i]}        {nombre[i]}           {promedio[i]}      {condicion[i]}");
                    }
                }
                break;
            case 2:
                Console.WriteLine("Cédula    Nombre    Condición\n=========================================================================\n");
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (condicion[i] == "REPROBADO")
                    {
                        Console.WriteLine($"{cedula[i]}        {nombre[i]}           {promedio[i]}      {condicion[i]}");
                    }
                }
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Se ingresó un dato incorrecto. Inténtelo de nuevo.");
    }

}
void MostrarTodosLosDatos()
{
    string sumacedula = "";
    Console.WriteLine("Cedula    Nombre    Promedio    Condicion\n=========================================================================\n");
    for (int x = 0; x < nombre.Length; x++)
    {

        Console.WriteLine($"{cedula[x]}        {nombre[x]}           {promedio[x]}      {condicion[x]}");

    }
    Console.WriteLine("=========================================================================\r\n\n");

}
void IncluirEstudiantes()
{
    /*How can i improve the below code*/
    Console.WriteLine("Digite la cantidad de estudiantes a ingresar: ");
    seleccion = Convert.ToInt32(Console.ReadLine());
    for (int x = 0; x < seleccion; x++)
    {

        do
        {
            try
            {
                Console.WriteLine("Ingrese la cedula del estudiantes: ");
                cedula[contador] = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("No se valen letras, pongase serio\n");
                error = true;
            }

        } while (error == true);

        do
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre[contador] = Console.ReadLine();
                error = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("No se valen numero, pongase serio\n");
                error = true;
            }

        } while (error == true);

        do
        {
            try
            {
                Console.WriteLine("Ingrese el promedio del estudiante: ");
                promedio[contador] = Convert.ToInt32(Console.ReadLine());
                if (promedio[contador] >= 70) 
                {
                    Console.WriteLine("Condicion: APROBADO");
                    condicion[contador] = "APROBADO";
                }
                else
                {
                    Console.WriteLine("Condicion:REPROBADO");
                    condicion[contador] = "REPROBADO";
                }
                Console.ReadKey();
                error = false;
            }
            catch (Exception)
            {
                Console.WriteLine("Favor no utilizar letras\n");
                error = true;
            }
            contador++;
        } while (error == true);
    }

}
void ConsultarEstudiantes()
{
    MostrarTodosLosDatos();
    Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
    Console.ReadKey();
}
void ModificarEstudiante()
{
    Console.WriteLine("Ingrese el número de cédula del estudiante a modificar:");
    int cedulaModificar = Convert.ToInt32(Console.ReadLine());

    // Buscar el estudiante por cedula
    int indice = Array.IndexOf(cedula, cedulaModificar);

    if (indice != -1)
    {
        Console.WriteLine("Ingrese el nuevo nombre del estudiante:");
        nombre[indice] = Console.ReadLine();

        Console.WriteLine("Ingrese el nuevo promedio del estudiante:");
        promedio[indice] = Convert.ToInt32(Console.ReadLine());

        if (promedio[indice] >= 70)
            condicion[indice] = "APROBADO";
        else
            condicion[indice] = "REPROBADO";

        Console.WriteLine("Estudiante modificado correctamente.");
    }
    else
    {
        Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
    }

    Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
    Console.ReadKey();
}
void EliminarEstudiantes()
{
    Console.WriteLine("Ingrese el número de cédula del estudiante a eliminar:");
    int cedulaEliminar = Convert.ToInt32(Console.ReadLine());

    // Buscar el estudiante por su número de cédula
    int indice = Array.IndexOf(cedula, cedulaEliminar);

    if (indice != -1)
    {
        // Eliminar el estudiante
        cedula[indice] = 0;
        nombre[indice] = "n/a";
        promedio[indice] = 0;
        condicion[indice] = "n/a";

        Console.WriteLine("Estudiante eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("No se encontró ningún estudiante con esa cédula.");
    }

    Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
    Console.ReadKey();
}
