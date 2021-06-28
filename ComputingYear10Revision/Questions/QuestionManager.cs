﻿using ComputingYear10Revision.Questions.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private int SelectedAnswer = -1;
        private Button CurrentChoice;
        public int TotalQuestions { get; private set; }
        public int CorrectQuestions { get; set; }

        public QuestionManager(Label questionLabel, Label answerLabel, Label compareLbl, Button continueBtn, Button correctBtn, Button incorrectBtn, Button answerBtn, TextBox userAnswer, NumericUpDown userNumberAnswer, QuestionCompiler compiler, StatManager stats, MultichoiceManager multi)
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
            Multi = multi;
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
            SelectedAnswer = -1;
            TotalQuestions++;
            SwitchMain(true);
            switch (Current.Type)
            {
                case QuestionType.Explain:
                case QuestionType.Exact:
                    SwitchUserAnswer(true);
                    break;
                case QuestionType.Number:
                case QuestionType.MultiNumber:
                    SwitchNumberAnswer(true);
                    break;
                case QuestionType.Multi:
                    AnswerBtn.Enabled = false;
                    if (((MultichoiceQuestion)Current).C4 != "")
                    {
                        Multi.C4.Visible = true;
                        Multi.C3.Visible = true;
                        Multi.C4.Text = ((MultichoiceQuestion)Current).C4;
                        Multi.C3.Text = ((MultichoiceQuestion)Current).C3;
                        Multi.C1.Location = new Point { X = 408, Y = 90};
                        Multi.C2.Location = new Point { X = 408, Y = 134};
                        Multi.C3.Location = new Point { X = 408, Y = 178};
                        Multi.C3.Location = new Point { X = 408, Y = 222};
                    }
                    else if (((MultichoiceQuestion)Current).C3 != "")
                    {
                        Multi.C3.Visible = true;
                        Multi.C3.Text = ((MultichoiceQuestion)Current).C3;
                        Multi.C1.Location = new Point { X = 408, Y = 112 };
                        Multi.C2.Location = new Point { X = 408, Y = 156 };
                        Multi.C3.Location = new Point { X = 408, Y = 200 };
                    }
                    else
                    {
                        Multi.C1.Location = new Point { X = 408, Y = 134 };
                        Multi.C2.Location = new Point { X = 408, Y = 178 };
                    }
                    Multi.C1.Visible = true;
                    Multi.C2.Visible = true;
                    Multi.C1.Text = ((MultichoiceQuestion)Current).C1;
                    Multi.C2.Text = ((MultichoiceQuestion)Current).C2;

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
                case QuestionType.Multi:
                    CurrentChoice.BackColor = Color.Red;
                    SwitchContinueButton(true);
                    SetCorrectAnswer(((MultichoiceQuestion)Current).GetQuestion(SelectedAnswer));
                    if(SelectedAnswer == ((MultichoiceQuestion)Current).CorrectAnswer)
                    {
                        AddToScore = true;
                    }
                    ChangeCompareAnswer(((MultichoiceQuestion)Current).GetCorrect());
                    break;
                case QuestionType.MultiNumber:
                    SwitchContinueButton(true);
                    SetCorrectAnswer(((MultipleNumberQuestion)Current).AcceptedAnswers[0].ToString());
                    foreach(float answer in ((MultipleNumberQuestion)Current).AcceptedAnswers)
                    {
                        if(answer == (float)UserNumberAnswer.Value)
                        {
                            AddToScore = true;
                            SetCorrectAnswer(answer.ToString());
                            break;
                        }
                    }
                    ChangeCompareAnswer(UserNumberAnswer.Value.ToString());
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
            SwitchMulti(false);
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

        private void SwitchMulti(bool shown)
        {
            Multi.SwitchVisible(shown);
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

        public void ChangeChoice(int Choice, Button btn)
        {
            if(CurrentChoice != null)
                CurrentChoice.BackColor = Color.FromArgb(255, 255, 255);
            CurrentChoice = btn;
            btn.BackColor = Color.FromArgb(83, 221, 108);
            SelectedAnswer = Choice;
            AnswerBtn.Enabled = true;
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
        public MultichoiceManager Multi { get; }
    }
}
