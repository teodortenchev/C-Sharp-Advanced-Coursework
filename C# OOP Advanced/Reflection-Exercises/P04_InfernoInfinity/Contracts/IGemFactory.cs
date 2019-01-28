namespace P04_InfernoInfinity.Contracts
{
    public interface IGemFactory
    {
        IGem CreateGem(string gemType, string quality);
    }
}
