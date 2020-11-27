using System;

namespace AP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta();
            Console.WriteLine("Presione enter 2 veces para salir");
            Console.ReadLine();
        }


        public static void OfrecerVehiculo() //Método para no andar escribiendo todo este código en cada IF
        {
            var opcion2 = "";
            Console.WriteLine("¿Quiere comprar este vehículo?");
            Console.WriteLine("Responda con 's' o 'n'");
            opcion2 = Console.ReadLine();
            if (opcion2 == "s")
            {
                RealizarVenta();
            }
            else
            {
                Console.WriteLine("¿Le ofrecemos un vehículo más económico?");
                Console.WriteLine("Responda con 's' o 'n'");
                opcion2 = Console.ReadLine();
                if (opcion2 == "s")
                {
                    Console.WriteLine("Entonces le presentamos este modelo que es más económico");
                    Console.WriteLine("¿Quiere comprarlo?");
                    opcion2 = Console.ReadLine();
                    if(opcion2 == "s")
                    {
                        RealizarVenta();
                    }
                    else
                    {
                        Console.WriteLine("Déjenos sus datos en la administración que cuando haya otro vehículo más económico nos estaremos comunicando. ¡Gracias!");
                        SalirONo();
                        return;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Gracias por su visita :(");
                    SalirONo();
                    return;
                    
                }
            }
        }

        public static void RealizarVenta() //Método para imprimir y realizar la venta
        {
            Console.WriteLine("¡Muchas gracias por su compra!");
            SalirONo();
            return;
        }

        public static void Venta()
        {
            var opcion = "";
            Console.WriteLine("¡Bienvenido al local!");
            //Console.WriteLine("¿Qué vehículo es de su interés?");
            Console.WriteLine("Las siguientes preguntas nos van a guiar a buscar el vehículo que le interese");
            Console.WriteLine("¿No viaja mucho al centro y tampoco le interesa vehículos para campo, montaña o rodados grandes?");
            Console.WriteLine("Responda solo con 's' o 'n'");
            //Hasta ahí solo preguntas.
            opcion = Console.ReadLine(); //Para que la variable tome el valor de lo que ingrese el usuario 
            if (opcion == "s")
            {

                Console.WriteLine("Entonces le ofrecemos una motocicleta");
                OfrecerVehiculo();

            }
            else if (opcion == "n")
            {
                Console.WriteLine("¿Busca viajar por la ciudad?");
                var opcion3 = "";
                opcion3 = Console.ReadLine();
                if (opcion3 == "s")
                {
                    Console.WriteLine("Entonces le ofrecemos un auto");
                    OfrecerVehiculo();
                }
                else
                {
                    Console.WriteLine("¿Busca un rodado para campo o montaña?");
                    var opcion4 = "";
                    opcion4 = Console.ReadLine();
                    if (opcion4 == "s")
                    {
                        Console.WriteLine("Entonces le ofrecemos un cuatriciclo");
                        OfrecerVehiculo();
                    }
                    else
                    {
                        Console.WriteLine("¿Busca un rodado grande?");
                        var opcion5 = "";
                        opcion5 = Console.ReadLine();
                        if (opcion5 == "s")
                        {
                            Console.WriteLine("Entonces le ofrecemos una camioneta");
                            OfrecerVehiculo();
                        }
                        else
                        {
                            Console.WriteLine("No hay más para ofrecerle :v");
                            SalirONo();
                        }
                    }
                }
            }
        }
        public static void SalirONo()
        {
            Console.WriteLine("¿Querés salir del programa (n) o seguir jugando (s)? :v");
            var opcion = "";
            opcion = Console.ReadLine();
            if (opcion == "s")
            {
                Venta();
            }
            else
            {
                Console.WriteLine("Vaya a hacer sus cosas mijo");
                return;
            }
        }

    }
}
