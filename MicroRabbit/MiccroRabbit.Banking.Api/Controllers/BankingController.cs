using MicroRabbbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiccroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankingController : ControllerBase
    {
        
        private readonly ILogger<BankingController> _logger;
        private readonly IAccountService _accountService;

        public BankingController(ILogger<BankingController> logger, IAccountService accountService )
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer )
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);

        }
    }
}