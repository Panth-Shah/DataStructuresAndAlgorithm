using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    //Taking hiring manager example: 
    class FactoryMethod
    {
    }
    //Interviewer interface with some implementations
    public interface IInterviewer
    {
        void askQuestions();
    }
    //Derived classes from Interface
    public class Developer : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about design pattern!");
        }
    }

    public class CommunityExecutive : IInterviewer
    {
        public void askQuestions()
        {
            Console.WriteLine("Asking about community Building");
        }
    }

    //HiringManager class is an Abstract class
    public abstract class HiringManager
    {
        //Factory Method => makeInterviewer()
        protected abstract IInterviewer makeInterviewer(); 
        public void takeInterview()
        {
            IInterviewer manager = this.makeInterviewer();
            manager.askQuestions();
        }
    }

    //Create Child which can extend Abstract method
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer makeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
