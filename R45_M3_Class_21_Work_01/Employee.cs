using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R45_M3_Class_21_Work_01
{
    public sealed class Employee : Person, IRole
    {
        public Employee() {  }
        public Employee(int id, string name, DateTime birthDate, DateTime joinDate, Designation designation):base(name, birthDate)
        {
            this.Id = id; this.JoiningDate = joinDate; this.Designation = designation;
        }
        public int Id { get; set; }
        public DateTime JoiningDate { get; set; }
        public Designation Designation { get; set; }
        public string[] Roles { get; set; }
        public override int Age()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }
        public void AddRoles(string[] roles)
        {
            this.Roles = roles;
        }
        public string RolePlays()
        {
            return string.Join(",", this.Roles);
        }
    }
}
