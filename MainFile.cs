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
