using System;
using System.Collections.Generic;
using SampleDataBinding.Models;

namespace SampleDataBinding.ViewModels
{
    public class GenericRepoViewModel
    {
        public string pageTitle { get; set; }
        public List<Student> studentsList { get; set; }
        public int studentsNum { get; set; }
 

        public GenericRepoViewModel()
        {
            pageTitle = "Inventory";
            studentsList = new List<Student>();
            studentsList.Add(new Student { name = "Moos", age = 42 });
            studentsList.Add(new Student { name = "Megha", age = 18 });
            studentsList.Add(new Student { name = "Tushar", age = 28 });
            studentsList.Add(new Student { name = "Derya", age = 34 });

            studentsNum = studentsList.Count;
        }
    }
}
