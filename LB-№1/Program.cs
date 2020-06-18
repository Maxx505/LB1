using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB__1
{
    class Documents
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public string Functions { get; set; }
        public Documents(string type, int size, string functions)
        {
            Type = type;
            Size = size;
            Functions = functions;
        }
    }

    class Essay : Documents
    {
        public string TopicOfEssay { get; set; }
        public Essay(string type, int size, string functions, string topic) : base(type, size, functions)
        {
            this.TopicOfEssay = topic;
        }

        public virtual void Analysis()
        {
            Console.WriteLine(Type + Size + Functions + TopicOfEssay);
        }
    }

    class Lecture : Documents
    {
        public double TimeLecture { get; set; }
        public Lecture(string type, int size, string functions, double time) : base(type, size, functions)
        {
            TimeLecture = time;
        }

        public virtual void Analysis()
        {
            Console.WriteLine(Type + Size + Functions + TimeLecture);
        }
    }

    class Form : Documents
    {
        public int NumberOfQuestions { get; set; }
        public string Company { get; set; }
        public Form(string type, int size, string functions, int number, string company) : base(type, size, functions)
        {
            NumberOfQuestions = number;
            Company = company;
        }

        public virtual void Analysis()
        {
            Console.WriteLine(Type + Size + Functions + NumberOfQuestions + Company);
        }
    }   

    class Program
    {
        private static void Main(string[] args)
        {
            Essay essay = new Essay("Тип - Реферат, объём - ",5,", функция - информативная и познавательная, "," тема - современные цвета");
            essay.Analysis();
            Lecture lect = new Lecture("Тип - Лекция, объём - ",15,", функция - обучающая и развивающая, общее время - ",2.30);
            lect.Analysis();
            Form form = new Form("Тип - Анкета, объём - ",2,", функция - информационная и контрольная, количество вопросов - ",27,", компания - Samsung");
            form.Analysis();
            Console.ReadKey();
        }
    }
}
