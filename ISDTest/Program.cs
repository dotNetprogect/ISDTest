using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Выбери кем управлять");
            Console.WriteLine("Mom - мама");
            Console.WriteLine("Dad - папа");
            Console.WriteLine("Doch - дочка");
            string member = Console.ReadLine();

            Human chosenHuman = GetMember(member);

            if (chosenHuman is IWork)
                Console.WriteLine("Я иду на работу");
            if (chosenHuman is IGoToScool)
                Console.WriteLine("Я иду в школу");
            chosenHuman.Walk();
            Console.WriteLine(chosenHuman.ToString());
            
        }

        static Human GetMember(string member)
        {
            switch (member)
            {
                case "Mom":
                    return new Mom();
                case "Dad":
                    return new Dad();
                case "Doch":
                    return new Daughter();
                default:
                    return null;
            }
        }
    }
}
