namespace Madlibs.Models
{
  public class LetterVariable
{
  private string _person;
  private string _personTwo;
  private string _animal;
  private string _verb;
  private string _noun;
  private string _expression;

  public string GetPerson()
  {
    return _person;
  }

  public void SetPerson(string newPerson)
  {
    _person = newPerson;
  }

  public string GetPersonTwo()
  {
    return _personTwo;
  }

  public void SetPersonTwo(string newPersonTwo)
  {
    _personTwo = newPersonTwo;
  }

  public string GetAnimal()
  {
    return _animal;
  }

  public void SetAnimal(string newAnimal)
  {
    _animal = newAnimal;
  }

  public string GetNoun()
  {
    return _noun;
  }

  public void SetNoun(string newNoun)
  {
    _noun = newNoun;
  }

  public string GetVerb()
  {
    return _verb;
  }

  public void SetVerb(string newVerb)
  {
    _verb = newVerb;
  }
  public string GetExpression()
  {
    return _expression;
  }

  public void SetExpression(string newExpression)
  {
    _expression = newExpression;
  }
 }
}
