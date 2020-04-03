using System.Threading.Tasks;
using System;
using RestSharp;

namespace AnimalShelterInterface.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest("Animals", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

  }
}