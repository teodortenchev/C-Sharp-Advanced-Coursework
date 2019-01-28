namespace P04_InfernoInfinity.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public abstract class Command : IExecutable
    {
        private readonly string[] data;

        public Command(string[] data)
        {
            this.data = data;
        }

        public IReadOnlyList<string> Data => Array.AsReadOnly(data);

        public abstract void Execute();
        
    }
}
