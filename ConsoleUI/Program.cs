using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//CustomerTest();

PaymentTest();

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

    foreach (var customer in customerManager.GetAll().Data)
    {
        Console.WriteLine(customer.Name);
    }
}

static void PaymentTest()
{
    PaymentManager paymentManager = new PaymentManager(new EfPaymentDal());

    foreach (var payment in paymentManager.GetAll())
    {
        Console.WriteLine(payment.FeePaid);
    }
}