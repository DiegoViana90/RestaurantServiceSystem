using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using RestaurantServiceSystem.API.Models.Request;

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
        /// <param name="insertMenuItensRequest">Filtros.</param>
        /// <returns>OK</returns>
        /// <response code="200">Insert realizado com sucesso.</response>
        /// <response code="400"></response>

        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public ActionResult<string> PostProduct([FromBody] InsertMenuItensRequest insertMenuItensRequest)
        {
            try
            {
                //InsertMenuItens(insertMenuItensRequest);
                return Ok(testee);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar a requisição.");
                return BadRequest("Ocorreu um erro ao processar a requisição.");
            }
        }
    }
}
