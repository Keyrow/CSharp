using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BeltExam.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public User()
        {
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
        }
    }
    public class Hobby
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Join> Enthusiasts { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public Hobby()
        {
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
            Enthusiasts = new List<Join>();
        }
    }

    public class Enthusiast
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
    public class Join
    {
        [Key]
        public int Id { get; set; }
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }
        public int UserId { get; set; }
        public User JoinedUser { get; set; }
    }
}