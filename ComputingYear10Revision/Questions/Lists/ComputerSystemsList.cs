using ComputingYear10Revision.Questions.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.Lists
{
    class ComputerSystemsList : QuestionList
    {
        public override List<Question> Questions { get; protected set; } = new List<Question>()
        {
            new NumberQuestion("How many bits are in a byte?", 8),
            new NumberQuestion("How many states does a bit have?", 2)
        };
    }
}
