using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF//.SATMetadata
{
    class CourseMetadata
    {
        [Required]
        [Display(Name="Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        [StringLength(50, ErrorMessage = "Max 50 characters.")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [Display(Name = "Curriculum")]
        public string Curriculum { get; set; }

        public string Notes { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }

}