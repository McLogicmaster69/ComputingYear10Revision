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

        QuestionCompiler Compiler = new QuestionCompiler();
        QuestionManager Manager;

        public Revision()
        {
            InitializeComponent();
        }

        private void Revision_Load(object sender, EventArgs e)
        {
            Manager = new QuestionManager(QuestionLbl, AnswerLbl);
            Manager.SetQuestion(Compiler.Chuck());
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
            Manager.SetAnswer();
            AnswerQuestion();
        }

        private void AnswerQuestion()
        {
            CompareAnswerLbl.Text = UserAnswer.Text;
            UserAnswer.Text = "";
            ChangeState(false);
        }

        private void ChangeState(bool questionPhase)
        {
            QuestionLbl.Visible = questionPhase;
            AnswerBtn.Visible = questionPhase;
            UserAnswer.Visible = questionPhase;

            CompareAnswerLbl.Visible = !questionPhase;
            CorrectBtn.Visible = !questionPhase;
            IncorrectBtn.Visible = !questionPhase;
            AnswerLbl.Visible = !questionPhase;
        }

        private void CorrectBtn_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void IncorrectBtn_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void NextQuestion()
        {
            ChangeState(true);
            Manager.SetQuestion(Compiler.Chuck());
        }
    }
}
