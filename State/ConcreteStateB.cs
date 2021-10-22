namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class ConcreteStateB : State
    {
        public override void Handle(Player player)
        {
            player.State = new ConcreteStateA();
        }
    }
}
