using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{
    class MultipleNumberQuestion : Question
    {
        public MultipleNumberQuestion(string text, List<float> acceptedAnswers) : base(text, QuestionType.MultiNumber)
        {
            AcceptedAnswers = acceptedAnswers;
        }

        public List<float> AcceptedAnswers { get; }
    }
}
