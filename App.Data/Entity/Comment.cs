using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int iPhoneID { get; set; }
        public string? CommentText { get; set; }

        //Navigation properties for related user and iPhone
        public User User { get; set; }
        public IPhone IPhone { get; set; }  

    }
}