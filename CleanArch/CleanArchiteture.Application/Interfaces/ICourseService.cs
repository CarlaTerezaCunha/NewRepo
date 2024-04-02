using CleanArchiteture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchiteture.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses ();
    }
}
