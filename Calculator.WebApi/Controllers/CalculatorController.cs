using Calculator.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public abstract class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculator _calculator;

        protected CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet]
        [Route("add")]
        public double GetAdd(double firstNumber, double secondNumber)
        {
            return _calculator.Add(firstNumber, secondNumber);
        }

        [HttpGet]
        [Route("sub")]
        public double GetSub(double firstNumber, double secondNumber)
        {
            return _calculator.Sub(firstNumber, secondNumber);
        }

        [HttpGet]
        [Route("multiply")]
        public double GetMultiply(double firstNumber, double secondNumber)
        {
            return _calculator.Multiply(firstNumber, secondNumber);
        }

        [HttpGet]
        [Route("divide")]
        public double GetDivide(double firstNumber, double secondNumber)
        {
            return _calculator.Divide(firstNumber, secondNumber);
        }

    }
}