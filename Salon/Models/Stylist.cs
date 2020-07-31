namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}