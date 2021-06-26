using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingYear10Revision
{
    class StatManager
    {
        public StatManager(Label questionLbl, Label correctLbl, Label currentLbl, Label percent)
        {
            QuestionLbl = questionLbl;
            CorrectLbl = correctLbl;
            CurrentLbl = currentLbl;
            Percent = percent;
        }

        public void UpdateStats(string Qs, string Correct, string Current)
        {
            QuestionLbl.Text = "QUESTIONS\n" + Qs;
            CorrectLbl.Text = "CORRECT\n" + Correct;
            CurrentLbl.Text = "CURRENT\n" + Current;
        }

        public void UpdatePercent(float Qs, float Correct)
        {
            if(Correct == 0)
            {
                Percent.Text = "PERCENT\n0%";
                return;
            }
            float Rate = Correct / Qs;
            Rate = (float)Math.Floor(Rate * 1000) / 10;
            Percent.Text = "PERCENT\n" + Rate.ToString() + "%";
        }

        public Label QuestionLbl { get; }
        public Label CorrectLbl { get; }
        public Label CurrentLbl { get; }
        public Label Percent { get; }
    }
}
