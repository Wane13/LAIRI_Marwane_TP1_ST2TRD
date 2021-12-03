using System;

namespace LAIRI_Marwane_TP1_ST2TRD
{

    public class Exercice1
    {
        public static int AskUserParameter()
        {
            bool controle = false;
            int result = 0;

            while (controle != true)
            {

                Console.WriteLine("Enter a number to display the multiplication table :");
                controle = int.TryParse(Console.ReadLine(), out result);


            }

            return result;
        }

        public void DisplayTable()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine('\n' + "table de " + i + '\n');

                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + "*" + j + " =" + i * j);
                }
            }
        }

        public void DisplayOddsElem()
        {
            int res = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine('\n' + "Odds element of table of  " + i + '\n');

                for (int j = 1; j < 11; j++)
                {
                    res = i * j;

                    if (res % 2 == 1)
                    {
                        Console.WriteLine(i + "*" + j + " =" + i * j);
                    }

                }
            }
        }

        public void DisplayChoice()
        {
            int choice = 0;

            choice = AskUserParameter();

            Console.WriteLine('\n' + "table de " + choice + '\n');
            for (int k = 1; k < 11; k++)
            {
                Console.WriteLine(choice + "*" + k + " =" + choice * k);
            }

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Exercice1 e = new Exercice1();
            e.DisplayTable();
            e.DisplayOddsElem();
            e.DisplayChoice();

        }
    }
}
