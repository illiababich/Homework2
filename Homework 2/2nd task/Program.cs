using System;
using System.Collections.Generic;

namespace _2nd_task
{
    public abstract class Coherent
    {
        protected string Text_Discription = "";
    }

    class Training : Coherent
    {
        public List<Coherent> LecrurePractice = new List<Coherent>();

        public void Add(Coherent value)
        {
            LecrurePractice.Add(value);
        }
    }

    class Lecture : Coherent
    {
        public string Topic;

        public string TextDiscription
        {
            get { return Text_Discription; }
            set { Text_Discription = value; }
        }

    }
    
    class Practical_lesson : Coherent
    {
        public string Link;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture();
            lecture.TextDiscription = "Test";
            Console.WriteLine(lecture.TextDiscription);
        }
    }
}
