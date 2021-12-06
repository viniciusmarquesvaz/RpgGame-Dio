namespace RpgGame_Dio.src.entities
{
  public class Wizzard : Hero
  {

    public Wizzard(string Name, int Level, string Herotype)
    {
      this.Name = Name;
      this.Level = Level;
      this.Herotype = Herotype;
    }
    public override string Attack()
    {
      return this.Name + " Atacou com a sua magia";
    }

  }
}