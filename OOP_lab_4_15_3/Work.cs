using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace OOP_lab_4_15_3
{
    class Work
    {
        public static void Add()
        {
            StreamWriter file = new StreamWriter("base.txt", true);

            Console.WriteLine("\nВведiть новi данi");

            Console.Write("Прiзище: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Група: ");

            file.WriteLine(Console.ReadLine());
        
        RetryMath:
            Console.Write("Оцiнка з математики: ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Оцiнка має бути вказана лише числом!");

                goto RetryMath;
            }

        RetryEng:
            Console.Write("Оцiнка з Англiйської мови: ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Оцiнка має бути вказана лише числом!");

                goto RetryEng;
            }

        RetryUkr:
            Console.Write("Оцiнка з Української мови: ");

            try
            {
                file.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Оцiнка має бути вказана лише числом!");

                goto RetryUkr;
            }

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Remove()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для видалення: ");

            bool[] remove = new bool[Program.students.Length];

            for (int i = 0; i < remove.Length; ++i)
            {
                remove[i] = false;
            }

            try
            {
                remove[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.students.Length; ++i)
            {
                if (!remove[i])
                {
                    file.WriteLine(Program.students[i].Surename);
                    file.WriteLine(Program.students[i].GroupName);
                    file.WriteLine(Program.students[i].MathMark);
                    file.WriteLine(Program.students[i].EndlishMark);
                    file.WriteLine(Program.students[i].UkrainianMark);
                }
            }

            Console.Write("Видалено.\n");

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Edit()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для редагування: ");

            bool[] edit = new bool[Program.students.Length];

            for (int i = 0; i < edit.Length; ++i)
            {
                edit[i] = false;
            }

            try
            {
                edit[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.students.Length; ++i)
            {
                if (edit[i])
                {
                    Console.WriteLine("\nВведiть новi данi");

                    Console.Write("Прiзище: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Група: ");

                    file.WriteLine(Console.ReadLine());

                RetryMath:
                    Console.Write("Оцiнка з математики: ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Оцiнка має бути вказана лише числом!");

                        goto RetryMath;
                    }

                RetryEng:
                    Console.Write("Оцiнка з Англiйської мови: ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Оцiнка має бути вказана лише числом!");

                        goto RetryEng;
                    }

                RetryUkr:
                    Console.Write("Оцiнка з Української мови: ");

                    try
                    {
                        file.WriteLine(int.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Оцiнка має бути вказана лише числом!");

                        goto RetryUkr;
                    }
                }
                else
                {
                    file.WriteLine(Program.students[i].Surename);
                    file.WriteLine(Program.students[i].GroupName);
                    file.WriteLine(Program.students[i].MathMark);
                    file.WriteLine(Program.students[i].EndlishMark);
                    file.WriteLine(Program.students[i].UkrainianMark);
                }
            }

            Console.Write("Змiни внесено.\n");

            file.Close();

            Console.WriteLine();

            Input.Read();
        }

        public static void Find()
        {
            Console.Write("Група: ");

            string group = Console.ReadLine();

            Console.WriteLine(Output.Format, "Прiзище", "Група", "Оцiнка з математики", "Оцiнка з Англiйської мови", "Оцiнка з Української мови");

            for (int i = 0; i < Program.students.Length; ++i)
            {
                if (group == Program.students[i].GroupName)
                {
                    Console.WriteLine(Output.Format, Program.students[i].Surename, Program.students[i].GroupName, Program.students[i].MathMark, Program.students[i].EndlishMark, Program.students[i].UkrainianMark);
                }
            }

            Console.WriteLine();

            Input.Read();
        }

        public static void Sort()
        {
            Program.students = Program.students.OrderBy(x => x.Surename).ToArray();

            Output.Write();

            Console.WriteLine();

            Input.Read();
        }

        public static void Initialisation(string allBase)
        {
            string[] elements = allBase.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);

            Program.students = new Progress[elements.Length / 5];

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.students[i / 5] = new Progress(elements[i], elements[i + 1], int.Parse(elements[i + 2]), int.Parse(elements[i + 3]), int.Parse(elements[i + 4]));
            }
        }
    }
}
