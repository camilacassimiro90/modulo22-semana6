using System.Text;

namespace modulo2_semana6_test;

public class EmailTest : ConfiguracaoHostApi
{
  [Theory]
  [InlineData("email@teste.com.br")]
  public async Task Consumir_Api_Validar_Email_Sucesso(string email)
  {
    var resultado = await client.GetAsync($"/ExercicioEmail/{email}");
    Assert.NotNull(resultado);

    string expectativa = "E-mail válido!";
    var responseApi = await resultado.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.Equal(expectativa, responseApi);
  }

  [Theory]
  [InlineData("teste@algo.br")]
  public async Task Consumir_Api_Validar_Email_Erro(string email)
  {
    var resultado = await client.GetAsync($"/ExercicioEmail/{email}");
    Assert.NotNull(resultado);

    string expectativa = "E-mail inválido!";
    var responseApi = await resultado.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.Equal(expectativa, responseApi);
  }

}