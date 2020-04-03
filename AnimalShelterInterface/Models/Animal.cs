namespace AnimalShelterInterface.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Photo { get;set; }
    public string Type { get; set; }
    public string Personality { get; set; }
    public int PowerStatus { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public bool LookingForSlave { get; set; }

    // public static List<Animal> GetAnimals()
    // {
    //   var apiCallTask = ApiHelper.GetAll()
    // }
  }
}