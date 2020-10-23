using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnSiteInterview
{
    //Defines a dependency between objects so when object changes its state, all of its dependents will be notified
    //Observer pattern is a DP in which an object called the subject, maintains a list of its
    //dependents, called observer and notifies them autometically of any state changes
    //ususally by calling one of its methods
    public class ObserverPattern
    {

    }

    public class JobPost
    {
        protected string title;
        public JobPost(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return this.title;
        }
    }

    public class JobSeeker
    {
        protected string name;
        public JobSeeker(string name)
        {
            this.name = name;
        }

        public void onJobPosting(JobPost job)
        {
            Console.WriteLine("Hi " + name + "! New Job posted: " + job.GetType());
        }
    }

    public class EmploymentEgency
    {
        public List<JobSeeker> observers;
        public EmploymentEgency()
        {
            this.observers = new List<JobSeeker>();
        }

        private void notify(JobPost jobPosting)
        {
            foreach (var observer in observers)
            {
                observer.onJobPosting(jobPosting);
            }
        }

        public void attach(JobSeeker jobSeekingCandidate)
        {
            observers.Add(jobSeekingCandidate);
        }

        public void addJob(JobPost newjob)
        {
            this.notify(newjob);
        }
    }
}
