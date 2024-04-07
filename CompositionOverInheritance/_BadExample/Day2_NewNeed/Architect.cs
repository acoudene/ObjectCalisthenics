namespace CompositionOverInheritance._BadExample.Day2_NewNeed;

public class Architect : TeamMemberBase
{
  public override void AssignTicket()
  {
    // Do work
  }

  public override void CreateTicket()
  {
    // Do work
  }

  public override void Develop()
  {
    // Do work
  }

  // Added! Break C principle of SOLID  
  public override void Test()
  {
    // Don't use to test ;)
    // Break I from SOLID
    throw new NotImplementedException();
  }

  // Added! Break C principle of SOLID  
  public override void ProcessActivities()
  {
    CreateTicket();
    AssignTicket();
    Develop();
  }
}
