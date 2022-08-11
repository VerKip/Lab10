using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            get { return gradus; }
            set
            {
                gradus = value % 360;
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
                Gradus += value / 60;
                min = value % 60;
            }
        }

        public int Sec
        {
            get { return sec; } 
            set {
                Min += value / 60;
                sec = value % 60; }
        }

        public Angle (int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }   

        public double ToRadians ()
        {
            return (gradus + (min + sec/60)/60)*Math.PI/180;    
        }
    }
}
