using Microsoft.EntityFrameworkCore;

namespace LGT.Incidentai;
public class Database : DbContext
{
  public DbSet<Models.Incidentas> Incidentai => Set<Models.Incidentas>();
}
