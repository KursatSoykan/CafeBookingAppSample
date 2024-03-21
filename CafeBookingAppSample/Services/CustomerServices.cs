using CafeBookingAppSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CafeBookingAppSample.Forms;
namespace CafeBookingAppSample.Services
{
    public class CustomerServices
    {
        public Customers CustomersAdd(Customers customers) 
        { 
            CafeBookingAppContext appContext = new CafeBookingAppContext();
            appContext.Customers.Add(customers);
            appContext.SaveChanges();
            return customers;
        }
        public List<Customers> GetAllCustomers() 
        {
           CafeBookingAppContext appContext= new CafeBookingAppContext();
           List<Customers> customers=appContext.Customers.ToList();

            return customers ;
         }
        public Customers CustomersUpdate(int id) 
        {

            CafeBookingAppContext contextapp = new CafeBookingAppContext();
            Customers customers = contextapp.Customers.Where(x => x.Id == id).FirstOrDefault();
           

            return customers;
        
        
        }

    }

}
