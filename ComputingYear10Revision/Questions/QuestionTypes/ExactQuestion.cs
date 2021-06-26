using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{
    class ExactQuestion : Question
    {
        public ExactQuestion(string text, List<string> acceptedAnswers) : base(text, QuestionType.Exact)
        {
            AcceptedAnswers = acceptedAnswers;
        }

        public List<string> AcceptedAnswers { get; }
    }
}
