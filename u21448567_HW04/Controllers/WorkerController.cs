using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using u21448567_HW04.Models;

namespace u21448567_HW04.Controllers
{
    
    public class WorkerController : Controller
    {
        List<Person> persons = new List<Person>(); //new list to to through fields and objects

        [HttpGet]
        // GET: Worker
        public ActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPerson(HttpPostedFileBase files, int personID, string inputFName, string inputLName, string inputPhone, int inputAge, string inputAddress, string inputBio, int profession, bool isPainter, bool isTiler, bool isMover) //upload info + profile photo of worker
        {
            if(profession == null && files == null)
            {
                ViewBag.Message = "Please make sure that file and file type is selected";
            }
            else
            {
                // Upload  image to the image folder               
                string name = Path.GetFileName(files.FileName);
                string path = "~/ProfilePhoto" + name;
                files.SaveAs(Server.MapPath(path));
                ViewBag.Message = path;

                if (profession == 1) //if statement depending on the profession radio button chosen
                {
                    Painter newPainter = new Painter()
                    {
                        PersonID = personID,
                        FirstName = inputFName,
                        LastName = inputLName,
                        Phone = inputPhone,
                        Age = inputAge,
                        Address = inputAddress,
                        Bio = inputBio,
                        Profession = profession,
                        
                    };
                    persons.Add(newPainter);
                }
                else if (profession == 2)
                {
                    Tiler newTiler = new Tiler()
                    {
                        PersonID = personID,
                        FirstName = inputFName,
                        LastName = inputLName,
                        Phone = inputPhone,
                        Age = inputAge,
                        Address = inputAddress,
                        Bio = inputBio,

                        Profession = profession,
                        
                    };
                    persons.Add(newTiler);
                }
                else if (profession == 3)
                {
                    Mover newMover = new Mover()
                    {
                        PersonID = personID,
                        FirstName = inputFName,
                        LastName = inputLName,
                        Phone = inputPhone,
                        Age = inputAge,
                        Address = inputAddress,
                        Bio = inputBio,

                        Profession = profession,
                        
                    };
                    persons.Add(newMover);
                }

            }

            return View();
        }


        public ActionResult Index() //display profile photos 
        {

            // Get Images from the files folder 
            string[] files = Directory.GetFiles(Server.MapPath("~/Media/ProfilePhoto"));

            
            // Make list of Images to show in the view 
            for (int i = 0; i < files.Length; i++)
            {
                // Get the full path of the image

                Photo.Photo = Path.GetFileName(files[i]);
                persons.Add(file);
            }
            return View(persons);
        }

        
    }




}