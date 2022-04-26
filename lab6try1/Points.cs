using System;

namespace lab6try1
{
    public class Point
    {
        private float latitude; // x

        private float length; // y

        private int radius;

        private string name;
        private string type;

        /*
         for each point in points
            if in radius 
                in_radius = true
                display
            
         
         Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y))
         */
        
        public double DistanceTo(Point another)
        {
            double result = 0;
            result = Math.Sqrt((this.latitude - another.latitude)*(this.latitude - another.latitude)+(this.length - another.length)*(this.length - another.length));
            return result;
        }
        
        
    }
   
    
}







