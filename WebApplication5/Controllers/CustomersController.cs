﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class CustomersController : Controller
    {
        //private WebApplication5Context db = new WebApplication5Context();
        private Entities entities = new Entities();

        // GET: Customers
        public ActionResult Index()
        {
            return View(entities.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = entities.Customers.Find(id);// db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,CustomerName,ContactMidName,PhoneNumber,EmailID,Password,ConfirmPassword")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                entities.Customers.Add(customer);
                entities.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }
      
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = entities.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()//[Bind(Include = "CustomerID,CustomerName,ContactMidName,PhoneNumber,EmailID,Password,ConfirmPassword")]Customer customer
        {
            if (ModelState.IsValid)
            {
                Customer customers = new Customer();
                UpdateModel(customers);//UpdateModel<Customer>(customers);
                entities.Entry(customers).State = EntityState.Modified;
                entities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

      
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = entities.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

    
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = entities.Customers.Find(id);
            entities.Customers.Remove(customer);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                entities.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
