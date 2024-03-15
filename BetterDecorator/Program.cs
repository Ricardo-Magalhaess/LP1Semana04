using System;

namespace BetterDecorator
{
    /// <summary>
    /// O Programa recebe 3 valores uma str, char e um int
    /// devolve a char e a string dependendo do int
    /// </summary>
    class Program
    {
        /// <summary>
        /// converte os argumentos para char e int
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Concede();
                
            }
            else {

            char o = char.Parse(args[1]);
            int a = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0],o,a));
            
            }

        static void Concede(){
            Console.WriteLine(Decor("User did not specify args!",'=',3));
        }

        /// <summary>
        /// executa dois ifs para por uma char
        /// devolve a char e a string dependendo do int
        /// </summary>
        static string Decor(string s, char dec, int i)
        {
            string a = "";
            string b = "";
            for (int k = 0; k < i; k++){
                    a = a +dec; 
                
            }
            for (int k = 0; k < i; k++){
                    b = b+dec; 
            }
                
            return $"{a} {s} {b}";     
        }
        
        }
    }
}
