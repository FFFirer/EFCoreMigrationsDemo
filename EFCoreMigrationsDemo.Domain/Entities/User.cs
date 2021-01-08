using System;

namespace EFCoreMigrationsDemo.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
