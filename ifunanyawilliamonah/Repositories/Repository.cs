using ifunanyawilliamonah.Models;
using System.Collections.Generic;

namespace ifunanyawilliamonah.Repositories
{
    public class Repository
    {
        public static Project one = new Project
        {
            Title = "Staff Management",
            Description = "A staff management project for managing staffs in an organisation",
            Link = "http://staffmanagementcsharp.herokuapp.com/",
            Image = "staffmanagement.png",
            BackgroundColor = "teal"
        };
        public static Project two = new Project
        {
            Title = "PoshBay Ecommerce",
            Description = "An ecommerce application where customers select product and make payment.",
            Link = "https://poshbay.herokuapp.com/",
            Image = "poshbay.JPG",
            BackgroundColor = "blue"
        };

        
        public List<Project> projects = new List<Project>()
        {
            one,
            two
        };
    }
}
