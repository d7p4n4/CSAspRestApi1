using CSAspRestApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace CSAspRestApi1.Controllers
{
    public class UsersController : Controller
    {
        private User[] users = new User[]
        {
            new User { id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1},
            new User { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1},
            new User { id = 3, name = "Sohail Perez", email = "email3@mail.com", phone = "01111111", role = 1},
            new User { id = 4, name = "Merryn Peck", email = "email4@mail.com", phone = "01111111", role = 2},
            new User { id = 5, name = "Cairon Reynolds", email = "email5@mail.com", phone = "01111111", role = 3}
        };
        private HttpRequestMessage _request = new HttpRequestMessage();

        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }
        // GET: api/Users/5
        public HttpResponseMessage Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
            }
            return _request.CreateResponse<User>(HttpStatusCode.OK, product);
        }



        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [System.Web.Http.HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [System.Web.Http.HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [System.Web.Http.HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
