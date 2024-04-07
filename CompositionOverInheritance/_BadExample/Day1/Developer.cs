namespace CompositionOverInheritance._BadExample.Day1;

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
}
