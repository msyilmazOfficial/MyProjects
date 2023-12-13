using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService CurrencyService;

        public CurrencyController(ICurrencyService CurrencyService)
        {
            this.CurrencyService = CurrencyService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCurrency()
        {
            var Currencys = await CurrencyService.GetCurrency();
            return Ok(Currencys);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetCurrencyById(int id)
        {
            var Currency = await CurrencyService.GetCurrencyById(id);
            if (Currency != null)
            {
                return Ok(Currency);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCurrency(Currency Currency)
        {
            var createCurrency = await CurrencyService.CreateCurrency(Currency);
            return CreatedAtAction("GetCurrencyById", new { id = Currency.Id }, createCurrency);
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCurrency(Currency Currency)
        {
            if (CurrencyService.GetCurrencyById(Currency.Id) != null)
            {
                return Ok(await CurrencyService.UpdateCurrency(Currency));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteCurrency(int id)
        {
            if (await CurrencyService.GetCurrencyById(id) != null)
            {
                await CurrencyService.DeleteCurrency(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
