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
            Manager = new QuestionManager(QuestionLbl, AnswerLbl, CompareAnswerLbl, ContinueBtn, CorrectBtn, IncorrectBtn, AnswerBtn, UserAnswer, UserNumberInput, Compiler);
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
    }
}
