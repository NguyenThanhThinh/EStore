using System;

namespace EStore.Domain.Entities
{
    public class User : Entity<int>,IDateTracking
    {
        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
    }
}
