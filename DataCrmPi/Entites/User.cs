using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi.Entites
{
    public class User
    { 
        [Key]
        
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(20)]
        [DataType(DataType.Text)]
        public String Name { get; set; }


        [Required(AllowEmptyStrings = false)]
        [MaxLength(20,ErrorMessage = "error")]
        [DataType(DataType.Text)]
        public String LastName { get; set; }


        [Required(AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "error")]
        [DataType(DataType.Text)]
        public String Adress { get; set; }


        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public int PhoneNumber { get; set; }


        




    }
}
