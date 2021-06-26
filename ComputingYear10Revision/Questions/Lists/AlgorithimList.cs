using ComputingYear10Revision.Questions.QuestionTypes;
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
            new ExplainQuestion("What is decomposition?", "Breaking a problem down into a series of sub-problems that are simple enough to solve"),
            new ExplainQuestion("What is abstraction?", "Removing unnecessary detail from a problem to make it easier to solve"),
            new ExplainQuestion("How does a linear search work?", "1.Reads through the data beginning at the start, \n2.look at each record in turn \n3.Stop when we see the record we are looking for."),
            new ExplainQuestion("How does a binary search work?", "1.look at the middle record. \n2.if this is the target it stops, \n3.otherwise if the middle is bigger than the target discardsthe top half of the list \n4.otherwise discard the bottom half of the list."),
            new ExplainQuestion("How does a bubble sort work?", ">The first pair of records is comparedand swapped into order. \n>This process is repeated for each other pair of records in the data-set.\n>Once all data pair have been looked at, the process is then repeated, until we can read through all of the data without needing to swap any records."),
            new ExplainQuestion("How does a merge sort work?", ">The original list is divided into a list of discrete elements.\n>The elements are then combined into a sorted list."),
        };
    }
}
