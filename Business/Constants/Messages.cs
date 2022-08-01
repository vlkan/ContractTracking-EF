using Core.Entities.Concrete;
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
    internal static string UserRegistered = "User Registered";
    internal static string UserNotFound = "User Not Found";
    internal static string PasswordError = "Your password is incorrect";
    internal static string SuccessfulLogin = "Correct Email and Password";
    internal static string UserAlreadyExists = "This user already exist";
    internal static string AccessTokenCreated = "Access Token Created";
    internal static string ProjectAdded = "Project Added";
    internal static string ProjectDeleted = "Project Deleted";
    internal static string ProjectUpdated = "Project Updated";
}
