using System;

namespace DPGI_Console_Solution

{
    /// <summary> 
    /// Головний клас програми. 
    /// </summary> 
    class Program
    {

        /// <summary> 
        /// Головний метод, що виконує запуск програми. 
        /// </summary> 
        static void Main()
        {
            Hello.SayHello();
        }
    }

    /// <summary> 
    /// Клас для виведення привітання. 
    /// </summary> 
    class Hello
    {
        /// <summary> 
        /// Виводить привітальне повідомлення.
        /// <summary> 
        public static void SayHello()
        {
            Console.WriteLine("Привіт, світ!");
        }
    }
}