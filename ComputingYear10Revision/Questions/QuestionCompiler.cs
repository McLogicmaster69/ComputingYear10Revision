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
        public List<Question> Questions { get; private set; }
        public List<Question> Queue { get; private set; }
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
        public void SetQueue(List<Question> queue)
        {
            Queue = queue;
        }
        public Question NextInQueue()
        {
            if (Queue.Count == 0)
                return new EndFlag();
            Question next = Queue[0];
            Queue.RemoveAt(0);
            return next;
        }
    }
}
