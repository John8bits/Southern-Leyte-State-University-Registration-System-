using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revise8
{
    public static class Program
    {
        //Programming 2 Final Project (System)
        public static string[] FullName = new string[100];
        public static int[] Age = new int[100];
        public static string[] sex = new string[100];
        public static string[] course = new string[100];
        // static string[] Major = new string[100];
        //  public static string[] Birthdate = new string[10];
        static long[] Contact = new long[100]; //long(64 bits)
        public static string[] Address = new string[100];
        public static string[] campus = new string[100];
        public static int[] year = new int[100];

        static int x = 0;
        //Register count ag students (global variable)
        static int Regcount = 0;

        static void Main(string[] args)
        {

            string AskHome = "";
            do
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                //Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("             SOUTHERN LEYTE STATE UNIVERSITY REGISTRATION SYSTEM                                                 \n\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
                            ███████╗██╗     ███████╗██╗   ██╗
                            ██╔════╝██║     ██╔════╝██║   ██║
                            ███████╗██║     ███████╗██║   ██║
                            ╚════██║██║     ╚════██║██║   ██║
                            ███████║███████╗███████║╚██████╔╝
                            ╚══════╝╚══════╝ ╚═════╝ 
                    ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"     
                                      ╔══════╗
                                      ║ HOME ║
                                      ╚══════╝
                    ");


                Console.ResetColor();

                Console.WriteLine("\t\t Choose the following: \n");
                Console.WriteLine("\t\t\t [A] View All Campuses");
                Console.WriteLine("\t\t\t [B] View Course Offer");
                Console.WriteLine("\t\t\t [C] Register Students");
                Console.WriteLine("\t\t\t [D] View Registered Students");
                Console.WriteLine("\t\t\t [E] Search Students");
                Console.WriteLine("\t\t\t [F] Update Course");
                Console.WriteLine("\t\t\t [G] Delete Register Students(Admin only)");

                /*
                Console.WriteLine("\n\n\t\t Choose the following: \n");
                Console.WriteLine("\t\t\t [A] View All Campuses \n\t\t\t [B] View Course Offer\n\t\t\t [C] Register Students\n\t\t\t [D] View Registered Students\n\t\t\t [E] Search Students\n\t\t\t [F] Update Course\n\t\t\t [G] Delete Register Students\n");
                */
                int attemps = 0;


            c:
                Console.Write("\n\t  Enter Choice: ");
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "a":
                    case "A":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("SOUTHERN LEYTE STATE UNIVERSITY (SLSU) ALL CAMPUSES\n");
                        Console.ResetColor();
                        AllCampuses();
                        break;
                    case "b":
                    case "B":
                        // Console.Clear();
                        CourseOffer();
                        break;
                    case "C":
                    case "c":
                        Console.Clear();
                        Register();
                        break;
                    case "d":
                    case "D":
                        Console.Clear();
                        ViewRegisteredStudents();
                        break;
                    case "e":
                    case "E":
                        Console.Clear();
                        SearchStudents();
                        break;
                    case "F":
                    case "f":
                        Console.Clear();
                        UpdateCourse();
                        break;
                    case "g":
                    case "G":
                        Console.Clear();

                        while (true)
                        {
                            Console.Write("\n\t\tEnter Pin: ");
                            string pin = Console.ReadLine();

                            if (pin == "slsu2025")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n\t\t\t Access Granted\n");
                                Console.ResetColor();

                                Console.WriteLine("\n\t\t\t Press any key to continue...\n");
                                Console.ReadKey();
                                DeleteStudents();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\t Incorrect pin");
                                Console.ResetColor();
                                attemps++;

                                if (attemps == 3)
                                {
                                    Console.ForegroundColor= ConsoleColor.Red;
                                    Console.WriteLine("\n\t\t\t Sorry, But i think you're not the admin\n");
                                    Console.ResetColor();
                                    break;
                                }

                            }

                        }

                        // DeleteStudents();
                        break;
                    default:
                        Console.WriteLine("Invalid Input\n");
                        goto c;
                        //break;

                }


            h:
                try
                {
                    Console.Write("\n\t\t\t\tBack to Home? [y/n]: ");
                    AskHome = Console.ReadLine().Trim();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "\n");
                }


                if (AskHome == "y" || AskHome == "Y")
                {
                    continue;
                }
                else if (AskHome == "N" || AskHome == "n")
                {
                    Console.WriteLine("Program Exit...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    goto h;
                }

            } while (AskHome == "y" || AskHome == "Y");

        }

        static void Register()
        {

            string register;
            //int x = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t| SLSU REGISTRATION |\n\n");
            Console.ResetColor();

            do
            {
                //  Console.Clear();
                Console.WriteLine("\t\t\t\t\t\tPERSONAL INFORMATION\n\n");

                bool NameExist = false;

            name:
                Console.Write("Enter Full Name  : ");
                FullName[x] = Console.ReadLine().Trim();

                if (FullName[x] == "")
                {
                    Console.WriteLine("Invalid input");
                    goto name;
                }

                for (int i = 0; i < x; i++)
                {
                    if (FullName[i] != null && FullName[i].Equals(FullName[x], StringComparison.InvariantCultureIgnoreCase))
                    {
                        NameExist = true;
                        Console.WriteLine("\tName already exist\n");
                        goto name;
                    }
                }


                /*
                            while (true)
                            {
                            name:
                                Console.Write("Enter Full Name  : ");
                                FullName[x] = Console.ReadLine().Trim();

                                if (FullName[x] == "")
                                {
                                    Console.WriteLine("Invalid input");
                                    goto name;
                                }
                                else
                                {

                                    for (int i = 0; i < x; i++)
                                    {
                                        if (FullName[i] != null && FullName[i].Equals(FullName[x], StringComparison.InvariantCultureIgnoreCase))
                                        {
                                            NameExist = true;
                                            Console.WriteLine("\tName already exist\n");
                                            //continue;
                                            goto name;
                                        }
                                        //  else break;

                                    }
                                    break;

                                }
                                //  break;
                            }
                */


                while (true)
                {
                    string required = "0123456789";
                    try
                    {
                        Console.Write("Contact Number   : +63");
                        Contact[x] = long.Parse(Console.ReadLine());

                        //string ConvertContact = Contact[x].ToString();
                        //Convert ag contact from long to string para dli mo total ag number instead mag concatenation para ma total ag length/size. 
                        string ConvertContact = Convert.ToString(Contact[x]);

                        if (ConvertContact.Length > required.Length)
                        {
                            Console.WriteLine("Contact number must not exceed 10 characters\n");
                        }
                        else if (ConvertContact.Length < required.Length)
                        {
                            Console.WriteLine("Contact number must not lesser than 10 characters\n");
                        }
                        else
                        {
                            break;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    catch (OverflowException overflow)
                    {
                        Console.WriteLine(overflow.Message + "\n");
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }


                }




                while (true)
                {

                    try
                    {
                        Console.Write("Enter Age        : ");
                        Age[x] = int.Parse(Console.ReadLine());

                        if (Age[x] < 0)
                        {
                            Console.WriteLine("No negative age\n");
                        }
                        else if (Age[x] >= 18 && Age[x] <= 60)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Age must be greater than 17 && less than 60\n");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, numbers only.\n");
                        Console.ResetColor();
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (OverflowException overflow)
                    {
                        Console.WriteLine(overflow.Message);
                    }

                }

                /*        while (sex[x] != "M" && sex[x] != "F")
                        {
                            Console.Write("Sex [M/F]        : ");
                            sex[x] = Console.ReadLine().ToLower().ToUpper();

                            /* if(sex[x] =="M" ||sex[x] =="m" )
                             {
                                 break;
                             }else if(sex[x] =="F" ||sex[x] =="f" )
                             {
                                 break;
                             }else{

                             }

                        }
                  */

                while (true)
                {
                    Console.Write("Sex [M/F]        : ");
                    sex[x] = Console.ReadLine().Trim(); /*.ToLower().ToUpper();*/

                    if (sex[x] == "M" || sex[x] == "m")
                    {
                        break;
                    }
                    else if (sex[x] == "F" || sex[x] == "f")
                    {
                        break;
                    }
                    else if (sex[x].Equals("Male", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                    else if (sex[x].Equals("Female", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!\n");
                    }

                }

                /*
                a:
                    Console.Write("Address          : ");
                    Address[x] = Console.ReadLine();

                    if (Address[x] == "")
                    {
                        Console.WriteLine("  Invalid input!\n");
                        goto a;
                    }*/
                do
                {
                    Console.Write("Address          : ");
                    Address[x] = Console.ReadLine();

                    if (Address[x] == "")
                    {
                        Console.WriteLine("  Invalid input!\n");
                    }

                } while (Address[x] == "");

            y:
                try
                {


                    Console.Write("Year             : ");
                    year[x] = int.Parse(Console.ReadLine());


                    if (year[x] >= 1 && year[x] <= 4)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Invalid input, 1-4 only\n");
                        goto y;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only\n");
                    goto y;
                }



            c:
                Console.Write("Enter SLSU Campus: ");
                campus[x] = Console.ReadLine().Trim();


                //main campus tanang course accepted
                if (campus[x].Equals("Main", StringComparison.InvariantCultureIgnoreCase) || campus[x].Equals("Sogod", StringComparison.InvariantCultureIgnoreCase))
                {
                MCCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Industrial Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Technology and Livelihood Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Industrial Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Elementary Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Civil Engineering", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Computer Engineering", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Criminology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Electrical Engineering", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Food Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Tourism Management", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for Main Campus (Sogod)\n");
                        goto MCCOURSE;
                    }

                }
                //hinunangan campus
                else if (campus[x].Equals("Hinunangan", StringComparison.InvariantCultureIgnoreCase))
                {
                HCCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agricultural Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Secondary Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Technology and Livelihood Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agribusiness", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agriculture", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agricultural Entrepreneurship", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Environmental Science", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for Hinunangan Campus\n");
                        goto HCCOURSE;
                    }

                }
                //TO CAMPUS
                else if (campus[x].Equals("Tomas Oppus", StringComparison.InvariantCultureIgnoreCase))
                {
                TOCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Secondary Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Elementary Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Business Administration", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for Tomas Oppus Campus\n");
                        goto TOCOURSE;
                    }

                }
                //Bontoc
                else if (campus[x].Equals("Bontoc", StringComparison.InvariantCultureIgnoreCase))
                {
                BCCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Fisheries", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agriculture", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Marine Biology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Agriculture and Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for Bontoc Campus\n");
                        goto BCCOURSE;
                    }

                }
                //San Juan
                else if (campus[x].Equals("San Juan", StringComparison.InvariantCultureIgnoreCase))
                {
                SJCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Industrial Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Secondary Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Entrepreneurship", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Office Administration", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Accountancy", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Technology and Livelihood Education", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Management Accounting", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for San Juan Campus\n");
                        goto SJCOURSE;
                    }

                }
                else if (campus[x].Equals("Maasin City", StringComparison.InvariantCultureIgnoreCase))
                {
                MaasinCOURSE:
                    Console.Write("Enter choosen course: BS in ");
                    course[x] = Console.ReadLine();

                    if (course[x].Equals("Social Work", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else if (course[x].Equals("Public Administration", StringComparison.InvariantCultureIgnoreCase))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Not available course for Maasin City Campus\n");
                        goto MaasinCOURSE;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    goto c;
                }

                /*  
                  Console.Write("Enter Choosen course: ");
                  course[x] = Console.ReadLine();
                */

                //add index (x)
                x++;

                while (true)
                {
                    Console.Write("\n\t\t\tSubmit? [y/n]: ");
                    string submit = Console.ReadLine().Trim();

                    if (submit == "Y" || submit == "y")
                    {
                        Console.WriteLine("\nRegister Success. \n");

                        //ihapon kung pila ang niregister para ma call sa view students
                        Regcount++;

                        break;
                    }
                    else if (submit == "n" || submit == "N")
                    {
                        Console.WriteLine("Registration cancelled.");
                        //minusan ug 1 if i cancel submit
                        x--;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input\n");
                    }

                }
            RegA:
                Console.Write("\nRegister Again? [y/n]: ");
                register = Console.ReadLine().Trim();

                if (register == "y" || register == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (register == "n" || register == "N")
                {
                    Console.WriteLine("\nRegistration Done.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!\n");
                    goto RegA;
                }

            } while (register == "Y" || register == "y");

        }



        //View All Campuses
        static void AllCampuses()
        {
            /*
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("SOUTHERN LEYTE STATE UNIVERSITY (SLSU) ALL CAMPUSES\n");
            Console.ResetColor();
            */

            string[] Campus = { "[A] Main Campus (Sogod)", "[B] Hinunangan Campus", "[C] Tomas Oppus Campus", "[D] Bontoc Campus", "[E] San Juan Campus", "[F] Maasin City Campus" };

            foreach (string AllCampus in Campus)
            {
                Console.WriteLine(" " + AllCampus);
            }

        }


        //View Course Offered
        static void CourseOffer()
        {

            string[] MC = { "\nBachelor of Elementary Education\n\t\t- General Education",
                "\nBachelor of Industrial Technology\n   - Automotive Technology ",
                "\t\t- Drafting Technology\n\t\t- Electrical Technology\n\t\t- Electronics Technology\n\t\t- Food Preparation and Services Technology\n\t\t- Heating, Ventilation, Air-Conditioning and Refrigeration Technology ",
                "\n Bachelor of Technology and Livelihood Education\n\t\t- Home Economics\n\t\t- Industrial Arts\n\t\t- Information and Communication Technology\n",
                " BS in Civil Engineering",
                " BS in Computer Engineering",
                " BS in Criminology",
                " BS in Electrical Engineering",
                " BS in Food Technology",
                " BS in Tourism Management",
                " BS in Information Technology \n\t\t*Programming\n\t\t*Networking" };


            //AllCampuses();

            string[] HC =     { " Bachelor of Agricultural Technology",
                            " Bachelor of Secondary Education",
                            "  - English",
                            "  - Mathematics",
                            "  - Science",
                            "\n Bachelor of Technology and Livelihood Education",
                            "  - Agri-Fishery Arts",
                            "  - Information  Communication Technology",
                            "\n BS in Agribusiness",
                            "\n BS in Agriculture",
                            "  - Animal Science",
                            "  - Crop Science",
                            "  - General",
                            " BS in Agricultural Entrepreneurship",
                            " BS in Environmental Science",
                            " BS in Information Technology"
                            };

            string[] TO = { " Bachelor of Secondary Education",
                            "  - English",
                            "  - Filipino",
                            "  - Mathematics",
                            "  - Science",
                            "  - Social Studies",
                            "\n Bachelor of Elementary Education",
                            "  - General Education",
                            "\n BS in Business Administration",
                            "  - Human Resource Management",
                            "  - Marketing Management",
                            " BS in Information Technology",
                            "  - Programming"
                            };

            string[] Bontoc = {
                           "\n Bachelor of Science in Fisheries (BSFi)",
                           " Bachelor of Science in Information Technology (BSIT)",
                           " Bachelor of Science in Agriculture (BSA)",
                           " Bachelor of Science in Marine Biology (BSMB)",
                           " Bachelor of Agriculture and Technology (BAT)"
                             };

            string[] SanJuan = {
                            "\n Bachelor of Industrial Technology",
                            "  - Automotive Technology",
                            "  - Electrical Technology",
                            "  - Electronics Technology",

                            "\n Bachelor of Secondary Education",
                            "  - Biological Science",
                            "  - English",
                            "  - Filipino",
                            "  - Mathematics",

                           "\n BS in Entrepreneurship",
                            "  - Social Entrepreneurship",
                            "  - Culinary Arts",
                            "  - Hospitality Management",

                            "\n BS in Information Technology",
                            " BS in Office Administration",
                            " BS in Accountancy",
                            " BS in Management Accounting",

                            "\n Bachelor of Technology and Livelihood Education",
                            "  - Home Economics",
                            "  - Industrial Arts"
                            };


            string[] Maasin = {
                            " Bachelor in Social Work - Old Curriculum",
                            " Bachelor in Social Work - New Curriculum",
                            " Bachelor in Public Administration"

                           };


            string campus; string ask1;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("SOUTHERN LEYTE STATE UNIVERSITY (SLSU) COURSE OFFERED\n");
                Console.ResetColor();

                AllCampuses();

            camp:
                Console.Write("\nChoose campus to see course offered [A, B, C, D, E, F]: ");
                campus = Console.ReadLine();

                switch (campus)
                {
                    case "A":
                    case "a":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - Main Campus (Sogod) Course Offered\n");
                        Console.ResetColor();

                        foreach (string MainCourse in MC)
                        {
                            Console.WriteLine(MainCourse);
                        }
                        break;

                    case "B":
                    case "b":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - Hinunangan Campus Course Offered\n");
                        Console.ResetColor();

                        foreach (string HinunanganCourse in HC)
                        {
                            Console.WriteLine(HinunanganCourse);
                        }

                        break;

                    case "C":
                    case "c":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - Tomas Oppus Campus Course Offered\n");
                        Console.ResetColor();

                        foreach (string TomasOppus in TO)
                        {
                            Console.WriteLine(TomasOppus);
                        }

                        break;

                    case "D":
                    case "d":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - Bontoc Campus Course Offered\n");
                        Console.ResetColor();

                        foreach (string BontocCampus in Bontoc)
                        {
                            Console.WriteLine(BontocCampus);
                        }

                        break;

                    case "E":
                    case "e":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - San Juan Campus Course Offered\n");
                        Console.ResetColor();

                        foreach (string SanJuanCampus in SanJuan)
                        {
                            Console.WriteLine(SanJuanCampus);
                        }

                        break;

                    case "F":
                    case "f":
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Southern Leyte State University - Maasin City Campus Course Offered\n");
                        Console.ResetColor();

                        foreach (string MaasinCampus in Maasin)
                        {
                            Console.WriteLine(MaasinCampus);
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid Input\n");
                        goto camp;
                        // break;
                }


            a1:
                Console.Write("\nChoose Another Campus to see the Course Offered? [y/n]: ");
                ask1 = Console.ReadLine().Trim();

                if (ask1 == "Y" || ask1 == "y")
                {
                    continue;
                }
                else if (ask1 == "N" || ask1 == "n")
                {
                    Console.WriteLine("\nView Course Cancelled.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input\n");
                    goto a1;
                }

            } while (ask1 == "y" || ask1 == "Y");

        }



        //View Registered Students
        static void ViewRegisteredStudents()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n| REGISTERED STUDENTS IN SOUTHERN LEYTE STATE UNIVERSITY |\n\n");
            Console.ResetColor();

            if (Regcount == 0 || x == 0)
            {
                Console.WriteLine("No Registered Students.");
            }
            else
            {

                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║      Full Name          |          Course           |        Campus         |      Address          ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                for (int i = 0; i < x; i++)
                {
                   Console.WriteLine("║{0,-27} {1,-27} {2,-27} {3,12}    ║", FullName[i], course[i], campus[i], Address[i]);
                   Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                }

            }
        }



        //search students
        static void SearchStudents()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t\t\t| SEARCH REGISTERED STUDENTS IN SLSU |");
            Console.ResetColor();

            Console.WriteLine("\n\t\tPress Any Key To Start Searching...");
            Console.ReadKey();

            string SearchAgain;
            do
            {
                //count student register
                int count = 0;

                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\t\t\tSearch students by typing the name...");

                Console.Write("\n\n\t\t\t\tSearch Name: ");
                string name = Console.ReadLine().Trim();


                for (int search = 0; search < x; search++)
                {
                    if (name.Equals(FullName[search], StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("\n\n\tStudent Found! \n Press any key to see Student Information...");
                        Console.ReadKey();

                        Console.WriteLine("\n\nName          : " + FullName[search]);
                        Console.WriteLine("Age           : " + Age[search]);
                        Console.WriteLine("Sex           : " + sex[search]);
                        Console.WriteLine("Contact Number: +63{0}", Contact[search]);
                        Console.WriteLine("Address       : " + Address[search]);
                        Console.WriteLine("Year          : " + year[search]);
                        Console.WriteLine("SLSU Campus   : " + campus[search]);
                        Console.WriteLine("Choosen course: " + course[search]);

                        count++;
                    }

                    /*
                else if (name != FullName[search])
                {
                    Console.WriteLine("\nNo students registered...");
                }
                    else if (name == " ")
                    {
                        Console.WriteLine("\nNo students registered...");
                    }
                    */
                }


                if (count == 0)
                {
                    Console.WriteLine("\n\tStudent Name not yet Registered!");
                }

            SearchA:
                Console.Write("\n\n\n\tSearch Again [y/n] ? : ");
                SearchAgain = Console.ReadLine().Trim();


                if (SearchAgain == "Y" || SearchAgain == "y")
                {
                    continue;
                }
                else if (SearchAgain == "N" || SearchAgain == "n")
                {
                    Console.WriteLine("\n\t\t\tDone Searching.\n");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\t\tInvalid Input!");
                    Console.ResetColor();
                    goto SearchA;
                }

            } while (SearchAgain == "Y" || SearchAgain == "y");
        }



        static void UpdateCourse()
        {
            // int count = 0;
            string AskShift, SearchAg;


            do
            {
                bool IsFound = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t| UPDATE COURSE |");
                Console.ResetColor();

                Console.Write("\n\nEnter Name of Registered students to shift course: ");
                string Shift = Console.ReadLine();

                for (int s = 0; s < x; s++)
                {

                    if (FullName[s] != null && FullName[s].Equals(Shift, StringComparison.InvariantCultureIgnoreCase))
                    {
                        IsFound = true;

                        Console.WriteLine("\nThis is the your status\n");
                        Console.WriteLine("\n\nName          : " + FullName[s]);
                        Console.WriteLine("Age           : " + Age[s]);
                        Console.WriteLine("Sex           : " + sex[s]);
                        Console.WriteLine("Contact Number: +63{0}", Contact[s]);
                        Console.WriteLine("Address       : " + Address[s]);
                        Console.WriteLine("Year          : " + year[s]);
                        Console.WriteLine("SLSU Campus   : " + campus[s]);
                        Console.WriteLine("Choosen course: " + course[s]);

                    i:
                        Console.Write("\n\n\t\t\t\t\t\tDo you want to Shift Course? [y/n]: ");
                        AskShift = Console.ReadLine();

                        if (AskShift == "y" || AskShift == "Y")
                        {
                            Console.WriteLine("\n\t\tChange Course");
                            Console.WriteLine("\nYour choosen course: {0}", course[s]);
                            Console.Write("\n\n\t\t\tEnter your updated course: ");
                            course[s] = Console.ReadLine();

                            Console.WriteLine("Changing course Updated\n");

                            //para mahibaw an if naay niregister
                            //count++;

                        }
                        else if (AskShift == "N" || AskShift == "n")
                        {
                            Console.WriteLine("Changing course cancelled");
                            //  count++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input\n");
                            goto i;
                        }

                        //break;

                    }
                    /*
                    else
                    {
                        Console.WriteLine("\nname not yet registered.\n");
                        break;
                    }*/


                }


                if (!IsFound)
                {
                    Console.WriteLine("\nname not yet registered.\n");
                    // break;
                }

            /*
            if (!IsFound)
             {
                 Console.WriteLine("\nname not yet registered.\n");
                // break;
             }*/



            SEARCHAG:
                Console.Write("\n\t\t\t\t\tSearch Again [y/n]? : ");
                SearchAg = Console.ReadLine();


                if (SearchAg == "Y" || SearchAg == "y")
                {
                    continue;
                }
                else if (SearchAg == "N" || SearchAg == "n")
                {
                    Console.WriteLine("\t\tDone Searching.\n");
                    // return;
                    break;
                }
                else
                {
                    Console.WriteLine("\t\tInvalid Input!\n");
                    goto SEARCHAG;
                }

            } while (SearchAg == "y" || SearchAg == "Y");


        }


        static void DeleteStudents()
        {
            string InpRemove, InputAgain;
            //  bool FoundDel = false;

            do
            {
                int delcount = 0;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\t\t\t\t\t| REMOVE REGISTER STUDENTS |");
                Console.ResetColor();

                Console.Write("\nInput name of students you want to Remove : ");
                string inp = Console.ReadLine().Trim();

                for (int delete = 0; delete < FullName.Length; delete++)
                {
                    if (inp.Equals(FullName[delete], StringComparison.InvariantCultureIgnoreCase))
                    {
                        delcount++;

                        Console.WriteLine("\nRegister Student found\n\n");
                        Console.WriteLine("\t\t\t\t___________________________________");
                        Console.WriteLine("Name          : " + FullName[delete]);
                        Console.WriteLine("Age           : " + Age[delete]);
                        Console.WriteLine("Sex           : " + sex[delete]);
                        Console.WriteLine("Contact Number: +63{0}", Contact[delete]);
                        Console.WriteLine("Address       : " + Address[delete]);
                        Console.WriteLine("Year          : " + year[delete]);
                        Console.WriteLine("SLSU Campus   : " + campus[delete]);
                        Console.WriteLine("Choosen course: {0}", course[delete]);

                    //while (true)

                    r:
                        Console.Write("\n\n\t\tAre you sure you want to Remove this student? [y/n]: ");
                        InpRemove = Console.ReadLine();

                        if (InpRemove == "y" || InpRemove == "Y")
                        {
                            // FoundDel = true;
                            for (int i = delete; i < x - 1; i++)
                            {

                                FullName[i] = FullName[i + 1];
                                Age[i] = Age[i + 1];
                                sex[i] = sex[i + 1];
                                Contact[i] = Contact[i + 1];
                                Address[i] = Address[i + 1];
                                year[i] = year[i + 1];
                                campus[i] = campus[i + 1];
                                course[i] = course[i + 1];

                                /*
                                FullName[i + 1] = null;
                                Age[i + 1] = 0;
                                sex[i + 1] = null;
                                Contact[i + 1] = 0;
                                Address[i + 1] = null;
                                campus[i + 1] = null;
                                course[i + 1] = null;
                                x--;
                                */

                            }

                            FullName[x - 1] = null;
                            Age[x - 1] = 0;
                            sex[x - 1] = null;
                            Contact[x - 1] = 0;
                            Address[x - 1] = null;
                            campus[x - 1] = null;
                            course[x - 1] = null;
                            x--;
                            Console.WriteLine("\nSuccessfully Removed");

                            //count para sa checking if naa bay ni register or wa
                            //delcount++;
                            break;
                        }
                        else if (InpRemove == "n" || InpRemove == "N")
                        {
                            Console.WriteLine("\n\tRemove cancelled.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tInvalid input\n");
                            goto r;
                        }

                    }
                }

                if (delcount == 0)
                {
                    Console.WriteLine("\n\tStudent Name not yet Registered!");
                }

            input:
                Console.Write("\n\t\t\tInput Again? [y/n]: ");
                InputAgain = Console.ReadLine().Trim();

                if (InputAgain == "Y" || InputAgain == "y")
                {
                    continue;
                }
                else if (InputAgain == "n" || InputAgain == "N")
                {
                    Console.WriteLine("\n\tInput cancelled.");
                    break;
                }
                else
                {
                    Console.WriteLine("\tInvalid input\n");
                    goto input;
                }


            } while (InputAgain == "y" || InputAgain == "Y");


        }

    }
}


