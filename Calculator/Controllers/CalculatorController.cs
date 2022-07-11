using Calculator.Bl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        ICalculator Calculator;
        public CalculatorController(ICalculator calculator)
        {
            this.Calculator = calculator;
        }

        [HttpPost("Calculate")]
        public IActionResult Calculate([FromBody] Excersize execrsize)
        {
            return Ok(Calculator.Calculate(execrsize.Text));
        }
    }
    public class Excersize
    {
        public string Text { get; set; }
    }
}
