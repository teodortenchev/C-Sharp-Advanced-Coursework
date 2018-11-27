using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }
        public string CodeName { get; set; }
        public State State { get; set; }

        public void CompleteMission()
        {
            State = State.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State.ToString("f")}";
        }
    }
}

//TODO Validate mission state, input should match exactly one of the possible states, skip mission if so
//TODO Same for corps but in case of wrong input the entire line is discarded.
