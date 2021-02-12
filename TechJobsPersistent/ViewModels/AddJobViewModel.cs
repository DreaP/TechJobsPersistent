using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 15 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer Id is required.")]
        public int EmployerId { get; set; }

        [Required]
        public List<SelectListItem> Employers { get; set; }

        [Required(ErrorMessage = "Please add skills.")]
        public List<int> SkillsId { get; set; }

        public List<Skill> Skills { get; set; }
        
        //Still working this out...
        //public List<SelectListItem> Employers { get; set; }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
           
            Skills = skills;
        }

        public AddJobViewModel()
        {

        }
    }
}
