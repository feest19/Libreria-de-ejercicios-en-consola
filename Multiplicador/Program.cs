using System;

namespace Multiplicador
{
    class Program
    {
        /*Guarde en una variable entera un numero, y en otra variable entera otro
        numero. y muestre el resultado de multiplicar ambos números.*/
        static void Main(string[] args)
        {
            //creamos las variables

            string teclado = "";
            int nun1, nun2;
            bool romper = false;

            //creamos un bucle para repetir el proceso hasta que se precione la tecla y o Y

            do
            {
                //dentro del bucle creamos un try/catch para asegurarnos de que se coloque solo numero, vs ya viene con reglas de operaciones
                //incluidas y una de ellas es que no se puede hacer operaciones aritmeticas con numeros y letras, por ende
                //no es necesario validar si se coloca solo numeros ya que vs arrojara un error de sintaxis cuando note que uno de los dos
                //digitos es una letra. en este caso como ya sabemos que dara error de darse el caso, convertiremos ese error en un msj
                //entendible para el usuario.

                try
                {
                    //codigo a evaluar

                    Console.WriteLine("coloque el primer numero");
                    nun1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("coloque el segundo numero");
                    nun2 = int.Parse(Console.ReadLine());
                    var resultado = nun1 * nun2;
                    Console.WriteLine("el resultado es: " + resultado);
                    
                }
                catch (Exception)//aqui se almacena el error
                {
                    //si el error se detecta, sale este msj y asi evitamos que el programa explote.
                    Console.WriteLine("no se puede realizar la operacion porque intrudujo una letra en vez de numero");
                }
                //validamos para que el bucle funcione y se repita el proceso hasta precionar una letra diferente a y o Y

                while (romper== false)//colocamos un while para obligar al usuario a precionar una de las dos teclas para seguir n/y
                {
                    Console.WriteLine("desea continuar? Y/N ");
                    teclado = Console.ReadLine();
                    if (teclado == "y" || teclado == "Y")
                    {
                        romper = false;
                        break;
                    }
                    if (teclado == "n" || teclado == "N")
                    {
                        romper = true;
                        break;
                    }
                    Console.WriteLine("tiene que precionar una de las dos teclas para continuar y/n");
                }
                

                //la expresion || quiere decir "o" en español, en este caso ya sea minuscula o mayuscula seguira repitiendose

            } while (teclado=="y" || teclado=="Y");
            
        }
    }
}
