using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject_3.Models;

namespace FinalProject_3.Controllers
{
    public class DonorController : Controller
    {
        //
        // GET: /CAEmployee/

        public ActionResult Index()
        {
            CommunityAssistEntities cae = new CommunityAssistEntities();
            var donors = from d in cae.Donations
                            orderby d.Person.PersonLastName
                            select new
                            {
                                d.Person.PersonLastName,
                                d.Person.PersonFirstName,
                                d.Person.PersonUsername,
                                d.DonationAmount,
                                d.DonationDate
                                
                            };
            List<Donor> donorList = new List<Donor>();
            foreach (var y in donors)
            {
                Donor don = new Donor();
                don.LastName = y.PersonLastName;
                don.FirstName = y.PersonFirstName;
                don.Email = y.PersonUsername;
                don.DonationDate = y.DonationDate.ToString();
                don.DonationAmount = y.DonationAmount.ToString();
                
              

                donorList.Add(don);
            }
            return View(donorList);//passing the employee list  to the View 
        }

    }

    public class Donor
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Email { set; get; }
        public string DonationDate { set; get; }
        public string DonationAmount { set; get; }
    }
}
