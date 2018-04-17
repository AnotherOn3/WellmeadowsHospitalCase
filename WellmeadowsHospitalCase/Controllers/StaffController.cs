using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WellmeadowsHospitalCase.DAL;
using WellmeadowsHospitalCase.Models;
using WellmeadowsHospitalCase.ViewModels;

namespace WellmeadowsHospitalCase.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(StaffVM model)
        {
            //Creating a Company object from the CompanyVM
            Staff staff = new Staff();
            staff.FName = model.FName;
            staff.LName = model.LName;
            staff.StaffNumber = model.StaffNumber;
            staff.TypeOfShift = model.TypeOfShift;
            staff.Address = model.Address;
            staff.PhoneNumber = model.PhoneNumber;
            staff.DateOfBirth = model.DateOfBirth;
            staff.Gender = model.Gender;
            staff.Insurance = model.Insurance;
            staff.ContractId = model.ContractId;
            staff.PositionId = model.PositionId;
            staff.WardId = model.WardId;
            //Create a CompanyRepo for saving
            StaffRepository staffRepository = new StaffRepository();
            staffRepository.SaveStaffMember(staff);
            return RedirectToAction("Index");
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
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

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
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
