using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressEnterToExit
{

    /// <summary>
    /// Somehow the class name should reflect purpose or the main meaning of code of the class. 
    /// This is a try to make a text line only with "Console.Write" method and close the console with "Enter" button.
    /// </summary>
    class ConsoleClose
    {
        /// <summary>
        /// Main part of executable code. It checks if the pressed key is not equal to the Enter key. 
        /// Once the user presses the Enter key, the condition becomes false, and the check loop exits closing the console window.
        /// </summary>
        /// <param name="args">Three words with "Console.Write" method and text of exit describtion on the next line.</param>
        static void Main(string[] args)
               {
            Console.Write("Hello ");
            Console.Write("World ");
            Console.Write("!!!\n\n");
            Console.WriteLine("Press Enter to close the console...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
