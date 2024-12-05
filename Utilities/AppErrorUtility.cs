namespace connect_utilities.Utilities;
using Microsoft.AspNetCore.Mvc;
using connect_utilities.Models;

public class AppErrorUtility : ControllerBase
{
    public ActionResult SendServerError(string message)
    {
        return StatusCode(500, new AppResult()
        {
            Error = new ErrorViewModel { Message = message, Status = 500 },
        });
    }

    public ActionResult SendNotFoundError(string message)
    {
        return NotFound(new AppResult()
        {
            Error = new ErrorViewModel { Message = message, Status = 404 },
        });
    }

    public ActionResult SendBadRequestError(string message)
    {
        return BadRequest(new AppResult()
        {
            Error = new ErrorViewModel { Message = message, Status = 401 }
        });
    }
}