using System;
using atest.Facade;
using System.Linq;

namespace atest
{

    public class Program
    {
        public static void Main()
        {
            // "abcccbcy" official test
            Console.OpenStandardInput(); 
            Console.WriteLine("Type string of characters to remove duplicate adjacents.");
            var strIn = Console.ReadLine();
            var model = AtFacade.GetModel(strIn);
            var inchars = model.InputChars;
            var outChars = AtFacade.RemoveAdjacentDuplicates(inchars).ToArray();
            var retValue = new string(outChars);
            Console.WriteLine("Results: ");
            Console.Write(retValue);
        }
    }
}
