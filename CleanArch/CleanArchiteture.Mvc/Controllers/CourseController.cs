﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchiteture.Application.Interfaces;
using CleanArchiteture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchiteture.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            
            return View(model);
        }
    }
}
