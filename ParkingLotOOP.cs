using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    public enum VehicleSize
    {
        Motorcycle, Compact, Large
    }
    public abstract class Vehicle
    {
        protected List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
        protected string licensePlate;
        protected int spotNeeded;
        protected VehicleSize size;

        public int getSpotsNeeded()
        {
            return spotNeeded;
        }
        public VehicleSize getVehicleSize()
        {
            return size;
        }
        public void parkInSpot(ParkingSpot s)
        {
            parkingSpots.Add(s);
        }

        public void clearSpot()
        {
            //remove car from spot and modify spot that's gone
        }

        public abstract bool canFitSpot(ParkingSpot spot);
    }

    public class ParkingLot
    {
        private bool[] levels;
        private const int MIN_LEVEL = 5;

        public ParkingLot()
        {
            
        }
    }

    public class Level
    {
        private int floor;
        
    }
    public class ParkingSpot
    {
        private Vehicle vehicle;
        private VehicleSize spotSize;
        private int row;
        private int spotNumber;
        private Level level;

        public ParkingSpot(Level lvl, int r, int n, VehicleSize s)
        {
            level = lvl;
            row = r;
            spotNumber = n;
            spotSize = s;
        }

        public bool isAvailable()
        {
            return vehicle == null;
        }
    }
    public class ParkingLotOOP
    {

    }
}
