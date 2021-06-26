﻿using ComputingYear10Revision.Questions.QuestionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingYear10Revision.Questions.Lists
{
    class ProgrammingList : QuestionList
    {
        public override List<Question> Questions { get; protected set; } = new List<Question>()
        {
            new ExplainQuestion("What is a variable?", "A computer memory location, that is referred to by an identifier(a name), that holds a value that can change when the program is running. The variable will have a data-type"),
            new ExplainQuestion("What is a constant?", "A computer memory location, that is referred to by an identifier(a name), that holds a value that cannot change when the program is running"),
            new ExplainQuestion("Why use constants?", "It makes code more readable"),
            new ExactQuestion("Common phrase in programming", new List<string>{"Hello, world", "Hello world", "Hello, world!", "Hello world!"}),
        };
    }
}
