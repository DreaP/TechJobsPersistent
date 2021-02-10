using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public int EmployerId { get; set; }
        public string JobName { get; set; }
        public List<SelectListItem> Employers { get; set; }
    }
}
