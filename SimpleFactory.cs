using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    public class SimpleFactory
    {
        public WoodenDoor makeDoor(double width, double height)
        {
            return new WoodenDoor(width, height);
        }
    }

    public class WoodenDoor : Door
    {
        protected double width;
        protected double height;
        public WoodenDoor(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double getWidth()
        {
            return this.width;
        }
        public double getHeight()
        {
            return this.height;
        }
    }

    public interface Door
    {
        double getWidth();
        double getHeight();
    }
}
