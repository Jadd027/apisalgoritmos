
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
 
namespace AlgoritmosApi.Controllers
{

	[ApiController]
	[Route("[controller]")]

	public class Multiplode3 : ControllerBase
	{
		[HttpGet("{num}")]
		public IActionResult Get([Required] int num)
		{
			string multiplo = "";
			string intervalo = "";
			if (num > 0)
			{
				if (num >= 99 && num <= 201)
				{
					if (num % 3 == 0)
					{
						multiplo = "es multilo de 3";
						intervalo = "si esta entre 100 y 200";
					}
					else
					{
						multiplo = "no es multilo de 3";
						intervalo = "si esta entre 100 y 200";
					}
				}
				else
				{
					if (num % 3 == 0)
					{
						multiplo = "es múltiplo de 3";
						intervalo = "no esta entre 100 y 200";
					}
					else
					{
						multiplo = "no es múltiplo de 3";
						intervalo = "no esta entre 100 y 200";
					}
				}
				return Content($"El numero {num} {multiplo} y {intervalo}");
			}
			else
			{
				return BadRequest($"El valor {num} no corresponde a un Entero");
			}
		}
	}
}
