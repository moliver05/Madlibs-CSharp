namespace Madlibs.Models
{
  public class LetterVariable
{
  private string _person;
  private string _personTwo;
  private string _animal;
  private string _verb;
  private string _noun;

  public string GetPerson()
  {
    return _person;
  }

  public void SetPerson()
  {
    _person = newPerson;
  }

  public string GetPersonTwo()
  {
    return _personTwo;
  }

  public void SetPerson()
  {
    _person = newPersonTwo;
  }

  public string GetAnimal()
  {
    return _animal;
  }

  public void SetAnimal()
  {
    _animal = newAnimal;
  }

  public string GetNoun()
  {
    return _noun;
  }

  public void SetNoun(string newNoun)
  {
    _nouns = newNoun;
  }

  public string GetVerb()
  {
    return _verb;
  }

  public void SetVerb(string newVerb)
  {
    _verb = newVerb;
  }
 }
}
