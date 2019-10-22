using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi.Entites
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<Reaction> Reaction { get; set; }

    }
}
