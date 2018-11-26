using MilitaryElite.Enums;

namespace MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; set; }
        State State { get; set; }

        void CompleteMission();
    }
}
