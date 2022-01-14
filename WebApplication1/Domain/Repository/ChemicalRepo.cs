using HectreMgmt.Domain.Interface;
using HectreMgmt.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace HectreMgmt.Domain.Repository
{
    public class ChemicalRepo : IListPagingRepo<Chemical>
    {
        private readonly DbSet<Chemical> chemicalTable;

        public ChemicalRepo(AppDbContext dbContext)
        {
            this.chemicalTable = dbContext.Chemicals;
        }

        public List<Chemical> Gets(int cursor, int pageSize)
        {
            return chemicalTable.Take(pageSize).ToList();
        }
    }
}
