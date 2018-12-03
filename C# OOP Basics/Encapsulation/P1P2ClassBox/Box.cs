using System;
namespace P1P2ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public string FindSurfaceArea()
        {
            double surfaceArea = 2 * (Length * Width + Length * Height + Width * Height);
            return $"Surface Area - {surfaceArea:F2}";
        }

        public string FindLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (Length * Height + Width * Height);
            return $"Lateral Surface Area - {lateralSurfaceArea:F2}";
        }

        public string FindVolume()
        {
            double volume = Length * Width * Height;
            return $"Volume - {volume:F2}";
        }

    }
}
