using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21448567_HW04.Models
{
    public class Mover : Person
    {
        public bool mIsMover;
        public int mMoverRating;
        public int mMoverJobsDone;

        public int MoverRating { get => mMoverRating; set => mMoverRating = value; }
        public int MoverJobsDone { get => mMoverJobsDone; set => mMoverJobsDone = value; }

        public Mover(int personId, string firstName, string lastName, string phone, int age, string address, string bio, int profession, string photoName, int jobs, int rating, int moverRating, int moverJobsDone) : base(personId, firstName, lastName, phone, age, address, bio, profession, photoName, jobs, rating)
        {
            mMoverRating = moverRating;
            mMoverJobsDone = moverJobsDone;
        }

        public bool IsTiler()
        {
            return true;
        }

        public override int jobTotal()
        {
            int total = jobTotal() + MoverJobsDone;
            return total;
        }

        public override int rating()
        {
            int sum = rating() + MoverRating;
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
