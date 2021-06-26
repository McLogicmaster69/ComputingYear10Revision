using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingYear10Revision.Questions
{
    sealed class QuestionManager
    {

        private Question Current;

        public QuestionManager(Label questionLabel, Label answerLabel)
        {
            QuestionLabel = questionLabel;
            AnswerLabel = answerLabel;
        }

        public void SetQuestion(Question question)
        {
            QuestionLabel.Text = question.Text;
            Current = question;
        }

        public void SetAnswer()
        {
            AnswerLabel.Text = Current.ExpectedAnswer;
        }

        public Label QuestionLabel { get; }
        public Label AnswerLabel { get; }
    }
}
