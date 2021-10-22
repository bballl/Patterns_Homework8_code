namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateA : State
    {
        public override void Handle(Player context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
