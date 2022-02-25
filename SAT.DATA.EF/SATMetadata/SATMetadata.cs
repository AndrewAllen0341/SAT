using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF//.SATMetadata
{
    #region Course Metadata
    public class CourseMetadata
    {
        [Required]
        [Display(Name = "Course ID")]
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
        [StringLength(250, ErrorMessage = "Max 250 characters.")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage = "Max 500 characters.")]
        public string Notes { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }
    #endregion

    #region Enrollment Metadata
    class EnrollmentMetadata
    {
        [Required]
        [Display(Name = "Enrollment ID")]
        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        public System.DateTime EnrollmentDate { get; set; }

        [Required]
        [Display(Name = "Scheduled Class")]
        public virtual ScheduledClass ScheduledClass { get; set; }

        [Required]
        [Display(Name = "Student")]
        public virtual Student Student { get; set; }
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {

    }
    #endregion

    #region ScheduledClassStatus Metadata
    class ScheduledClassStatusMetadata
    {
        [Required]
        [Display(Name = "Scheduled Class Status ID")]
        public int SCSID { get; set; }

        [Required]
        [Display(Name = "Scheduled Class Status Name")]
        [StringLength(50, ErrorMessage = "Max 50 characters.")]
        public string SCSName { get; set; }
    }

    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus
    {

    }
    #endregion

    #region ScheduledClass Metadata
    class ScheduledClassMetadata
    {
        [Required]
        [Display(Name = "Scheduled Class ID")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage = "Max 40 characters.")]
        public string InstructorName { get; set; }

        [Required]
        [Display(Name = "Location")]
        [StringLength(20, ErrorMessage = "Max 20 characters.")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "SCSID")]
        public int SCSID { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {
        public string ClassInformation
        {
            get
            {
                return $"Instructor: {InstructorName} | Start Date: {StartDate:d} | Location: {Location}";
            }
        }
    }
        #endregion

        #region Student Metadata
        public class StudentMetadata
        {
            [Required]
            [Display(Name = "Student ID")]
            public int StudentId { get; set; }

            [Required]
            [Display(Name = "First Name")]
            [StringLength(20, ErrorMessage = "Max 20 characters.")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            [StringLength(20, ErrorMessage = "Max 20 characters.")]
            public string LastName { get; set; }

            [StringLength(15, ErrorMessage = "Max 15 characters.")]
            public string Major { get; set; }

            [StringLength(50, ErrorMessage = "Max 50 characters.")]
            public string Address { get; set; }

            [StringLength(25, ErrorMessage = "Max 25 characters.")]
            public string City { get; set; }

            [StringLength(2, ErrorMessage = "Max 2 characters.")]
            public string State { get; set; }

            [Display(Name = "Zip Code")]
            [StringLength(10, ErrorMessage = "Max 10 characters.")]
            public string ZipCode { get; set; }

            [StringLength(13, ErrorMessage = "Max 13 characters.")]
            public string Phone { get; set; }

            [Required]
            [StringLength(60, ErrorMessage = "Max 60 characters.")]
            public string Email { get; set; }

            [Display(Name = "Photo Url")]
            public string PhotoUrl { get; set; }

            [Required]
            [Display(Name = "Student Status ID")]
            public int SSID { get; set; }
        }

        [MetadataType(typeof(StudentMetadata))]
        public partial class Student
        {
            [Display(Name = "Full Name")]
            public string FullName
            {
                get { return $"{FirstName} {LastName}"; }
            }
        }
        #endregion

        #region StudentStatus Metadata
        public class StudentStatusMetadata
        {
            [Required]
            [Display(Name = "Student Status ID")]
            public int SSID { get; set; }

            [Required]
            [Display(Name = "Student Status Name")]
            [StringLength(30, ErrorMessage = "Max 30 characters.")]
            public string SSName { get; set; }

            [Display(Name = "Student Status Description")]
            [StringLength(250, ErrorMessage = "Max 250 characters.")]
            public string SSDescription { get; set; }
        }

        [MetadataType(typeof(StudentStatusMetadata))]
        public partial class StudentStatus
        {

        }
        #endregion
    }