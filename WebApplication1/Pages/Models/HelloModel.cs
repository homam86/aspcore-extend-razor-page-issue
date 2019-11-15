using System;

namespace WebApplication1.Pages.Models
{
    public class HelloModel
    {
        public string Name { get; set; }

        public HelloModel(string name)
        {
            Name = name;
        }
    }
}
