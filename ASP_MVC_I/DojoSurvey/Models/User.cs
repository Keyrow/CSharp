using System;
using System.Collections.Generic;

namespace DojoSurvey.Models
{
    public class User
    {
        public string Name {get; set;}
        public List<string> Location {get; set;}
        public List<string> Language {get; set;}
        public string Comment {get; set;}

        public User()
        {
            Name = "John Doe";
            Location = new List<string>{"", "Seattle, WA, Coding Dojo", "Arlington, VA, Coding Dojo", "Boise, ID, Coding Dojo", "Chicago, IL, Coding Dojo",
            "Dallas, TX, Coding Dojo", "Los Angeles, CA, Coding Dojo", "Oakland, CA, Coding Dojo", "Orange County, CA, Coding Dojo",
            "Silicon Valley, CA, Coding Dojo", "Tulsa. OK, Coding Dojo"};
            Language = new List<string>{"C#", "Java", "Python", "Javascript", "GOlang", "Skala", "PHP"};
            Comment = "No comments";
        }
        public User(string name, List<string> location, List<string> language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }
    }
}