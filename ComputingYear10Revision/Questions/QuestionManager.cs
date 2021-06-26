using ComputingYear10Revision.Questions.QuestionTypes;
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
        private bool AddToScore = false;
        public int TotalQuestions { get; private set; }
        public int CorrectQuestions { get; set; }

        public QuestionManager(Label questionLabel, Label answerLabel, Label compareLbl, Button continueBtn, Button correctBtn, Button incorrectBtn, Button answerBtn, TextBox userAnswer, NumericUpDown userNumberAnswer, QuestionCompiler compiler, StatManager stats)
        {
            QuestionLabel = questionLabel;
            AnswerLabel = answerLabel;
            CompareLbl = compareLbl;
            ContinueBtn = continueBtn;
            CorrectBtn = correctBtn;
            IncorrectBtn = incorrectBtn;
            AnswerBtn = answerBtn;
            UserAnswer = userAnswer;
            UserNumberAnswer = userNumberAnswer;
            Compiler = compiler;
            Stats = stats;
        }

        public void NextQuestion()
        {
            if (AddToScore)
            {
                CorrectQuestions++;
                AddToScore = false;
            }
            Current = Compiler.Chuck();
            QuestionLabel.Text = Current.Text;
            Stats.UpdatePercent(TotalQuestions, CorrectQuestions);
            TotalQuestions++;
            SwitchMain(true);
            switch (Current.Type)
            {
                case QuestionType.Explain:
                case QuestionType.Exact:
                    SwitchUserAnswer(true);
                    break;
                case QuestionType.Number:
                    SwitchNumberAnswer(true);
                    break;
            }
            UpdateStatText();
        }

        public void MarkQuestion()
        {
            SwitchMain(false);
            switch (Current.Type)
            {
                case QuestionType.Explain:
                    SwitcthCorrectBtns(true);
                    SetCorrectAnswer(((ExplainQuestion)Current).ExpectedAnswer);
                    ChangeCompareAnswer(UserAnswer.Text);
                    break;
                case QuestionType.Number:
                    SwitchContinueButton(true);
                    if(((NumberQuestion)Current).Answer == (float)UserNumberAnswer.Value)
                    {
                        AddToScore = true;
                    }
                    SetCorrectAnswer(((NumberQuestion)Current).Answer.ToString());
                    ChangeCompareAnswer(UserNumberAnswer.Value.ToString());
                    break;
                case QuestionType.Exact:
                    SwitchContinueButton(true);
                    SetCorrectAnswer(((ExactQuestion)Current).AcceptedAnswers[0]);
                    foreach (string answer in ((ExactQuestion)Current).AcceptedAnswers)
                    {
                        if(answer.ToLower() == UserAnswer.Text.ToLower())
                        {
                            AddToScore = true;
                            SetCorrectAnswer(answer);
                            break;
                        }
                    }
                    ChangeCompareAnswer(UserAnswer.Text);
                    break;
            }
            UpdateStatText();
        }

        private void SwitchMain(bool question)
        {
            AnswerBtn.Visible = question;
            QuestionLabel.Visible = question;
            AnswerLabel.Visible = !question;
            CompareLbl.Visible = !question;

            SwitcthCorrectBtns(false);
            SwitchUserAnswer(false);
            SwitchNumberAnswer(false);
            SwitchContinueButton(false);
        }

        private void UpdateStatText()
        {
            Stats.UpdateStats((TotalQuestions - 1).ToString(), CorrectQuestions.ToString(), TotalQuestions.ToString());
        }

        private void SwitcthCorrectBtns(bool shown)
        {
            CorrectBtn.Visible = shown;
            IncorrectBtn.Visible = shown;
        }

        private void SwitchUserAnswer(bool shown)
        {
            UserAnswer.Visible = shown;
        }

        private void SwitchNumberAnswer(bool shown)
        {
            UserNumberAnswer.Visible = shown;
        }

        private void SwitchContinueButton(bool shown)
        {
            ContinueBtn.Visible = shown;
        }

        private void ChangeCompareAnswer(string text)
        {
            CompareLbl.Text = text;
            UserAnswer.Text = "";
            UserNumberAnswer.Value = 0;
        }

        private void SetCorrectAnswer(string Answer)
        {
            AnswerLabel.Text = Answer;
        }

        public Label QuestionLabel { get; }
        public Label AnswerLabel { get; }
        public Label CompareLbl { get; }
        public Button ContinueBtn { get; }
        public Button CorrectBtn { get; }
        public Button IncorrectBtn { get; }
        public Button AnswerBtn { get; }
        public TextBox UserAnswer { get; }
        public NumericUpDown UserNumberAnswer { get; }
        public QuestionCompiler Compiler { get; }
        public StatManager Stats { get; }
    }
}
