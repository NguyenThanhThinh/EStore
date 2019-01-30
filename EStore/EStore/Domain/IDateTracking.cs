using System;

namespace EStore.Domain
{
    public interface IDateTracking
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
