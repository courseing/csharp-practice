using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Nov2018
{
    class Program
    {
        static String P_name1 = "Rakesh", P_name2 = "Ramesh", P_name3 = "Kartik", P_name4 = "Vinay ", P_name5 = "Raj   ", P_name6 = "Nikhil", P_name7 = "Vicky "; //Declaring all the patient name.
        static int P_age1 = 22, P_age2 = 25, P_age3 = 27, P_age4 = 28, P_age5 = 30, P_age6 = 35, P_age7 = 20; //Declaring ages of all the patient.
        static int P_id1 = 1, P_id2 = 2, P_id3 = 3, P_id4 = 4, P_id5 = 5, P_id6 = 6, P_id7 = 7; //Declaring unique ID's of Each patient.
        static String P_disease1 = "Cold       ", P_disease2 = "Cough      ", P_disease3 = "HeartAttack", P_disease4 = "Cold       ", P_disease5 = "SkinDisease", P_disease6 = "Cough      ", P_disease7 = "HeartAttack";//declaring the various diseases
        static string d_name1 = "Dr. A ", d_name2 = "Dr. B ", d_name3 = "Dr. C ";
        static string d_specialization1 = "Cardiologist ", d_specialization2 = "Dermatologist", d_specialization3 = "Radiologist  ";
        static string d_A1 = "A", d_A2 = "A", d_A3 = "A";
        static int cost = 0;
        static int choice1, choice2;
        static int P_C_id;
        static string doctor;
        
        static void Main(string[] args)
        {

            string Choice1Input = "";
            do
            {
                Console.WriteLine("Welcome to APOLLO HOSPITAL. We are here to HELP YOU..!");
                Console.WriteLine(" ");
                Console.WriteLine("Please Enter Your Answer");
                Console.WriteLine("Press 1 for Doctors Database");
                Console.WriteLine("Press 2 for Patients Database");
                Console.WriteLine("Press 3 to exit.");

                Choice1Input = Console.ReadLine().ToString();
                if (String.IsNullOrEmpty(Choice1Input))
                {
                    choice1 = 0;
                }
                else
                {
                    choice1 = Convert.ToInt32(Choice1Input);
                }
                
                if (choice1 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------- Doctors Database ------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("Doctors Details");
                    Console.WriteLine(" ");
                    Console.WriteLine("Name                              Specialization                                       Availability");
                    Console.WriteLine(" ");
                    Console.WriteLine(d_name1 + "                           " + d_specialization1 + "                                          " + d_A1);
                    Console.WriteLine(d_name2 + "                           " + d_specialization2 + "                                          " + d_A2);
                    Console.WriteLine(d_name3 + "                           " + d_specialization3 + "                                          " + d_A3);
                    //Console.Read();
                }
                else if (choice1 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a option below");
                    Console.WriteLine(" ");
                    Console.WriteLine("Select 1 for Patients Database");
                    Console.WriteLine("Select 2 for existing patient. ");
                    Console.WriteLine("Select 3 for new patient. ");
                    choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 2)
                    {
                        Console.WriteLine("What is your patient ID");
                        P_C_id = Convert.ToInt32(Console.ReadLine());
                        switch (P_C_id)
                        {

                            case 1:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name1 + "                     " + P_age1 + "                             " + P_disease1 + "                        " + P_id1);
                                break;
                            case 2:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name2 + "                     " + P_age2 + "                             " + P_disease2 + "                        " + P_id2);
                                break;
                            case 3:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name3 + "                     " + P_age3 + "                             " + P_disease3 + "                        " + P_id3);
                                break;
                            case 4:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name4 + "                     " + P_age4 + "                             " + P_disease4 + "                        " + P_id4);
                                break;
                            case 5:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name5 + "                     " + P_age5 + "                             " + P_disease5 + "                        " + P_id5);

                                break;
                            case 6:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name6 + "                     " + P_age6 + "                             " + P_disease6 + "                        " + P_id6);
                                break;
                            case 7:
                                Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(P_name7 + "                     " + P_age7 + "                             " + P_disease7 + "                        " + P_id7);
                                break;
                            default:
                                Console.WriteLine("record not present");
                                break;

                        }
                    }
                    else if (choice2 == 1)
                    {
                        Console.WriteLine("welcome to patient Database.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                        Console.WriteLine(" ");
                        Console.WriteLine(P_name1 + "                     " + P_age1 + "                             " + P_disease1 + "                        " + P_id1);
                        Console.WriteLine(P_name2 + "                     " + P_age2 + "                             " + P_disease2 + "                        " + P_id2);
                        Console.WriteLine(P_name3 + "                     " + P_age3 + "                             " + P_disease3 + "                        " + P_id3);
                        Console.WriteLine(P_name4 + "                     " + P_age4 + "                             " + P_disease4 + "                        " + P_id4);
                        Console.WriteLine(P_name5 + "                     " + P_age5 + "                             " + P_disease5 + "                        " + P_id5);
                        Console.WriteLine(P_name6 + "                     " + P_age6 + "                             " + P_disease6 + "                        " + P_id6);
                        Console.WriteLine(P_name7 + "                     " + P_age7 + "                             " + P_disease7 + "                        " + P_id7);
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine("Enter the Patients Name");
                        string Patient_1 = Console.ReadLine();
                        Console.WriteLine("Enter patients age");
                        int P_Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter date");
                        string date = Console.ReadLine();
                        Console.WriteLine("Enter Patients Problem");
                        string Problem = Console.ReadLine();
                        Console.WriteLine("Enter the Diagnosis Required");
                        Console.WriteLine("1. X ray");
                        Console.WriteLine("2. Blood Test");
                        Console.WriteLine("3. ECG");

                        int j = Convert.ToInt32(Console.ReadLine());
                        switch (j)
                        {
                            case 1:
                                cost = 1500;
                                doctor = d_name1;
                                break;
                            case 2:
                                cost = 1000;
                                doctor = d_name2;
                                break;
                            case 3:
                                cost = 1600;
                                doctor = d_name3;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("                         APOLLO HOSPITAL");
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Patient Name:" + Patient_1);
                        Console.WriteLine("");
                        Console.WriteLine("Age:   " + P_Age);
                        Console.WriteLine("");
                        Console.WriteLine("Consultation Date:" + date);
                        Console.WriteLine("");
                        Console.WriteLine("Doctors Name:" + d_name1);
                        Console.WriteLine("");
                        Console.WriteLine("cost     " + cost);
                        Console.WriteLine("");


                        string Procedure = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
            } while (choice1 != 3);
        }
    }
}
