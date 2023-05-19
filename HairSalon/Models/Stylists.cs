using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylists
  {
    public int StylistId { get; set; }
    public string StylistName { get; set; }
    public string Speciality { get; set; }
    public List<Client> Clients { get; set; }
  }
}