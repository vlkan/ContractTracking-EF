using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

foreach (var customer in customerManager.GetAllById(1)) 
{
    Console.WriteLine(customer.Name);
}