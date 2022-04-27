using System;

namespace lab6try1
{
    public class Point
    {
        private double latitude = 0.0; 

        private double length = 0.0; 

        private string name = "";
        private string type = "";

        
        public Point(string line)
        {
            string[] eligible_points = line.Split(";");

            latitude = Convert.ToDouble(eligible_points[0]);
            length = Convert.ToDouble(eligible_points[1]);
            name = eligible_points[4];
            type = eligible_points[2] + " & " + eligible_points[3];

            
        }
        
        public double DistanceTo(Point another)
        {
            double result = 0;
            result = Math.Sqrt((this.latitude - another.latitude)*(this.latitude - another.latitude)+(this.length - another.length)*(this.length - another.length));
            return result;
        }

    }
   
    
}







