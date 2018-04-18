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
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient/Create
        [HttpPost]
        public ActionResult Create(PatientVM model)
        {
            //Creating a Company object from the CompanyVM
            Patient patient = new Patient();
            patient.FName = model.FName;
            patient.LName = model.LName;
            patient.Address = model.Address;
            patient.PhoneNumber = model.PhoneNumber;
            patient.Gender = model.Gender;
            patient.MaritalStatus = model.MaritalStatus;
            patient.RegisterDate = model.RegisterDate;
            patient.LocalDoctorId = model.LocalDoctorId;
            patient.NextOfKinId = model.NextOfKinId;
            patient.IsOutpatient = model.IsOutpatient;
            //Create a CompanyRepo for saving
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.SavePatient(patient);
            return RedirectToAction("Index");
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Patient/Edit/5
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

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Patient/Delete/5
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
