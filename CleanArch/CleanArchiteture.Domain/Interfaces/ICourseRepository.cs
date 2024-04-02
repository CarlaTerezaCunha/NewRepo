using CleanArchiteture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchiteture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
