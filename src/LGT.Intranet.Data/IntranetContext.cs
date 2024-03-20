using Microsoft.EntityFrameworkCore;

namespace LGT.Intranet;
public class IntranetContext(DbContextOptions<IntranetContext> options) : DbContext(options)
{
  public DbSet<Models.Page> Pages => this.Set<Models.Page>();
  public DbSet<Models.Column> Columns => this.Set<Models.Column>();
  public DbSet<Models.Group> Groups => this.Set<Models.Group>();
  public DbSet<Models.Link> Links => this.Set<Models.Link>();
  public DbSet<Models.Message> Messages => this.Set<Models.Message>();
  public DbSet<Models.Article> Articles => this.Set< Models.Article>();

	protected override void OnModelCreating(ModelBuilder mb)
  {
    //mb.Model.SetMaxIdentifierLength(30); // Fixes ORA-00972 // https://stackoverflow.com/questions/62275227/ora-00972-identifier-is-too-long-error-with-ef-core-2-2-code-first-migration
    base.OnModelCreating(mb);
  }
}
