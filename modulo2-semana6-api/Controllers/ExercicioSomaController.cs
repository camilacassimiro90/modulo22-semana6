using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

///<summary>
///Exercicio 4
///</summary>
[ApiController]
[Route("[controller]")]
public class ExercicioSomaController : ControllerBase
{
  ///<summary>
  /// Implementar a regra do exercicio 8 aqui dentro do método GET
  /// </summary>
  /// <param name="ValorA"></param>
  /// <param name="ValorB"></param>
  /// <returns></returns>

  [HttpGet("{valorA}/{valorB}")]
  public string Get(int valorA, int valorB)
  {
    try
    {
      var resultado = valorA + valorB;

      if (resultado < 10)
        return $"O resultado da soma é: {resultado}";

      var numeroRandomico = new Random().Next();
      return $"{numeroRandomico}";
      throw new Exception($"{numeroRandomico}");
    }
    catch (Exception ex)
    {

      return $"Erro: {ex}";
    }
  }
}