using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.QuestionTypes
{
    class MultichoiceQuestion : Question
    {

        public int Choices { get; private set; }
        public string C1 { get; }
        public string C2 { get; }
        public string C3 { get; }
        public string C4 { get; }
        public int CorrectAnswer { get; }

        public MultichoiceQuestion(string text, string c1, string c2, string c3, int correctAnswer) : this(text, c1, c2, c3, "", correctAnswer) { }
        public MultichoiceQuestion(string text, string c1, string c2, int correctAnswer) : this(text, c1, c2, "", "", correctAnswer) { }

        public MultichoiceQuestion(string text, string c1, string c2, string c3, string c4, int correctAnswer) : base(text, QuestionType.Multi)
        {
            if(c1 != "")
            {
                Choices++;
            }
            if (c2 != "")
            {
                Choices++;
            }
            if (c3 != "")
            {
                Choices++;
            }
            if (c4 != "")
            {
                Choices++;
            }
            C1 = c1;
            C2 = c2;
            C3 = c3;
            C4 = c4;
            CorrectAnswer = correctAnswer;
        }

        public string GetQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    return C1;
                case 2:
                    return C2;
                case 3:
                    return C3;
                case 4:
                    return C4;
            }
            throw new Exception("ERROR: Question outside of options");
        }

        public string GetCorrect()
        {
            switch (CorrectAnswer)
            {
                case 1:
                    return C1;
                case 2:
                    return C2;
                case 3:
                    return C3;
                case 4:
                    return C4;
            }
            throw new Exception("ERROR: Question outside of options");
        }
    }
}
