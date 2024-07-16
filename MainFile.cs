using System; //Only need

namespace Practises
{
    internal class MainFile
    {
        static void Main(string[] args)
        {
            //Patika Greeting
            PatikaGreeting greeting = new PatikaGreeting();
            greeting.Task();

            //Conditionals Practice
            ConditionalsPractice conditionalsPractice = new ConditionalsPractice();
            conditionalsPractice.Task();

            //Switch Practice
            SwitchPractise switchPractise = new SwitchPractise();
            switchPractise.Task();

            //For Practise
            ForLoopPractises forLoopPractises = new ForLoopPractises();
            forLoopPractises.Task();

            //Mini Quiz Program
            QuizProgramPractise quizProgramPractise = new QuizProgramPractise();
            quizProgramPractise.Task();
        }
    }
}
