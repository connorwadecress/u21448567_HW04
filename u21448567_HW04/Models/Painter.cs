using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21448567_HW04.Models
{
    public class Painter : Person //inherited from base class 
    {
        public bool mIsPainter; 
        public int mPainterRating;
        public int mPainterJobsDone;

        public int PainterRating { get => mPainterRating; set => mPainterRating = value; } 
        public int PainterJobsDone { get => mPainterJobsDone; set => mPainterJobsDone = value; }

        public Painter(int personId, string firstName, string lastName, string phone, int age, string address, string bio, int profession, string photoName, int jobs, int rating, int painterRating, int painterJobsDone) : base(personId, firstName, lastName, phone, age, address, bio, profession, photoName, jobs, rating)
        {
            mPainterRating = painterRating;
            mPainterJobsDone = painterJobsDone;
        }

        public bool IsPainter()
        {
            return true;
        }

        public override int jobTotal() //abstraction, method overriden
        {
            int total = jobTotal() + jobFinished();
            return total;
        }

        public override int rating()
        {
            int sum = rating() + PainterRating;
            int average = sum / 2;
            return average;
        }

        public override int jobFinished()
        {
            throw new NotImplementedException();
        }

        public override double fee()
        {
            throw new NotImplementedException();
        }






    }
}