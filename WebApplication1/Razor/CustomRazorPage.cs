using System;

namespace WebApplication1.Razor
{
public abstract class CustomRazorPage : Microsoft.AspNetCore.Mvc.RazorPages.Page
{
    public string SayHi(string name)
    {
        return $"Hi <strong>{name}</strong>";
    }
}
}
