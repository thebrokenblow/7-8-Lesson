﻿namespace ConsoleApp11.TemplateMethod;

public abstract class DbContext
{

    public DbContext()
    {
        OnConfiguring();
        OnModelCreating();
    }

    public abstract void OnConfiguring();
    public abstract void OnModelCreating();
}