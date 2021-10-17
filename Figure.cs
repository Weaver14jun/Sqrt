using System;

namespace FigureSquareLibrary
{
    public abstract class Figure
    {
        public abstract double Square();
    }

    class Triangle : Figure
    {
        double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value < 0 ? -value : value; }
        }

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value < 0 ? -value : value; }
        }

        public double SideC
        {
            get { return _sideC; }
            set { _sideC = value < 0 ? -value : value; }
        }

        public override double Square()
        {
            double per = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(per * (per - _sideA) * (per - _sideB) * (per - _sideC));
        }
    }

    class Ciricle : Figure
    {
        double _radius;

        public Ciricle(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set { _radius = value < 0 ? -value : value; }
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
