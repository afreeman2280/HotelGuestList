using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic;
using BusinessLogic.BusinessLogicObject;

namespace LearningMVC2.Models
{
     
    public class UserViewModel
    {
        public UserModel SingleUser { get; set; }
        public List<UserModel> AllUsers { get; set; }
    }
}