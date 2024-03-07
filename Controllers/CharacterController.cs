using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using dotnet_Character.Models;
using System.Text.Json;

[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
  // 定義variable
  private static List<Character> CharacterList = new List<Character>{
    new Character {
        Id = 1,
        Name = "CharacterA"
    },
    new Character {
        Id = 2,
        Name = "CharacterB"
    },
    new Character {
        Id = 3,
        Name = "CharacterC"
    },
    new Character {
        Id = 4,
        Name = "CharacterD"
    }
  };

  // [Get]API: /character
  [HttpGet]
  public IActionResult Get() {
    var jsonData = JsonSerializer.Serialize(CharacterList);
    Console.WriteLine(jsonData);
    return Ok(CharacterList);
  }

  // [Get]API: /character/all
  [HttpGet("all")]
  public IActionResult GetAll() {
    // model data需要轉變成JSON, Console, API return 不用JsonSerializer.Serialize
    var jsonData = JsonSerializer.Serialize(CharacterList);
    Console.WriteLine(jsonData);
    return Ok(CharacterList);
  }

  // [Get]API: /character/name
  [HttpGet("{name}")]
  public IActionResult GetAll(string name) {
    var data = CharacterList.FirstOrDefault(item => item.Name == name);
    if (data == null) {
      return NotFound();
    }
    return Ok(data);
  }

  // [Post]API: /character
  [HttpPost]
  public ActionResult Add(Character newCharacter) {
    Console.WriteLine(newCharacter);
    CharacterList.Add(newCharacter);
    return Ok(CharacterList);
  }

  // [Delete]API: /character
  [HttpDelete]
  public ActionResult Delete(Character CharacterName) {
    var Character = CharacterList.FirstOrDefault(item => item.Name == CharacterName.Name);
    if(Character == null) {
      return NotFound();
    }
    CharacterList.Remove(Character);
    return Ok(CharacterList);
  }
}
