int opcion = 0;
double num1=0, num2=0, numero = 0, exp=0;

Console.WriteLine("DEV-Johan Morales");
do
{Console.Clear();
    Console.WriteLine("*********************************************************************");
    Console.WriteLine("PROGRAMA DE CALCULADORA");
    Console.WriteLine("OPCION-1 SUMA");
    Console.WriteLine("OPCION-2 RESTA");
    Console.WriteLine("OPCION-3 MULTIPLICACION");
    Console.WriteLine("OPCION-4 DIVISION");
    Console.WriteLine("OPCION-5 EXPONETE");
    Console.WriteLine("OPCION-6 SALIR");
    Console.Write("SELECCIONA LA OPCION DESEADA: ");
    int.TryParse(Console.ReadLine(), out opcion);
        
    Console.WriteLine("\n*********************************************************************");
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Bienvenidos al program de sumatorias de numeros");
            //Solicitud del primer numero
            Console.WriteLine("Favor introducir numero 1: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Solicitud del segundo numero
            Console.WriteLine("Favor introducir numero 2: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Aqui se realiza la operacion
            double sumarnumeros = num1 + num2;
            
            Console.WriteLine("La sumatoria es: " + sumarnumeros + "\n");

            
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Deseas Continuar:  (S / N) ");
                    string respuesta = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (respuesta == "NO" || respuesta == "N")
                    {
                        break;
                    }
                    else if (respuesta == "SI" || respuesta == "S")
                    {
                        Console.WriteLine("Total: " + sumarnumeros);
                        Console.WriteLine("Indroduce otro numero:");

                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out numero))
                            {
                                sumarnumeros += numero;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Favor Introduce un numero Valido");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Introduce una respuesta Valida: S o N");

                    }
                }                
                break;
               
            }
          Console.WriteLine("La Suma Total es: " + sumarnumeros + "\n" + "PRESIONA PARA CONTINUAR");
         break;

        //Fin de la operacion de suma.

        case 2:

            Console.WriteLine("Bienvenidos al program de Resta de numeros");
            //Solicitud del primer numero
            Console.WriteLine("Favor introducir numero 1: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Solicitud del segundo numero
            Console.WriteLine("Favor introducir numero 2: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Aqui se realiza la operacion
            double Restanumero = num1 - num2;

            Console.WriteLine("La sumatoria es: " + Restanumero + "\n");

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Deseas Continuar:  (S / N) ");
                    string respuesta = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (respuesta == "NO" || respuesta == "N")
                    {
                        break;
                    }
                    else if (respuesta == "SI" || respuesta == "S")
                    {
                        Console.WriteLine("Total: " + Restanumero);
                        Console.WriteLine("Indroduce otro numero:");

                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out numero))
                            {
                                Restanumero -= numero;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Favor Introduce un numero Valido");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Introduce una respuesta Valida: S o N");

                    }
                }
                break;

            }
            Console.WriteLine("La resta Total es: " + Restanumero + "\n" + "PRESIONA PARA CONTINUAR");
            break;

            //Fin de la resta de numeros

        case 3:
            
            Console.WriteLine("Bienvenidos al program de multiplicacion de numeros");
            //Solicitud del primer numero
            Console.WriteLine("Favor introducir numero 1: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Solicitud del segundo numero
            Console.WriteLine("Favor introducir numero 2: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Aqui se realiza la operacion
            double multiplicacion = num1 * num2;

            Console.WriteLine("La sumatoria es: " + multiplicacion + "\n");


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Deseas Continuar:  (S / N) ");
                    string respuesta = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (respuesta == "NO" || respuesta == "N")
                    {
                        break;
                    }
                    else if (respuesta == "SI" || respuesta == "S")
                    {
                        Console.WriteLine("Total: "+multiplicacion);
                        Console.WriteLine("Indroduce otro numero:");

                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out numero))
                            {
                                multiplicacion *= numero;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Favor Introduce un numero Valido");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Introduce una respuesta Valida: S o N");

                    }
                }
                break;

            }
            Console.WriteLine("La multiplicacion Total es: " + multiplicacion + "\n" + "PRESIONA PARA CONTINUAR");

            break;
        case 4:
            
            Console.WriteLine("Bienvenidos al program de Division de numeros");
            //Solicitud del primer numero
            Console.WriteLine("Favor introducir numero 1: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Solicitud del segundo numero
            Console.WriteLine("Favor introducir numero 2: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Aqui se realiza la operacion
            double Division = num1 / num2;

            Console.WriteLine("La sumatoria es: " + Division + "\n");


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Deseas Continuar:  (S / N) ");
                    string respuesta = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (respuesta == "NO" || respuesta == "N")
                    {
                        break;
                    }
                    else if (respuesta == "SI" || respuesta == "S")
                    {
                        Console.WriteLine("Resultado: " + Division);
                        Console.WriteLine("Indroduce otro numero:");

                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out numero))
                            {
                                Division /= numero;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Favor Introduce un numero Valido");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Introduce una respuesta Valida: S o N");

                    }
                }
                break;

            }
            Console.WriteLine("La multiplicacion Total es: " + Division + "\n" + "PRESIONA PARA CONTINUAR");
            break;
        case 5:
            
            Console.WriteLine("Bienvenidos al programa de Exponente de numeros");
            //Solicitud del primer numero
            Console.WriteLine("Favor introducir el numero a elevar: ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Solicitud del segundo numero
            Console.WriteLine("A cuanto lo quieres elevar : ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out exp))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Favor Introduce un numero Valido");
                }
            }
            //Aqui se realiza la operacion
            double exponente = Math.Pow(num1, exp);

            Console.WriteLine("El resultado es: " + exponente + "\n");


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Deseas Continuar:  (S / N) ");
                    string respuesta = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if (respuesta == "NO" || respuesta == "N")
                    {
                        break;
                    }
                    else if (respuesta == "SI" || respuesta == "S")
                    {
                        Console.WriteLine("Resultado: " + exponente);
                        Console.WriteLine("Indroduce a cuanto deseas elevar el resultado:");

                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out numero))
                            {
                                exponente = Math.Pow(exponente, numero);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Favor Introduce un numero Valido");
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Introduce una respuesta Valida: S o N");

                    }
                }
                break;

            }
            Console.WriteLine("La multiplicacion Total es: " + exponente + "\n" + "PRESIONA PARA CONTINUAR");
            break;
        case 6:
            Console.WriteLine("!Gracias por preferirnos, DeV-Johan Morales");
            return;
        default:
            Console.WriteLine("opcion invalidad");
            break;
    }
    Console.ReadKey();

} while (opcion!=6);
