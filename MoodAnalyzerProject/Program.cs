using System;

namespace MoodAnalyserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message: ");
            string message = Console.ReadLine();

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            Console.WriteLine("Mood is :" + moodAnalyser.AnalyseMood());
        }
    }
}
