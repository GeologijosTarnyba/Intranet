public static class ExtensionMethods
{
  public static Microsoft.AspNetCore.Components.MarkupString? NonBreaking(this string? str)
  {
    // TODO: check input for html
    if (str == null)
      return null;
    return (Microsoft.AspNetCore.Components.MarkupString)str.Replace(" ", "&nbsp;");
  }
  public static string LT(this DateOnly t)
  {
    return t.ToString("yyyy-MM-dd");
  }
  public static string LT(this DateTime t, bool ShowTime = false)
  {
    var format = (ShowTime) switch {
      (true) => "yyyy-MM-dd HH:mm",
      (false) => "yyyy-MM-dd"
    };
    return t.ToString(format);
  }
  public static string? LT(this DateTime? t, bool ShowTime = false)
    => t?.LT(ShowTime);

  public static IQueryable<TProperty> EntityCollection<TEntity, TProperty>(
    this Microsoft.EntityFrameworkCore.DbContext db
    , TEntity entity
    , System.Linq.Expressions.Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression
  )
    where TEntity : class
    where TProperty : class
  {
    return db.Entry(entity).Collection(propertyExpression).Query();
  }
  public static IQueryable<TProperty> EntityReference<TEntity, TProperty>(this Microsoft.EntityFrameworkCore.DbContext db
    , TEntity entity
    , System.Linq.Expressions.Expression<Func<TEntity, TProperty?>> propertyExpression)
    where TEntity : class
    where TProperty : class
  {
    return db.Entry(entity).Reference(propertyExpression!).Query();
  }
}
