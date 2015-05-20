﻿using System;

namespace P2.Types
{
    public class Unit : Type
    {
        public static int NumParams = 2;
        public double Distance { get; set; }
        public double Angle { get; set; }

        public Unit(double Distance, double Angle)
        {
            //this.Number = Number;
            this.Distance = Distance;
            this.Angle = Angle;
        }

        public override string ToString()
        {
            return string.Format("Number: {0}, Distance: {1}, Angle: {2}, Anomaly: {3}", Distance, Angle, Anomality);
        }
    }
}