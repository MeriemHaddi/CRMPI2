using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCrmPi.Entites
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
