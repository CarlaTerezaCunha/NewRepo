using CleanArchiteture.Application.Interfaces;
using CleanArchiteture.Application.ViewModels;
using CleanArchiteture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchiteture.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };

        }
    }
}
