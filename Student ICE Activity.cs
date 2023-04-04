using System;
internal class Program
{
    private static int Main(string[] args)
    {
        string[] studnum = { "ST100", "ST101", "ST102", "ST103", "ST104", "ST105", "ST106", "ST107", "ST108", "ST109", "ST110" };
        int[,] marks = new int[11, 6];

        Console.Write("\n\nStudents Averages\n");
        Console.Write("*********************\n");

        for (int a = 0; a < 11; a++)
        {
            for (int z = 0; z < 6; z++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter marks for {0} ", studnum[a]);

                Console.WriteLine("Please enter test 1 mark: ");
                String test1 = Console.ReadLine();

                Console.WriteLine("Please enter test 2 mark: ");
                String test2 = Console.ReadLine();

                int mk1 = Convert.ToInt32(test1);
                int mk2 = Convert.ToInt32(test2);

                int rs = Varsity(mk1, mk2); // CALLING FUNCTION VARSITY
                Console.WriteLine("Your result is " + rs);
                Results(rs);

                static int Varsity(int m1, int m2)
                {
                    int results = 0;
                    results = m1 + m2;

                    return results; //CALLING FUNCTION RESULTS
                }
                static void Results(int total)
                {
                    int average = total / 2;
                    if (average < 50)
                    {
                        Console.WriteLine("Average is " + average + " FAIL");
                    }
                    else if (average < 75)
                    {
                        Console.WriteLine("Average is " + average + " PASS");
                    }
                    else
                    {
                        Console.WriteLine("Average is " + average + " DISTINCTION");
                    }
                }
            }
        }
        for (int a = 0; a < 11; a++)
        {
            for (int z = 0; z < 6; z++)
            {
                Console.Write("Student No. \t\tMK1 \t\tMK2 \t\tSum \t\tAve \t\tResults");
                Console.Write(marks[a, z] + " ");
                marks[a, z] = Convert.ToInt32(Console.ReadLine);
            }
            Console.WriteLine();
        }
        return 0;
    }

}