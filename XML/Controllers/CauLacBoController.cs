﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using XML.Models;

namespace XML.Controllers
{
    public class CauLacBoController : Controller
    {
        XmlDocument doc = new XmlDocument();
        string file;
        XmlElement root;

        public string File1 { get => Server.MapPath("/DataSource/XMLFile1.xml"); set => file = value; }

        private void initValue()
        {
            doc.Load(File1);
            root = doc.DocumentElement;
        }
        // GET: CauLacBo
        public ActionResult Index()
        {
            initValue();

            XmlNodeList CLBs = root.SelectNodes("CLB");
            List<CLB> DSCLB = new List<CLB>();

            foreach (XmlNode CLB in CLBs)
            {
                CLB temp = new CLB();
                temp.MACLB = CLB["MACLB"].InnerText;
                temp.TENCLB = CLB["TENCLB"].InnerText;
                DSCLB.Add(temp);
            }

            return View(DSCLB);
        }

        // GET: CauLacBo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CauLacBo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CauLacBo/Create
        [HttpPost]
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

        // GET: CauLacBo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CauLacBo/Edit/5
        [HttpPost]
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

        // GET: CauLacBo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CauLacBo/Delete/5
        [HttpPost]
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
