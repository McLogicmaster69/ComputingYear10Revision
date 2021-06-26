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
        Number
    }

    class Question
    {
        public Question(string text, bool selfMark, QuestionType type)
        {
            Text = text;
            SelfMark = selfMark;
            Type = type;
        }

        public string Text { get; }
        public bool SelfMark { get; }
        public QuestionType Type { get; }
    }
}
