using System;

namespace deber
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            Console.WriteLine("Bienvenido ingresa tus nombres: ");
            string nombres = Console.ReadLine();
            Console.WriteLine(" ingresa tus apellidos:");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Hola" + nombres + apellidos + "Ingresa tu numero de cedula:");
            string cedula = Console.ReadLine();
            Console.WriteLine("tus nombres son:" + nombres );
            Console.WriteLine("tus apellidos son:" + apellidos);
            Console.WriteLine ("tu cedula es:" + cedula );
        }
    }
}
