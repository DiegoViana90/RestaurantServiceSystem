using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using RestaurantServiceSystem.Models;
using System.Collections.Generic;
using System.Diagnostics;


namespace RestaurantServiceSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Insere no banco de dados comida ou bebida ao estoque.
        /// </summary>
        /// <param name="InsertMenuItensRequest">Filtros.</param>
        /// <returns>OK</returns>
        /// <response code="200">Insert realizado com sucesso.</response>
        /// <response code="400"></response>

        [HttpPost] 
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public ActionResult<string> PostProduct([FromBody] InsertMenuItensRequest InsertMenuItensRequest)
        {
            try
            {
                var teste = "to testando aqui";
             

                return Ok(teste);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar a requisição.");
                return BadRequest("Ocorreu um erro ao processar a requisição.");
            }
        }


        [NonAction]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [NonAction]
        public IActionResult Product()
        {
            return View();
        }
    }
}
