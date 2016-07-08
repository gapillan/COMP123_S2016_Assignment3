﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES 
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES 
       
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
            set
            {
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
            set
            {
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS 

        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // PUBLIC METHODS 
        public override string ToString()
        {
            return String.Format("Planet Name: {0}, Diameter of Planet: {1}, Mass of Planet: {2}", 
                this.Name, this.Diameter, this.Mass);
        }
    }
}
