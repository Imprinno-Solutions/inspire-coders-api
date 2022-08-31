﻿using InspireCoders.Domain.Entities;

namespace InspireCoders.Application.Contracts.FakeDataStores
{
    public interface ICourseFakeDataStore
    {
        Task AddCourse(Course course);
        Task<IEnumerable<Course>> GetAllCourses();
    }
}