using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PS2Cafeteria.Models;

namespace PS2Cafeteria.Controllers
{
    //Para restringir el acceso a solo usuarios registrados.
    [Authorize]

    public class OrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Coffee);
            return View(orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            //ViewBag.CoffeeId = new SelectList(db.Coffees, "Id", "CoffeeName");
            //return View();
            //ViewBag.CoffeeId = (from p in db.Coffees select p).ToList();
            //return View();
            ViewBag.Coffees = db.Coffees.ToList();
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Client,CoffeeId,Quantity,Total,Status")] Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Orders.Add(order);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CoffeeId = new SelectList(db.Coffees, "Id", "CoffeeName", order.CoffeeId);
        //    return View(order);
        //}
        public ActionResult Create(Order order)
        {
            Coffee coffee = db.Coffees.Find(order.CoffeeId);
            decimal total = order.Quantity * coffee.Price;
            order.Total = total;
            db.Orders.Add(order);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            //ViewBag.CoffeeId = new SelectList(db.Coffees, "Id", "CoffeeName", order.CoffeeId);
            //return View(order);
            ViewBag.Coffees = db.Coffees.ToList();
            return View(order);


        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Client,CoffeeId,Quantity,Total,Status")] Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(order).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CoffeeId = new SelectList(db.Coffees, "Id", "CoffeeName", order.CoffeeId);
        //    return View(order);
        //}

        public ActionResult Edit(Order order)
        {
            Coffee coffee = db.Coffees.Find(order.CoffeeId);
            decimal total = order.Quantity * coffee.Price;
            order.Total = total;
            db.Entry(order).State = EntityState.Modified;
            //db.Orders.Add(order);
            db.SaveChanges();

            return RedirectToAction("Index");
        }




        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
