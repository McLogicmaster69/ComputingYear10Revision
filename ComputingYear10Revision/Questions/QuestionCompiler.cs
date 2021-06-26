using ComputingYear10Revision.Questions.Lists;
using ComputingYear10Revision.Questions.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions
{
    sealed class QuestionCompiler
    {
        public List<Question> Questions;
        public List<QuestionList> Lists = new List<QuestionList>()
        {
            new AlgorithimList(),
            new ComputerSystemsList(),
            new ProgrammingList(),
        };

        public QuestionCompiler()
        {
            Compile();
        }

        public void Compile()
        {
            Questions = new List<Question>();
            foreach (QuestionList list in Lists)
            {
                foreach (Question question in list.Questions)
                {
                    Questions.Add(question);
                }
            }
        }

        public Question Chuck()
        {
            Random rnd = new Random();
            return Questions[rnd.Next(0, Questions.Count)];
        }
    }
}
