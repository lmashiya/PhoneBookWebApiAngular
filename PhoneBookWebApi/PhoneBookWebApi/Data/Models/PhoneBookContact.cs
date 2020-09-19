using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using PhoneBookWebApi.Data.Interfaces;

//using PhoneBookWebApi.Data.Interfaces;

namespace PhoneBookWebApi.Models 
{
    public class PhoneBookContact : IEntity
    {
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
        [Key]
        public int ContactID { get; set; }
    }
}
