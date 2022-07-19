using System.Text;

namespace modulo2_semana6_test;

public class SomaTeste : ConfiguracaoHostApi
{
  [Theory]
  [InlineData(5)]
  public async Task Teste_Api_Soma_Sucesso(int soma)
  {
    var resultado = await client.GetAsync($"/ExercicioSoma/{soma}");
    Assert.NotNull(resultado);

    string expectativa = $"O resultado da soma é: {soma}";
    var responseApi = await resultado.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.Equal(expectativa, responseApi);
  }

  [Theory]
  [InlineData(5)]
  public async Task Teste_Api_Soma_Erro(int soma)
  {
    var resultado = await client.GetAsync($"/ExercicioSoma/{soma}");
    Assert.NotNull(resultado);

    string expectativa = $"O resultado da soma é: {soma}";
    var responseApi = await resultado.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.Equal(expectativa, responseApi);
  }

}