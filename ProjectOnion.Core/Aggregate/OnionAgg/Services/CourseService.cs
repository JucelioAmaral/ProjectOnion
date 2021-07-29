using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Services;
using ProjectOnion.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOnion.Core.Aggregate.OnionAgg.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourse _courseRepository;
        public CourseService(ICourse course)
        {
            _courseRepository = course;
        }
        public List<Course> GetCourse()
        {
            return _courseRepository.GetCourse();
        }

        public Course GetCourseId(int Id)
        {
            return _courseRepository.GetCourseId(Id);
        }

        public ResponseObject<Course> InsertCourse(Course NewCourse)
        {
            if (DateTime.Now > NewCourse.StartDate)
            {
                return new ResponseObject<Course>(false, "A data de inicio deve ser maior que a atual");
            }
            if (_courseRepository.GetCourseValidationDate(NewCourse))
            {
                return new ResponseObject<Course>(false, "Existe(m) curso(s) planejados(s) dentro do período informado.");
            }

            _courseRepository.InsertCourse(NewCourse);

            return new ResponseObject<Course>(true, "Criado com sucesso!", obj: NewCourse);
        }
        public void DeleteCourse(int Id)
        {
            _courseRepository.DeleteCoursey(Id);
        }
        public ResponseObject<Course> UpdateCourse(Course NewCourse)
        {
            if (DateTime.Now > NewCourse.StartDate)
            {
                return new ResponseObject<Course>(false, "A data de inicio deve ser maior que a atual");
            }
            if (_courseRepository.GetCourseValidationDate(NewCourse))
            {
                return new ResponseObject<Course>(false, "Existe(m) curso(s) planejados(s) dentro do período informado.");
            }

            _courseRepository.UpdateCourse(NewCourse);

            return new ResponseObject<Course>(true, "Atualizado com sucesso!", obj: NewCourse);
        }

    }
}
