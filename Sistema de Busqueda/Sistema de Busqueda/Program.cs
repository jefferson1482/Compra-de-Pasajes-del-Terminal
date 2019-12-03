using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Busqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            String Opcion;
            do
            {
                Console.WriteLine(" \n");
                Console.Write("     T E R M I N A L  T E R R E S T R E  M A N T A");
                Console.WriteLine("  ");
                Console.WriteLine("  ");
                Console.Write("     ************** MENÚ DE OPCIONES **************");
                Console.WriteLine("  ");
                Console.Write("             1) COMPRA DE BOLETOS");
                Console.WriteLine("  ");
                Console.Write("             2) ENCOMIENDAS");
                Console.WriteLine("  ");
                Console.Write("             3) CONTACTANOS");
                Console.WriteLine("  ");
                Console.Write("     **********************************************");
                Console.WriteLine("  ");
                Console.WriteLine("     Si desea salir Preione 4 ");
                Console.WriteLine(" \n");
                Console.Write("             Ingrese Opción a Realizar: ");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Creamos el objeto de tipo estructura

                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" \n");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine("     ******************* I N G R E S A R ******************");
                            Console.WriteLine("     ************ Registro de Compra de Boleto ************");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine(" \n");
                            Console.Write("    DESTINO: ");

                            Console.Write("     TIPO DE BUS ");

                            Console.Write("     NUMERO DE ASIENTOS: ");

                            Console.Write("     CANTIDAD: ");

                            Console.Write("     HORA: ");
                            Console.WriteLine(" \n");
                            Console.Write("     Desea Comprar otro boleto? (s / n): ");
                            Opcion = Console.ReadLine();
                        }
                        while (Opcion == "S" || Opcion == "s");
                        Console.Clear();
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" \n");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine("     **************** I N F O R M A C I Ó N ***************");
                            Console.WriteLine("     ********** Servicio en Linea de Encomiendas **********");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine(" \n");
                            Console.Write("    Nombre: ");

                            Console.Write("     Descripcion: ");

                            Console.Write("     Destinatario: ");
                            Console.WriteLine(" \n");
                            Console.Write("     Desea salir ==> (s / n): ");
                            Opcion = Console.ReadLine();
                        }
                        while (Opcion == "N" || Opcion == "n");
                        Console.Clear();
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" \n");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine("     **************** C O N T A C T A N O S ***************");
                            Console.WriteLine("     **************  Informacion de la empres  ************");
                            Console.WriteLine("     ******************************************************");
                            Console.WriteLine(" \n");
                            Console.Write("    Nombre: ");

                            Console.Write("     Direccion: ");

                            Console.Write("     Numero Telefonico: ");

                            Console.Write("     Descripcion: ");
                            Console.WriteLine(" \n");
                            Console.Write("     Desea salir ==> (s/n): ");
                            Opcion = Console.ReadLine();
                        }
                        while (Opcion == "N" || Opcion == "n");
                        Console.Clear();

                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (op != 6);
            Console.ReadKey();
        }
    }
}
