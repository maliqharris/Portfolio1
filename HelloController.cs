using Microsoft.AspNetCore.Mvc;
namespace Firstweb.Controllers;

public class HelloController : Controller
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()        
    {            
    	return "This is my Index";        
    }  
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("greet/{name}")] 
    public string Greet(string name)
    {
        return $"Hello {name}";
    }
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("projects")] 
    public string Project()
    {
        return "These are my projects";
    }
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("contact")] 
    public string Contact ()
    {
        return "This is my Contact";
    }
}