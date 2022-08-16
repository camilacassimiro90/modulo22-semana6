using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace modulo2_semana6_api.Controllers;

///<summary>
///Exercicio 4
///</summary>
[ApiController]
[Route("[controller]")]
public class ExercicioEmailController : ControllerBase
{
  ///<summary>
  /// Implementar a regra do exercicio 4 aqui dentro do método GET
  /// </summary>
  /// <param name="email"></param>
  /// <returns></returns>
  [HttpGet("{email}")]
  public string Get(string email)
  {
    string regex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    Regex validation = new(regex);

    if (DateTime.Now.Minute >= 30)
    {
      throw new TrintaMinutosException("Erro na requsição o minuto está acima de 30");
    }

    if (!validation.IsMatch(email))
    {
      return "Email inválido";
    }

    return email;
  }
}


[Serializable]
public class TrintaMinutosException : Exception
{
  public TrintaMinutosException() { }
  public TrintaMinutosException(string message) : base(message) { }
  public TrintaMinutosException(string message, Exception inner) : base(message, inner) { }
  protected TrintaMinutosException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}