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
        public ActionResult Index()
        {
            StaffRepository staffRepository = new StaffRepository();
            List<Staff> staffs = staffRepository.LoadAllStaffs();
            List<StaffVM> staffVMs = new List<StaffVM>();
            PositionRepository positionRepository = new PositionRepository();

            foreach (Staff staff in staffs)
            {
                StaffVM staffvm = new StaffVM();
                staffvm.Id = staff.Id;
                staffvm.FName = staff.FName;
                staffvm.LName = staff.LName;
                staffvm.Insurance = staff.Insurance;
                staffvm.PhoneNumber = staff.PhoneNumber;
                staffvm.PositionId = staff.PositionId;
                staffvm.TypeOfShift = staff.TypeOfShift;
                staffvm.Address = staff.Address;
                staffvm.StaffNumber = staff.StaffNumber;
                staffvm.ContractId = staff.ContractId;
                staffvm.DateOfBirth = staff.DateOfBirth;
                staffvm.Gender = staff.Gender;
                staffvm.WardId = staff.WardId;


                Position position = positionRepository.LoadPosition(staff.PositionId);
                PositionVM positionVM = new PositionVM();

                positionVM.Id = position.Id;
                positionVM.Name = position.Name;

                staffvm.Position = positionVM;
                //This code will return only the name of the company which will be presented into the SHOW view
                staffVMs.Add(staffvm);
            }

            StaffVM model = new StaffVM();
            model.Staffs = staffVMs;

            return View(model);
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
