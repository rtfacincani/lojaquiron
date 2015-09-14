using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

         protected override void OnModelCreating(DbModelBuilder modelBulder)
         {
             modelBulder.Conventions.Remove<PluralizingTableNameConvention>();
             modelBulder.Entity<Produto>().ToTable("Produtos");
         } 
    }
}
