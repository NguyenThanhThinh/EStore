namespace EStore.Domain
{
    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
