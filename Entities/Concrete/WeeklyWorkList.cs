using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WeeklyWorkList
    {
        public string EmployeeNameSurname { get; set; }
        public string ProjectName { get; set; }
        public int NumberOfDaysWorked { get; set; }
        public DateTime? WeeklyWorkingDate { get; set; }
    }
}
