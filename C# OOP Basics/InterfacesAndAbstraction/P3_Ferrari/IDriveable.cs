namespace P3_Ferrari
{
    public interface IDriveable
    {
        string Model { get; }
        string Driver { get; }

        string Accelerate();
        string Brake();
    }
}
