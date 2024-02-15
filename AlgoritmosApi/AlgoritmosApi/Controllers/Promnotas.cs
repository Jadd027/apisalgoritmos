using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace AlgoritmosApi.Controllers

{

	[ApiController] //Indica que la clase es un controlador de API

	[Route("[controller]")] //Indica la ruta del controlador

	public class Promnotas : ControllerBase //Controlbase convierte a controlador MVC y API

	{

		public double PromedioNotas; //Se define la variable

		[HttpPost("promedioNotas")] //Nombre que va a recibir parte de la url

		public IActionResult Post([Required] int num1, [Required] int num2, [Required] int num3)

		// Pilas con los tipo de Dato

		{

			if (num1 > 0 && num2 > 0 && num3 > 0)

			{

				double PromTotal = (num1 + num2 + num3) / 3.0; // Calcular el promedio

				PromTotal = Math.Round(PromTotal, 2); // Redondear el promedio a 2 decimales

				return Content($"El promedio de las notas es: {PromTotal}"); // Mostrar el promedio

			}

			else

			{

				return Content("Los valores digitados deben ser positivos");

			}

		}

		//Se crea metodo que realice el promedio de las 3 notas

		/*public double PromedioNotasTotal(int num1, int num2, int num3)

        {

            //Al estar dentro de un metodo que ya contiene un private/public no se vuelve a poner adentro

            double PromTotal = (num1 + num2 + num3) / 3.0;

            return PromTotal;   

        }*/

	}

}
