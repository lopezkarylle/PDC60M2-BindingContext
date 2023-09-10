using System;
using System.Collections.Generic;
using System.Text;
using pdc6_mod2.Model;

namespace pdc6_mod2.ViewModel
{
    class TaskViewModel
    {
        public Taskmodel TaskModelSet { get; set; }
        public TaskViewModel() 
        {
            TaskModelSet = new Taskmodel
            {
                SubjectCode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,
            };
        }
    }
}
