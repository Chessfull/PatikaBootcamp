using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practises
{
    internal class MainFile
    {
        static void Main(string[] args)
        {
            //Do While / While difference Practise
            DoWhilePractises doWhilePractises = new DoWhilePractises();
            doWhilePractises.Task();
                
            //While Practice
            WhilePractises whilePractises = new WhilePractises();
            whilePractises.Task();

            //For Practise
            ForLoopPractises forLoopPractises = new ForLoopPractises();
            forLoopPractises.Task();

            //Mini Quiz Program
            QuizProgramPractise quizProgramPractise = new QuizProgramPractise();
            quizProgramPractise.Task();

            //Switch Practice
            SwitchPractise switchPractise = new SwitchPractise();
            switchPractise.Task();

            //Conditionals Practice
            ConditionalsPractice conditionalsPractice = new ConditionalsPractice();
            conditionalsPractice.Task();

            //Patika Greeting
            PatikaGreeting greeting = new PatikaGreeting();
            greeting.Task();
        }
    }
}
