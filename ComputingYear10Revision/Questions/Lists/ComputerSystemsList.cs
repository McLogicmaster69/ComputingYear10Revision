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
            new NumberQuestion("How many states does a bit have?", 2),
            new ExplainQuestion("State the purpose of the CPU.", "The purpose of the CPU is to process data. The CPU is where processes such as calculating, sorting and searching take place."),
            new ExplainQuestion("Describe the purpose of the CPU in fetching and executing instructions from memory.", "The CPU fetches the instructions one at a time from the main memory into the registers. One register is the program counter (pc). The pc holds the memory address of the next instruction to be fetched from main memory.\n\n1. The CPU decodes the instruction.\n2. The CPU executes the instruction.\n3. Repeat until there are no more instructions."),
            new ExactQuestion("How fast does a modern CPU compute (in GHz)", new List<string> { "2", "3", "4", "5", "2ghz", "3ghz", "4ghz", "5ghz", "2GHz", "3GHz", "4GHz", "5GHz" })
        };
    }
}
