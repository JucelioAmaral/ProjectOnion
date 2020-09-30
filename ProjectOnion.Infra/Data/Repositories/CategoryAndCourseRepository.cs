using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using Slapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ProjectOnion.Infra.Data.Repositories
{
    public class CategoryAndCourseRepository : ICategoryAndCourse
    {

        private readonly IDbConnection conexao;
        //public CategoryAndCourseRepository(IConfiguration conf) => conexao = new SqlConnection("Server=tcp:castgroupcourse.database.windows.net,1433;Initial Catalog=CastGroupCourse;Persist Security Info=False;User ID=castgroupcourse;Password=rt@110700;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public CategoryAndCourseRepository(IConfiguration conf) => conexao = new SqlConnection("Data Source = 127.0.0.1; Initial Catalog = DatabaseProjectOnion; Persist Security Info=True;User ID = tmds; Password=tmds");
        public List<CategoryAndCourse> CategoryAndCourse()
        {
            var dados = conexao.Query<dynamic>(
                        "SELECT R.Id,R.Description,E.SubjectDescription as Courses_SubjectDescription,E.StartDate as Courses_StartDate,E.EndDate as Courses_EndDate,E.NumberStudents as Courses_NumberStudents,E.Id as Courses_Id " +
                        "FROM dbo.Category R " +
                        "INNER JOIN dbo.Course E ON E.IdCategory = R.id");
            AutoMapper.Configuration.AddIdentifier(
                typeof(Category), "Id");
            AutoMapper.Configuration.AddIdentifier(
                typeof(Course), "Id");
            List<CategoryAndCourse> categories = (AutoMapper.MapDynamic<CategoryAndCourse>(dados)
                as IEnumerable<CategoryAndCourse>).ToList();
            return categories;

        }
    }
}
