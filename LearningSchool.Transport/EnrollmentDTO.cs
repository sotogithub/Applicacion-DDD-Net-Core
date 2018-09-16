﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LearningSchool.Transport
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class EnrollmentDTO
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public CourseDTO Course { get; set; }
        public StudentDTO Student { get; set; }
        public List<SelectListItem> listStudent { get; set; }
        public List<SelectListItem> listCourse { get; set; }

    }
}