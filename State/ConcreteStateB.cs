namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateB : State
    {
        public override void Handle(Player context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
