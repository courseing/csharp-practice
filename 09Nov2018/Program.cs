using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Nov2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTypes(); 
            //IfConditions();
            //SwitchConditions();
            //Looping();
            Arrays();
        }

        private static void Arrays()
        {
            string[,] StudentsCourses = new string[5,2];
            string StudentName = "Kumar";


            StudentName = StudentName.(50-StudentName.Length);

            DateTime dt = new DateTime(2018, 11, 10);



            StudentsCourses[0,0] = "";
            StudentsCourses[0, 1] = "";

            string[][] PatientInvestigations = new string[3][];
            PatientInvestigations[0] = new string[3];



            int[] PlayersScore = new int[5];
            PlayersScore[0] = 11;
            PlayersScore[1] = 12;
            PlayersScore[2] = 13;
            PlayersScore[3] = 14;
            PlayersScore[4] = 15;


            foreach (int PlayerScore in PlayersScore)
            {
                Console.WriteLine(PlayerScore);
            }
            Console.ReadLine();

            for (int PlayerNo=0; PlayerNo<PlayersScore.Length; PlayerNo++)
            {
                Console.WriteLine(PlayersScore[PlayerNo]);
            }
            Console.ReadLine();


            //int Player1Score = 20;
            //Player1Score.

        }

        private static void Looping()
        {
            //for, while, do while

            int counter;
            for(counter=1;counter<=10;counter++)
            {
                Console.WriteLine("Number " + counter);
            }

            counter = 1;
            for (; counter <= 10; counter++)
            {
                Console.WriteLine("Number " + counter);
            }

            counter = 1;
            for (; counter <= 10; )
            {
                if (counter == 7) break;
                
                counter++;
                if (counter == 5)
                {
                    continue;
                }
                Console.WriteLine("Number " + counter);
                Console.WriteLine("Number " + counter);
                Console.WriteLine("Number " + counter);
                Console.WriteLine("Number " + counter);
            }
            // 1,2,3,4,5,6
            // 1,2,3,4,5,



            // 2,3,4,6

            counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("Number " + counter);
                counter++;
            }


            counter = 1;
            do
            {
                Console.WriteLine("Number " + counter);
                counter++;
            }
            while (counter <= 10);

        }

        static void SwitchConditions()
        {
            int num1;

            Console.WriteLine("Plesae enter number 2");
            num1 = Convert.ToInt32(Console.ReadLine());
            switch(num1)
            {
                case 1:
                    Console.WriteLine("Number  " + num1);
                    break;
                case 2:
                    Console.WriteLine("Number  " + num1);
                    break;
                default:
                    Console.WriteLine("Number  " + num1);
                    break;
            }

            //switch(z)    
            //case 1
            //True Block
            //case 2
            //True Block
            //default

        }

        static void DataTypes()
        {
            int num1, num2;
            string fname = "K";
            string lname = "Gandhi";
            string name = fname + lname;

            Console.WriteLine("Plesae enter number 2");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Plesae enter number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of entered numbers is " + (num1 + num2));
            Console.Read();
        }
        static void IfConditions()
        {
            int num1, num2;

            Console.WriteLine("Plesae enter number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            //   T    ||   T >>> T
            if (num1 <= 0 || num1 >= 100)  //num1 = 10
                Console.WriteLine("Number is not valid");

            //   T    ||   T >>> T
            if (num1 >= 0 && num1 <= 100)  //num1 = 10
                Console.WriteLine("Number is not valid");


            if (num1 <= 0)  //num1 = 10
                Console.WriteLine("Number is not valid");
            else if (num1 >= 100)
                Console.WriteLine("Number is not valid");
            else
            {

            }

            if (num1 <= 0)
            {
                Console.WriteLine(num1 + " is less than zero. Cannot continue");
                return;
            }


            if (num1 <= 0)
            {
                Console.WriteLine(num1 + " is less than zero. Cannot continue");
                return;
            }
            else
            {
                ///
            }
        }
    }
}

