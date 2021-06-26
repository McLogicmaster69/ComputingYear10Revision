using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.Lists
{
    abstract class QuestionList
    {
        public abstract List<Question> Questions { get; protected set; } 
    }
}
