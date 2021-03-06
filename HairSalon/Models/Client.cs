namespace Salon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string City { get; set; } = "Portland";
    public int StylistId { get; set; } = 0;

    public virtual Stylist Stylist { get; set; }
  }
}