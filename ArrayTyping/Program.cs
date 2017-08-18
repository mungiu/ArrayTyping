using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            //this array can hold anything 
            //because all types are implicitly derived from "object"
            object[] objArray = new object[3]
            {
                "Hello world",
                4,
                new Button { Text="Click me!" }
            };

            //using reflection to get type
            Type objArrType = objArray.GetType();

            string[] strArray = new string[2];
            Type strArrType = strArray.GetType();

            //displaying the content of each object in the array
            foreach (object item in objArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
