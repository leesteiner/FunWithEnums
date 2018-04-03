using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with enums*****\n");
            //Make an EmpType variable.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.ReadLine();

            //Print storage for the enum
            Console.WriteLine("EmpType uses a {0} for storage.", Enum.GetUnderlyingType(emp.GetType()));
            Console.ReadLine();

            //This time use typeof to extract a Type.
            Console.WriteLine("EmpType uses a {0} for storage.", Enum.GetUnderlyingType(typeof(EmpType)));

            Console.WriteLine("Emp is a {0}", emp.ToString());
            Console.ReadLine();

            //Prints out Contractor = 100
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
            Console.ReadLine();
            EmpType e2 = EmpType.Contractor;

            //These type are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.DarkBlue;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
        }

        enum EmpType : byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 90
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very GOOD, sir!");
                    break;
                default:
                    break;
            }
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            //Get all name-value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members", enumData.Length);

            //Now show the string name and associated value

            for(int i = 0;i<enumData.Length;i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));

            }
            Console.WriteLine();
        }
    }
}
