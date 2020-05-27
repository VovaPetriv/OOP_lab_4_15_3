using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_15_3
{
    class Progress
    {
        private string _surename;
        private string _groupName;
        private int _mathMark;
        private int _englishMark;
        private int _ukrainianMark;

        public string Surename
        {
            get => _surename;
            set => _surename = value;
        }

        public string GroupName
        {
            get => _groupName;
            set => _groupName = value;
        }

        public int MathMark
        {
            get => _mathMark;
            set => _mathMark = value;
        }

        public int EndlishMark
        {
            get => _englishMark;
            set => _englishMark = value;
        }

        public int UkrainianMark
        {
            get => _ukrainianMark;
            set => _ukrainianMark = value;
        }

        private static string UkrainianI(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                if (ch[i] == '?')
                {
                    ch[i] = 'i';
                }
            }

            return new string(ch);
        }

        public Progress()
        {
            _surename = "Не вказано";
            _groupName = "Не вказано";
            _mathMark = 0;
            _englishMark = 0;
            _ukrainianMark = 0;
        }

        public Progress(string surename, string groupName, int mathMark, int englishMark, int ukrainianMark)
        {
            _surename = UkrainianI(surename);
            _groupName = UkrainianI(groupName);
            _mathMark = mathMark;
            _englishMark = englishMark;
            _ukrainianMark = ukrainianMark;
        }
    }
}
