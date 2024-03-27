namespace CompositionOverInheritance._BadExample.Day1;

public class Manager : TeamMemberBase
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
        // Don't develop
        // Break I from SOLID
    }

    public override void ProcessActivities()
    {
        AssignTicket();
        CreateTicket();
    }
}
