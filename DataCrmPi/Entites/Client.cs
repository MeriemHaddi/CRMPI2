using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi.Entites
{
   public class Client:User
    {
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public String Email { get; set; }


        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"(?=.*\W)?(?=.*\d)", ErrorMessage = "Error message")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Password { get; set; }


        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^[^,\.\^]+$")]
        [DataType(DataType.Text)]
        public String UserName { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }

    }
}
