using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{
    class NumberQuestion : Question
    {
        public NumberQuestion(string text, float answer) : base(text, false, QuestionType.Number)
        {
            Answer = answer;
        }

        public float Answer { get; }
    }
}
