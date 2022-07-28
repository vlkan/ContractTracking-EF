using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public static class Messages
{
    public static string CustomerAdded = "Customer Added";
    public static string CustomerDeleted = "Customer Deleted";
    public static string CustomerUpdated = "Customer Updated";
    public static string CustomerListed = "Customers Listed";
    public static string CustomerAlreadyExist = "Customer is Already Exist";
    public static string AuthorizationDenied = "Auth Issue";
}
