using System;

namespace Calculadora
{
    class Program
    {
        

        /// <summary>
        /// Muestra el menú de la aplicación.
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("Qué querés hacer?");
            Console.WriteLine();
            Console.WriteLine("1- Sumar dos números");
            Console.WriteLine("2- Multiplicar dos números");
            Console.WriteLine("3- Restar dos números");
            Console.WriteLine("4- Dividir dos números");
            Console.WriteLine("0- Salir");
        }

        /// <summary>
        /// Método de la suma.
        /// </summary>

        static int Suma(int operador1, int operador2){
            int suma = operador1 + operador2;
            return suma;
        }

        /// <summary>
        /// Método de la multiplicación.
        /// </summary>

        static int Resta(int operador1, int operador2){
           int resta = operador1 - operador2;
            return resta;
        }

        /// <summary>
        /// Método de la multiplicación.
        /// </summary>

        static int Multiplicacion(int operador1, int operador2){
            int multiplicacion = operador1 * operador2;
            return multiplicacion;
        }
        
                
        /// <summary>
        /// Método de la división.
        /// </summary>

        static int Division(int operador1, int operador2){
            int division = operador1 / operador2;
            return division;
        }


        
        


        static void Main(string[] args)
        {
            
             

            Console.WriteLine("Bienvenido a la calculadora");
            MostrarMenu();
            
            int opcion = int.Parse(Console.ReadLine());
            
            /// <summary>
            /// Opciones del menú.
            /// </summary> 
                while(opcion!=0)  
             {        
                 
                
                switch(opcion)
                {   
                    
                    case 1:
                        Console.WriteLine("Ingrese el primer número");
                        int suma1=int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int suma2=int.Parse(Console.ReadLine());
                        int sumar= Suma(suma1, suma2);
                        Console.WriteLine("El resultado de la operación es:"+ sumar);
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;
                        
                    case 2:  
                         
                         Console.WriteLine("Ingrese el primer número");
                         int resta1=int.Parse(Console.ReadLine());
                         Console.WriteLine("Ingrese el segundo número");
                         int resta2=int.Parse(Console.ReadLine());
                         int multiplicar= Multiplicacion(resta1, resta2);
                         Console.WriteLine("El resultado de la operación es:"+ multiplicar);   
                         MostrarMenu();
                         opcion = int.Parse(Console.ReadLine());
                         break; 
                   
                    case 3:
                        
                         Console.WriteLine("Ingrese el primer número");
                         int multiplicacion1=int.Parse(Console.ReadLine());
                         Console.WriteLine("Ingrese el segundo número");
                         int multiplicacion2=int.Parse(Console.ReadLine());
                         int restar= Resta(multiplicacion1, multiplicacion2);
                         Console.WriteLine("El resultado de la operación es:"+ restar);   
                         MostrarMenu();
                         opcion = int.Parse(Console.ReadLine());
                         break; 
                
                    case 4:
                        
                         Console.WriteLine("Ingrese el primer número");
                         int division1=int.Parse(Console.ReadLine());
                         Console.WriteLine("Ingrese el segundo número");
                         int division2=int.Parse(Console.ReadLine());
                         int dividir= Division(division1, division2);
                         Console.WriteLine("El resultado de la operación es:"+ dividir);   
                         MostrarMenu();opcion = int.Parse(Console.ReadLine());
                         break; 

                    default:
                        Console.WriteLine("Opción inválida");                    
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;  


                }
             } 
            MostrarMenu();

            Console.WriteLine("Chau!!!!");
            Console.ReadKey();
        }
    }
}
