//Primer parcial Cajero automatico FPD
using System;


namespace Examenparcial 
{
    class Program
    {
        static void Main(string[] args)
        {
            int Retiro, Transaccion, Numerocuenta;
            int billetesmil = 1000;
            int billetesquinientos = 500;
            int billetesdoscientos = 200;
            int billetescien = 100;
            int OP1, OP2, OP3, OP4;
            int limiteRetiro = 20000, LimiteTransaccion = 10000;
            string enter = "";

            Console.WriteLine("......................................");
            Console.WriteLine("Bienvenido/a al Cajero FDP INVERSMENTS");
            Console.WriteLine("......................................");
            Console.WriteLine("");
            Console.WriteLine("1- Para ingresar al menu de opciones. \n"/* + "2- Ver la cantidad de billetes disponibles \n"*/ + "0- Salir \n");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == 1 || B == 2 || B == 3)
            {

                Console.WriteLine("Seleccione la opcion segun su necesidad");
                Console.WriteLine("1- Transaccion. \n" + "2- Retiro. \n" + "3- Salir. \n");

            int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el Monto, Sin exceder del limite de: {0}", LimiteTransaccion);
                    Transaccion = Convert.ToInt32(Console.ReadLine());

                    {
                        if (Transaccion <= 10000)
                        {
                            Console.WriteLine("Ingrese el numero de cuenta");
                            Numerocuenta = Convert.ToInt32(Console.ReadLine());
                            if (Numerocuenta > 2819)
                            {
                                Console.WriteLine("El numero de cuenta es erroneo, intentelo de nuevo.");

                            }
                            Console.WriteLine("El numero de cuenta ha sido verificado....Transaccion Completada.");
                            Console.WriteLine("");
                            Console.WriteLine("Que tenga feliz resto del dia!");
                        }
                        else if (Transaccion > 10000)
                        {
                            Console.WriteLine("Intentelo nuevamente, ha excedido el limite permitido.");
                        }
                    }

                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el monto a retirar, Sin exceder del limite de: {0}", limiteRetiro);
                    Retiro = Convert.ToInt32(Console.ReadLine());
                    if (Retiro > -1000)
                    {
                        OP1 = Retiro / billetesmil;
                        Retiro = Retiro - (billetesmil * OP1);
                        Console.WriteLine("Se han retirado un total de {0} billetes de {1}", OP1, billetesmil);

                    }
                    if (Retiro >= 500)
                    {
                        OP2 = Retiro / billetesquinientos;
                        Retiro = Retiro - (billetesquinientos * OP2);
                        Console.WriteLine("Se han retirado un total de {0} billetes de {1}", OP2, billetesquinientos);

                    }
                    if (Retiro >= 200)
                    {
                        OP3 = Retiro / billetesdoscientos;
                        Retiro = Retiro - (OP3 * billetesdoscientos);
                        Console.WriteLine("Se han retirado un total de {0} billetes de  {1}", OP3, billetesdoscientos);


                    }
                    if (Retiro >= 100)
                    {
                        OP4 = Retiro / billetescien;
                        Retiro = Retiro - (OP4 * billetescien);
                        Console.WriteLine("Se han retirado un total de {0} billetes de {1}", OP4, billetescien);
                    }
                }


                else if (opcion == 3)
                {
                    Console.WriteLine("Que tenga un excelente día!");
                }

                /*
                enter = Console.ReadLine();
                if (enter == "0")
                {
                    cantidadbilletes();
                }

            }
            
            void billetesdisponibles()
            {
                Console.Clear();
                Console.WriteLine("Billetes disponibles");
                Console.WriteLine("");
                Console.WriteLine(billetesmil + " billetes de $1.000");
                Console.WriteLine(billetesquinientos + " billetes de $500");
                Console.WriteLine(billetesdoscientos + " billetes de $200");
                Console.WriteLine(billetescien + " billetes de $100");
                Console.WriteLine("");
                do
                {

                    Console.WriteLine("Pulse 0 si desea volver al Inicio.");
                    enter = Console.ReadLine();
                } while (enter != "0");
                */

                if (B == 4)
                Console.WriteLine("Gracias por preferirnos, que tenga un excelente dia!");

            Console.ReadKey();


//Cesar Rojas 2019-8652







        }
    }
}
}
