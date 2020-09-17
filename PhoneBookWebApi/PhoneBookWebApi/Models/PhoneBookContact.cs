using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookWebApi.Models
{
    public class PhoneBookContact
    {
        [Key] 
        public int ContactID { get; set; }
        
        [Required] 
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string EmailAddress { get; set; }

    }
}
