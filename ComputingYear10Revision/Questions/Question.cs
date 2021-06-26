using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions
{
    class Question
    {
        public Question(string text, string expectedAnswer)
        {
            Text = text;
            ExpectedAnswer = expectedAnswer;
        }

        public string Text { get; }
        public string ExpectedAnswer { get; }
    }
}
