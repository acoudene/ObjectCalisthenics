namespace CompositionOverInheritance._BadExample.Day2_NewNeed;

public class Developer : TeamMemberBase
{
  public override void AssignTicket()
  {
    // Not allowed to assign tickets
    // Break I from SOLID
    throw new NotImplementedException();
  }

  public override void CreateTicket()
  {
    // Not allowed to create tickets
    // Break I from SOLID
    throw new NotImplementedException();
  }

  public override void Develop()
  {
    // Do work
  }

  public override void ProcessActivities()
  {
    Develop();
  }

  // Added! Break C principle of SOLID  
  public override void Test()
  {
    // Don't use to test ;)
    // Break I from SOLID
    throw new NotImplementedException();
  }
}
