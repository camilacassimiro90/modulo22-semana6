namespace modulo2_semana6_test;

public class VerdadeiroFalsoTest : ConfiguracaoHostApi
{
  [Theory]
  [InlineData("verdadeiro")]
  public async Task Teste_Api_Verdadeiro_Falso_Sucesso(string type)
  {
    var result = await client.GetAsync($"/ExercicioVerdadeiroFalso/{type}");
    Assert.NotNull(result);

    var responseApi = await result.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.Equal("verdadeiro", responseApi);
  }

  [Theory]
  [InlineData("Nome")]
  [InlineData("verdade")]
  public async Task Teste_Api_Verdadeiro_Falso_Erro(string type)
  {
    var result = await client.GetAsync($"/ExercicioVerdadeiroFalso/{type}");
    Assert.NotNull(result);

    var responseApi = await result.Content.ReadAsStringAsync();
    Assert.NotNull(responseApi);
    Assert.NotEqual("Texto diferente de verdadeiro ou falso", responseApi);
  }
}