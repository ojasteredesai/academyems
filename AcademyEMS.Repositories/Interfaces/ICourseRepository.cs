﻿using AcademyEMS.CoreDbContext.Entities;
using AcademyEMS.Data.DTO;

namespace AcademyEMS.Repositories
{
    public interface ICourseRepository
    {
        int CreateUser(Course user);
        List<CourseDTO> GetAll();
    }
}