using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{
    class ExplainQuestion : Question
    {
        public ExplainQuestion(string text, string expectedAnswer) : base(text, true, QuestionType.Explain)
        {
            ExpectedAnswer = expectedAnswer;
        }

        public string ExpectedAnswer { get; }
    }
}
