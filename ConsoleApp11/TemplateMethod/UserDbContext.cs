namespace ConsoleApp11.TemplateMethod;

public class UserDbContext : DbContext
{
    public override void OnConfiguring()
    {
        //...
    }

    public override void OnModelCreating()
    {
        //...
    }
}
