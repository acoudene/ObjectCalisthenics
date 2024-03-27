namespace CompositionOverInheritance._BadExample.Day1;

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

    // No override of ProcessActivity because Architect can do anything ;)

}
