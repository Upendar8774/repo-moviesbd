using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOVIESDB.Models;

namespace MOVIESDB.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        DataClassDataContext datacontxt = new DataClassDataContext();

        public ActionResult Home()
        {
            List<FilmDetailsObj> filmobj = (from f1 in datacontxt.FilmDetails
                                        join act in datacontxt.Actors on f1.ActorId equals act.ActorID
                                        join mve in datacontxt.Movies on f1.MovieID equals mve.MovieID
                                        join prod in datacontxt.Producers on f1.ProducerID equals prod.ProducerID
                                        select new FilmDetailsObj { ActorName = act.Name, MovieId = mve.MovieID, MovieName = mve.Name, ProducerName = prod.Name }).ToList();


            return View(filmobj);
        }
        [HttpGet]
        public ActionResult FilmAdd()
        {
            ViewData["Actor"] = datacontxt.Actors.Select(X => new SelectListItem {  Value= X.ActorID.ToString(), Text = X.Name });
            ViewData["Movie"] = datacontxt.Movies.Select(X => new SelectListItem { Value = X.MovieID.ToString(), Text = X.Name });
            ViewData["producer"] = datacontxt.Producers.Select(X => new SelectListItem { Value = X.ProducerID.ToString(), Text = X.Name });

            return View();
        }
        [HttpPost]
        public ActionResult FilmAdd(FilmDetailsObj fdObj)
        {
            FilmDetail filmdObj = new FilmDetail();
            filmdObj.ActorId = Convert.ToInt32(fdObj.ActorId);
            filmdObj.MovieID = Convert.ToInt32(fdObj.MovieId);
            filmdObj.ProducerID = Convert.ToInt32(fdObj.ProducerId);
            datacontxt.FilmDetails.InsertOnSubmit(filmdObj);
            datacontxt.SubmitChanges();
            return RedirectToAction("Home");
        }
        [HttpGet]
        public ActionResult ActorDetails()
        {
            return View(datacontxt.Actors.ToList());
        }
        [HttpGet]
        public ActionResult Actor()
        {
          return View();
         }
        [HttpPost]
        public ActionResult Actor(ActorObj ac)
        {
            Actor actor = new Actor();
            actor.Name = ac.Name;
            actor.Sex = ac.Sex;
            actor.Dob = ac.Dob;
            actor.Bio = ac.Bio;
            datacontxt.Actors.InsertOnSubmit(actor);
            datacontxt.SubmitChanges();
            return RedirectToAction("ActorDetails");
        }
        [HttpGet]
        public ActionResult ActorUpdate(int id)
        {
           
                List<Actor> actor = datacontxt.Actors.Where(x => x.ActorID == id).ToList();
                ActorObj actobj = new ActorObj();
                foreach (var item in actor)
                {
                    actobj.ActorId = item.ActorID;
                    actobj.Name = item.Name;
                    actobj.Sex = item.Sex;
                    actobj.Dob = item.Dob;

                }
                return View(actobj);
             

        }
        [HttpPost]
        public ActionResult ActorUpdate(int id,ActorObj actobj)
        {
            Actor act = datacontxt.Actors.Where(x => x.ActorID == actobj.ActorId).FirstOrDefault();
          act.Name = actobj.Name;
          act.Dob = actobj.Dob;
          act.Bio = actobj.Bio;
          datacontxt.Actors.GetModifiedMembers(act);
          datacontxt.SubmitChanges();
            return RedirectToAction("ActorDetails");
        }
        [HttpGet]
        public ActionResult MovieDetails()
        {
            return View(datacontxt.Movies.ToList());
        }
        [HttpGet]
        public ActionResult MovieAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MovieAdd(Movies mve)
        {
            Movie mveObj = new Movie();
            mveObj.Name = mve.Name;
            mveObj.YoR = mve.YoR;
            mveObj.Plot = mve.Plot;
            datacontxt.Movies.InsertOnSubmit(mveObj);
            datacontxt.SubmitChanges();
            return RedirectToAction("MovieDetails");
        }
        [HttpGet]
        public ActionResult MovieUpdate(int id)
        {

            List<Movie> mvie = datacontxt.Movies.Where(x => x.MovieID == id).ToList();
            Movies mveObj = new Movies();
            foreach (var item in mvie)
            {
                mveObj.MovieId = item.MovieID;
                mveObj.Name = item.Name;
                mveObj.Plot = item.Plot;
                mveObj.YoR = item.YoR;

            }
            return View(mveObj);


        }
        [HttpPost]
        public ActionResult MovieUpdate(int id, Movies moviObj)
        {
            Movie mve= datacontxt.Movies.Where(x => x.MovieID == moviObj.MovieId).FirstOrDefault();
            mve.Name = moviObj.Name;
            mve.Plot = moviObj.Plot;
            mve.YoR = moviObj.YoR;
            datacontxt.Movies.GetModifiedMembers(mve);
            datacontxt.SubmitChanges();
            return RedirectToAction("MovieDetails");
        }


        [HttpGet]
        public ActionResult ProducerDetails()
        {
            return View(datacontxt.Producers.ToList());
        }
        [HttpGet]
        public ActionResult ProducerAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProducerAdd(ProducerObj produ)
        {
            Producer prodObj = new Producer();
            prodObj.Name = produ.Name;
            prodObj.Sex = produ.Sex;
            prodObj.Dob = produ.Dob;
            prodObj.Bio = produ.Bio;
            datacontxt.Producers.InsertOnSubmit(prodObj);
            datacontxt.SubmitChanges();
            return RedirectToAction("ProducerDetails");
        }
        [HttpGet]
        public ActionResult ProducerUpdate(int id)
        {

            List<Producer> prod = datacontxt.Producers.Where(x => x.ProducerID == id).ToList();
            ProducerObj prodObj = new ProducerObj();
            foreach (var item in prod)
            {
                prodObj.Name = item.Name;
                prodObj.Sex = item.Sex;
                prodObj.Dob = item.Dob;
                prodObj.Bio = item.Bio;

            }
            return View(prodObj);


        }
        [HttpPost]
        public ActionResult ProducerUpdate(int id, ProducerObj pObj)
        {
            Producer prd = datacontxt.Producers.Where(x => x.ProducerID == id).FirstOrDefault();
            prd.Name = pObj.Name;
            prd.Sex = pObj.Sex;
            prd.Dob = pObj.Dob;
            prd.Bio = pObj.Bio;

            datacontxt.Producers.GetModifiedMembers(prd);
            datacontxt.SubmitChanges();
            return RedirectToAction("ProducerDetails");
        }
    }
}
