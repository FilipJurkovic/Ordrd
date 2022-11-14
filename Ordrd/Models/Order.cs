namespace Ordrd.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public List<OrderedFood> Foods { get; set; } = null!;
        public Status OrderStatus { get; set; } = Status.Backlog;

    }

    public enum Status
    {
        Backlog,
        Preparing,
        Finished,
    }

}
