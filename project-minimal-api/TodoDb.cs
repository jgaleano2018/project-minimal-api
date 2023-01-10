using Microsoft.EntityFrameworkCore;
using System;

namespace project_minimal_api
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
       
    }
}
