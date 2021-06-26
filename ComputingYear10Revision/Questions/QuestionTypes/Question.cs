using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{

    public enum QuestionType
    {
        Explain,
        Number,
        Exact
    }

    class Question
    {
        public Question(string text, QuestionType type)
        {
            Text = text;
            Type = type;
        }

        public string Text { get; }
        public QuestionType Type { get; }
    }
}
