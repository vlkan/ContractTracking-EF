using Core.Entities.Concrete;
using Entities.Concrete;
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
    public static string UserRegistered = "User Registered";
    public static string UserNotFound = "User Not Found";
    public static string PasswordError = "Your password is incorrect";
    public static string SuccessfulLogin = "Correct Email and Password";
    public static string UserAlreadyExists = "This user already exist";
    public static string AccessTokenCreated = "Access Token Created";

    public static string ProjectAdded = "Project Added";
    public static string ProjectDeleted = "Project Deleted";
    public static string ProjectUpdated = "Project Updated";
    public static string ProjectListed = "Projects Listed";

    public static string EmployeeAdded = "Employee Added";
    public static string EmployeeDeleted = "Employee Deleted";
    public static string EmployeeUpdated = "Employee Updated";
    public static string EmployeeListed = "Employees Listed";

    public static string NotificationAdded = "Notification Added";
    public static string NotificationUpdated = "Notification Updated";
    public static string NotificationDeleted = "Notification Deleted";
    public static string NotificationListed = "Notifications Listed";

    public static string PaymentAdded = "Invoice Added";
    public static string PaymentDeleted = "Invoice Deleted";
    public static string PaymentUpdated = "Invoice Updated";
    public static string PaymentListed = "Invoices Listed";

    public static string WorkListAdded = "Worklist Added";
    public static string WorkListUpdated = "WorkList Updated";
    public static string WorkListDeleted = "WorkList Deleted";
    public static string WorkListListed = "WorkLists Listed";
}
