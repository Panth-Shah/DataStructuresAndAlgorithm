using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    class AbstractFactory
    {
    }
    //Abstract Factory which will let us make family of related objects
    //i.e. Wodden Door creator creates Wooden Door
    //Welder creates Iron Door

    //Interface of Factory Interfaces
    public interface IDoorFactory
    {
        IAFDoor makeDoor();
        IDoorFittingExperts makeFittingExpert();
    }

    //Wooden factory to return carpenter and wooden door
    public class WoodenDoorFactory : IDoorFactory
    {
        public IAFDoor makeDoor()
        {
            return new AFWoodenDoor();
        }

        public IDoorFittingExperts makeFittingExpert()
        {
            return new Carpenter();
        }
    }
    //Iron Door factory to get iron door and relevent fitting expetr
    public class IronDoorFactory : IDoorFactory
    {
        public IAFDoor makeDoor()
        {
            return new AFIronDoor();
        }

        public IDoorFittingExperts makeFittingExpert()
        {
            return new Welder();
        }
    }


    //Fitting experts for each door type
    public interface IDoorFittingExperts
    {
        void getDescription();
    }

    public class Welder : IDoorFittingExperts
    {
        public void getDescription()
        {
            Console.Write("I can only fit Iron Door");
        }
    }

    public class Carpenter : IDoorFittingExperts
    {
        public void getDescription()
        {
            Console.Write("I can only fit Wooden Door");
        }
    }
    public interface IAFDoor
    {
        void getDescription();
    }

    //Clases for Door Type
    public class AFWoodenDoor : IAFDoor
    {
        public void getDescription()
        {
            Console.WriteLine("I am WoodenDoor!");
        }
    }

    public class AFIronDoor : IAFDoor
    {
        public void getDescription()
        {
            Console.WriteLine("I am IronDoor!");
        }
    }
}
