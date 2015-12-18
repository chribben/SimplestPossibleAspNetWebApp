using Microsoft.AspNet.Mvc;

[Route("api/[controller]")]
public class CodeController
{
  [HttpPost]
  public void Post(string code)
  {
  }
  [HttpGet]
  public string Get()
  {
    return "Hello world!";
  }
}