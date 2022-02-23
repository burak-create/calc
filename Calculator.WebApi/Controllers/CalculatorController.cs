using Calculator.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]

public abstract class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;
    private readonly ICalculator _calculator;

    public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
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
    [Route("div")]
    public double GetDiv(double firstNumber, double secondNumber)
    {
        return _calculator.Divide(firstNumber, secondNumber);
    }
    [HttpGet]
    [Route("multi")]
    public double GetMulti(double firstNumber, double secondNumber)
    {
        return _calculator.Multiply(firstNumber, secondNumber);
    }

}