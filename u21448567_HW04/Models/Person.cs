using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace u21448567_HW04.Models
{
    public abstract class Person //base class and fields
    {
        protected int mPersonId;
        protected string mFirstName;
        protected string mLastName;
        protected string mPhone;
        protected int mAge;
        protected string mAddress;
        protected string mBio;
        protected int mProfession;

        protected int mJobs;
        protected int mRating;

        protected string mPhotoName;
        //private profilePicture profilePicture;

        public Person() //blank constrructor
        {

        }

        public Person(int personId, string firstName, string lastName, string phone, int age, string address, string bio, int profession, string photoName, int jobs, int rating) //constructor
        {
            mPersonId = personId;
            mFirstName = firstName;
            mLastName = lastName;
            mPhone = phone;
            mAge = age;
            mAddress = address;
            mBio = bio;
            mProfession = profession;
            mPhotoName = photoName;
            mJobs = jobs;
            mRating = rating;
        }


        public abstract int jobTotal();  //abstraction

        public abstract int jobFinished();

        public abstract int rating();

        public abstract double fee();

        public int Jobs //properties for fields
        {
            get { return mJobs; }
            set { mJobs = value; }
        }

        public int Rating
        {
            get { return mRating; }
            set { mRating = value; }
        }

        public string PhotoName
        {
            get { return mPhotoName; }
            set { mPhotoName = ""; }
        }

        public int PersonID
        {
            get { return mPersonId; }
            set { mPersonId = 0; }
        }


        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        public string Bio
        {
            get { return mBio; }
            set { mBio = value; }
        }

        public int Profession
        {
            get { return mProfession; }
            set { mProfession = value; }
        }


        

        //public string PersonId
        //{
        //    get { return mPersonId; }
        //}

        //public string FirstName
        //{
        //    get { return mFirstName; }
        //    set { mFirstName = value; }
        //}

        //public string LastName
        //{
        //    get { return mLastName; }
        //    set { mLastName = value; }
        //}

        //public int Age
        //{
        //    get { return mAge; }
        //    set { mAge = value; }
        //}

        //public string Bio
        //{
        //    get { return mBio; }
        //    set { mBio = value; }
        //}

        //public Person(string inPersonId, string inFirstName, string inLastName, int inAge, string inBio)
        //{
        //    mPersonId = inPersonId;
        //    mFirstName = inFirstName;
        //    mLastName = inLastName;
        //    mAge = inAge;
        //    mBio = inBio;
        //}

        //protected Person(string mPersonId, string mFirstName, string mLastName, string mPhone, int mAge, string mBio)
        //{
        //    this.mPersonId = mPersonId;
        //    this.mFirstName = mFirstName;
        //    this.mLastName = mLastName;
        //    this.mPhone = mPhone;
        //    this.mAge = mAge;
        //    this.mBio = mBio;
        //}
    }
}