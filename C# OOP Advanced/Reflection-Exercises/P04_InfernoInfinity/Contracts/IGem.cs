namespace P04_InfernoInfinity.Contracts
{
    public interface IGem : IClarity
    {
        int StrengthIncrease { get; }
        int AgilityIncrease { get; }
        int VitalityIncrease { get; }
    }
}
