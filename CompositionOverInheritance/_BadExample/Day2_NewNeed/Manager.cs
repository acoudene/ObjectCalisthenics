namespace CompositionOverInheritance._BadExample.Day2_NewNeed;

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
        // Wait for dev
        Test();
    }

    // Added! Break C principle of SOLID
    public override void Test()
    {
        // Do work
    }
}
