using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Aftaabuddin.Models
{
    public class RegisteredUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String Bacon { get; set; }
        public String PattyChoice { get; set; }
        public String MyOption { get; set; }
        public String Cheese { get; set; }
        public String ExPatties { get; set; }
        public String SpecialReq { get; set; }
        public String Cost { get; set; }
        public DateTime RegistrationDate { get; set; }



    }

}

