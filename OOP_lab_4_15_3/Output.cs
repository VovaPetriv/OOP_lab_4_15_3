using System;

namespace OOP_lab_4_15_3
{
    class Output
    {
        public const string Format = "{0, -20} {1, -10} {2, -25} {3, -30} {4, -30}";

        public static void Write()
        {
            Console.WriteLine(Format, "Прiзище", "Група", "Оцiнка з математики", "Оцiнка з Англiйської мови", "Оцiнка з Української мови");

            for (int i = 0; i < Program.students.Length; ++i)
            {
                Console.WriteLine(Output.Format, Program.students[i].Surename, Program.students[i].GroupName, Program.students[i].MathMark, Program.students[i].EndlishMark, Program.students[i].UkrainianMark);
            }
        }
    }
}
