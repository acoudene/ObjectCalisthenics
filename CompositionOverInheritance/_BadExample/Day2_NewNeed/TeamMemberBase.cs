namespace CompositionOverInheritance._BadExample.Day2_NewNeed;

public abstract class TeamMemberBase
{
    public abstract void CreateTicket();
    public abstract void AssignTicket();
    public abstract void Develop();

    public virtual void ProcessActivities()
    {
        CreateTicket();
        AssignTicket();
        Develop();
        // Added! Break C principle of SOLID  
        Test();
    }

    // Added! Break C principle of SOLID
    public abstract void Test();
}
