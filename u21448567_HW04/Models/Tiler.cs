using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21448567_HW04.Models
{
    public class Tiler : Person
    {
        public bool mIsTiler;
        public int mTilerRating;
        public int mTilerJobsDone;

        public int TilerRating { get => mTilerRating; set => mTilerRating = value; }
        public int TilerJobsDone { get => mTilerJobsDone; set => mTilerJobsDone = value; }

        public Tiler(int personId, string firstName, string lastName, string phone, int age, string address, string bio, int profession, string photoName, int jobs, int rating, int tilerRating, int tilerJobsDone) : base(personId, firstName, lastName, phone, age, address, bio, profession, photoName, jobs, rating)
        {
            mTilerRating = tilerRating;
            mTilerJobsDone = tilerJobsDone;
        }

        public bool IsTiler()
        {
            return true;
        }

        public override int jobTotal()
        {
            int total = jobTotal() + TilerJobsDone;
            return total;
        }

        public override int rating()
        {
            int sum = rating() + TilerRating;
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