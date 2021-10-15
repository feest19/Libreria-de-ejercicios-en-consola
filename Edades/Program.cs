using System;

namespace Edades
{
    class Program
    {
        static void Main(string[] args)
        {
            // en este apartado se hara un programa que al entrar una edad en numero se le diga en que etapa de la vida esta "niñ@, adolescente, joven,
            // adult@, ancian@.

            // creamos las variables
            int edad = 0;
            string sexo = "";
            string respuesta = "";
            bool salir = false;
            bool salir2 = false;

            //creamos la interaccion
            Console.WriteLine("Dime la edad que tienes y te dire en que etapa de tu vida estas");

            //Haremos el script con if anidados dentro de un bucle do/while & while para que se repita cuantas veces el usuario desee, y tambien colocaremos un try/catch
            //para recoger algun posible error y asi evitar que nuestro programa explote, tambien hay que aclarar que los metodos empleados aqui
            //son muy poco ortodoxos, esto debido a que encontre poco material y para mi experiencia confuso con relacion a obligar al usuario a
            // punsar una tecla en concreto... pero funciona.

            //creamos el do/while
            do
            {
                //creamos dentro del bucle el try/catch para colocar nuestro codigo y atrapar cualquier error y no explote el programa
                try
                {
                    //comenzamos preguntandole al usuario su sexo

                    Console.WriteLine("primero digite el sexo F/M ");
                    sexo = Console.ReadLine();

                    //luego evaluamos que tecla preciono para asi adaptar el mesaje conforme al genero de la persona, si la persona no se identifica
                    //con algunas de las teclas no importando si son mayusculas y minusculas, no se le preguntara su edad.

                    if (sexo == "f" || sexo == "F" || sexo == "m" || sexo == "M")
                    {
                        //luego de evaluarlo se le pide su edad

                        Console.WriteLine("ahora dime que edad tienes ");
                        edad = int.Parse(Console.ReadLine());

                        //luego de pedirle su edad entonces evaluamos las dos variables segun su tipo y edad para que el usuario reciba el mensaje
                        //adecuado a la edad y genero.

                        if (sexo == "F" || sexo == "f")
                        {
                            if (edad > 0 && edad <= 10)
                            {
                                Console.WriteLine("Eres una niña");
                            }
                            else if (edad >= 11 && edad <= 17)
                            {
                                Console.WriteLine("eres una adolescente");
                            }
                            else if (edad >= 18 && edad <= 50)
                            {
                                Console.WriteLine("eres una adulta");
                            }
                            else if (edad >= 51 && edad <= 59)
                            {
                                Console.WriteLine("Estas casi a las puertas de la llamada 'tercera edad'");
                            }
                            else if (edad >= 60)
                            {
                                Console.WriteLine("eres una persona de tercera edad");
                            }
                        }
                        if (sexo == "m" || sexo == "M")
                        {
                            if (edad > 0 && edad <= 10)
                            {
                                Console.WriteLine("Eres una niño");
                            }
                            else if (edad >= 11 && edad <= 17)
                            {
                                Console.WriteLine("eres un adolescente");
                            }
                            else if (edad >= 18 && edad <= 50)
                            {
                                Console.WriteLine("eres un adulto");
                            }
                            else if (edad >= 51 && edad <= 59)
                            {
                                Console.WriteLine("Estas casi a las puertas de la llamada 'tercera edad'");
                            }
                            else if (edad >= 60)
                            {
                                Console.WriteLine("eres una persona de tercera edad");
                            }
                        }
                    }
                    //si el usuario suministro de manera erronea el simbolo de su sexo, se salta toda la evaluacion, se presenta este mensaje y luego
                    //pasa a evaluar si desea seguir.

                    else Console.WriteLine("No tiene caso seguir si no me das lo que te pido");
                }
                //aqui encerramos el error que puede probocar que el usuario en ves de un numero inserte una letra
                catch (Exception)
                {
                    Console.WriteLine("tiene que oprimir la tecla correspondiente al mandato que se le pide");
                    Console.WriteLine("mmmm, si no sigues la regla entonces para que me das doble click???");
                }
                //aqui se evalua si el usuario desea continuar, y se crea el bucle while para obligar al usuario a pulsar la tecla que el programador
                //quiere que pulse.
                while (salir2 == false)
                {
                    Console.WriteLine("Desea seguir? y/n ");
                    respuesta = Console.ReadLine();

                    if (respuesta.Equals("Y") || respuesta.Equals("y"))
                    {
                        salir = false;
                        break;
                        //si el usuario responde que si quiere seguir la palabra "break" rompe este while para que pueda pasar al do/while
                        //y repetir desde el principio pidiendole el genero.
                    }
                    if (respuesta.Equals("N") || respuesta.Equals("n"))
                    {
                        salir = true;
                        break;
                    }
                    //si el usuario pulsa nuevamente una tecla que no corresponde, salta este mensaje y el bucle se repite hasta que pulse la tecla
                    //correcta.
                    Console.WriteLine("tienes que que precionar la tecla correcta");
                }
                //si el usuario presiona la tecla n entonces significa que no suiere seguir, por lo tanto los valores buleanos pasan a verdadero para
                //que se rompa todos los bucles y asi terminar el programa.

            } while (salir == false);


        }
    }
}
