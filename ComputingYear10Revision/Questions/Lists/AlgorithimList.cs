﻿using ComputingYear10Revision.Questions.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.Lists
{
    class AlgorithimList : QuestionList
    {
        public override List<Question> Questions { get; protected set; } = new List<Question>()
        {
            new ExplainQuestion("What is an algorithim?", "A sequence of steps or instructions that must be followed to complete a task or solve a problem"),
            new ExplainQuestion("What is an decomposition?", "Breaking a problem down into a series of sub-problems that are simple enough to solve"),
        };
    }
}
