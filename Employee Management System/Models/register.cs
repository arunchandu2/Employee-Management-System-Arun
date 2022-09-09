using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class register
    {
        [Key]
        public string EmployeeFirstName { get;set; }   
        
        public string EmployeeLastName { get;set; } 

        public string Email { get; set; }

        public string   EmployeeAdress { get; set; }

        public string EmployeeRole { get; set; }

        public string Phonenumber  { get; set; }

        public string Password { get; set; }





    }
}
