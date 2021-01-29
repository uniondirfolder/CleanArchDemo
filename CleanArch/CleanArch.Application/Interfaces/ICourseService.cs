
using CleanArch.Application.ViewModels;
using System.Collections.Generic;


namespace CleanArch.Application.Interfaces
{
    interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
