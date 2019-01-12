
namespace Logger.Layouts.Factory
{
    using System;

    using Contracts;

    public class LayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type)
            {
                case "SimpleLayout":
                    return new SimpleLayout();

                case "XmlLayout":
                    return new XmlLayout();

                default:
                    throw new ArgumentException("Wrong layout type requested.");
                   
            }
        }
    }
}
