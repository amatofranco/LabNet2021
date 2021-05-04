using EjercicioLINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Logic
{
    public class CustomersLogic : BaseLogic, IListLogic<Customers>
    {
        public string GetFirst()
        {
            var customer = context.Customers.First();

            return $"Id Customer: {customer.CustomerID}, Company Name: {customer.CompanyName}";
        }

        public List<Customers> GetList()
        {
            return context.Customers.ToList();
        }

        public List<Customers> Region()
        {
            var query = context.Customers.Where(x => x.Region.Equals("WA"));

            return query.ToList();
        }

        public List<string> CustomersName()
        {
            var query = context.Customers.Select(x => x.CompanyName);

            return query.ToList();
        }

        public List <CustomerOrders> JoinCustomersOrders()
        {

            var query = from customers in context.Customers
                        join orders in context.Orders
                        on customers.CustomerID equals orders.CustomerID
                        where orders.OrderDate > new DateTime(1997, 1, 1)
                        && customers.Region.Equals("WA")
                        select new CustomerOrders
                        {
                            CustomerId = customers.CustomerID,
                            CompanyName = customers.CompanyName,
                            CustomerRegion = customers.Region,
                            OrderId = orders.OrderID,
                            OrderDate = (DateTime)orders.OrderDate
                        };

            return query.ToList();

           
        }


        public List<Customers> WACustomers()
        {
            var query = context.Customers.Where(x => x.Region.Equals("WA"));

            return query.Take(3).ToList();

        }

     
        
    }
}