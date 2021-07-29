using Dapper;
using Microsoft.Extensions.Configuration;
using ProjectOnion.Core.Aggregate.OnionAgg.Entities;
using ProjectOnion.Core.Aggregate.OnionAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectOnion.Infra.Data.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly IDbConnection conexao;
        
        public CategoryRepository(IConfiguration conf) => conexao = new SqlConnection("Data Source=localhost;Initial Catalog=DatabaseProjectOnion;Integrated Security=True");

        public List<Category> GetCategory()
        {
            return this.conexao.Query<Category>("SELECT * FROM Category").ToList();

        }
        public Category GetCategoryId(int Id)
        {
            return this.conexao.Query<Category>("SELECT * FROM Category WHERE @Id = Id", new { Id = Id }).SingleOrDefault();
        }
        public void InsertCategory(Category Description)
        {
            this.conexao.Execute(@"INSERT Category(Description) VALUES (@Description)",
             new { Description = Description.Description });
        }
        public void DeleteCategory(int Id)
        {
            this.conexao.Execute(@"DELETE FROM Category WHERE @Id = id", new { Id = Id });
        }
        public void UpdateCategory(Category Description)
        {
            this.conexao.Execute("UPDATE Category SET Description=@Description WHERE Id=" + Description.Id,
           new { Description = Description.Description });
        }
    }
}
