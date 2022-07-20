using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

foreach (var customer in customerManager.GetAll()) 
{
    Console.WriteLine(customer.Name);
}