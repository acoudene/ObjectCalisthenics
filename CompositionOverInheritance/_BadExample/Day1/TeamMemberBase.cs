namespace CompositionOverInheritance._BadExample.Day1;

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
    }
}
