using API_DotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace API_DotNet.Data
{
    public class DataContext :DbContext
    {
        /* Construtor (Libera funcionalidades em SQL) */
        public DataContext(DbContextOptions<DataContext> options) : base(options)  
        {}

        /* Nome do Modelo - Nome do método e o get e  set */
        public DbSet<Pessoa> pessoas{ get; set; }
        
    }
}