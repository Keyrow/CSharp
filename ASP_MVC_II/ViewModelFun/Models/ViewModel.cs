using System;
using System.Collections.Generic;

namespace ViewModelFun.Models
{
    public class MyModels
    {
        public string Message {get; set;}
        public List<int> Numbers = new List<int>();
        public List<string> Users = new List<string>();
        public string User {get; set;}
    }
}