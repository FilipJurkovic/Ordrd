namespace Ordrd.Models
{
    public class OrderedFood
    {
        public int Id { get; set; }
        public Food Food { get; set; } = null!;

        public List<Option> SelectedOptions { get; set; } = null!;

        public int Quatity { get; set; }
    }
}
