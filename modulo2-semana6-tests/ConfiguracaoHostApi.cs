using Microsoft.AspNetCore.Mvc.Testing;

namespace modulo2_semana6_test
{
  public class ConfiguracaoHostApi
  {
    private const string url = "http://localhost:50009";
    private protected HttpClient client;

    public ConfiguracaoHostApi()
    {
      var application = new WebApplicationFactory<Program>();
      application.ClientOptions.BaseAdress = new(url);
      client = application.CreateClient();
    }
  }
}