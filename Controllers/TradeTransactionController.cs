using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApi.Models;


[Route("api/[controller]")]
[ApiController]
public class TradeTransactionController : ControllerBase
{
    private readonly TradeTransactionRepository _tradetransactionRepository;

    public TradeTransactionController(TradeTransactionRepository _tradetransactionRepository)
    {
        _tradetransactionRepository = _tradetransactionRepository;
    }

    [HttpGet("{Id}")]
    public ActionResult<TradeTransaction> Get(int Id)
    {
        var transaction = _tradetransactionRepository.GetTradeTransactionById(Id);
        if (transaction == null)
        {
            return NotFound();
        }
        return transaction;
    }
}
