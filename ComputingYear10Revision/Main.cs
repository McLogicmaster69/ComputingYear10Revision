using ComputingYear10Revision.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingYear10Revision
{
    public partial class Revision : Form
    {

        QuestionCompiler Compiler;
        QuestionManager Manager;

        public Revision()
        {
            InitializeComponent();
        }

        private void Revision_Load(object sender, EventArgs e)
        {
            Compiler = new QuestionCompiler();
            Manager = new QuestionManager(QuestionLbl, AnswerLbl, CompareAnswerLbl, ContinueBtn, CorrectBtn, IncorrectBtn, AnswerBtn, UserAnswer, UserNumberInput, Compiler, new StatManager(NumOfQuestions, CorrectLabel, CurrentQuestion, Percent), new MultichoiceManager(Choice1, Choice2, Choice3, Choice4));
            Manager.NextQuestion();
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            Manager.MarkQuestion();
        }

        private void CorrectBtn_Click(object sender, EventArgs e)
        {
            Manager.CorrectQuestions++;
            Manager.NextQuestion();
        }

        private void IncorrectBtn_Click(object sender, EventArgs e)
        {
            Manager.NextQuestion();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            Manager.NextQuestion();
        }

        private void Choice1_Click(object sender, EventArgs e)
        {
            Manager.ChangeChoice(1, (Button)sender);
        }

        private void Choice2_Click(object sender, EventArgs e)
        {
            Manager.ChangeChoice(2, (Button)sender);
        }

        private void Choice3_Click(object sender, EventArgs e)
        {
            Manager.ChangeChoice(3, (Button)sender);
        }

        private void Choice4_Click(object sender, EventArgs e)
        {
            Manager.ChangeChoice(4, (Button)sender);
        }
    }
}
