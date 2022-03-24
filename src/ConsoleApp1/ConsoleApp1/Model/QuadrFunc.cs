﻿using System;

namespace ConsoleApp1.Model
{
    public class QuadrFunc : Func
    {
        public double Quadratic { get; set; } = 1;
        public double Linear { get; set; } = 1;
        public double Const { get; set; } = 1;

        public QuadrFunc() { }
        public QuadrFunc(double a, double b, double c)
        {
            Quadratic = a;
            Linear = b;
            Const = c;
        }

        
        public override Func GetDerivative() => new LinearFunc(2 * Quadratic, Linear);

        public override double Compute(double arg) => Quadratic * Math.Pow(arg, 2) + Linear * arg + Const;

        public override string ToString() => $"{Quadratic}x^2 + {Linear}x + {Const}";

        public override bool Equals(object? obj)
        {
            if (obj is QuadrFunc func)
            {
                return Quadratic == func.Quadratic && Linear == func.Linear && Const == func.Const;
            }
            return false;
        }

        public override int GetHashCode() => GetType().GetHashCode();

    }
}