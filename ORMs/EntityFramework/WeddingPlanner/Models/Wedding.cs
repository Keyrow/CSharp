using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{

    public class Wedding
    {
        [Key]
        public int Id { get; set; }
        public string Groom { get; set; }
        public string Bride { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int UserId { get; set; }
        public User Creator { get; set; }
        public List<Invite> Guests { get; set; }
        public Wedding()
        {
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
            Guests = new List<Invite>();
        }
    }
    public class Invite
    {
        [Key]
        public int Id { get; set; }
        public int WeddingId { get; set; }
        public Wedding Wedding { get; set; }
        public int UserId { get; set; }
        public User InvitedUser { get; set; }
    }
}