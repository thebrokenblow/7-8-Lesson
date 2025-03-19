
namespace ConsoleApp11.Mediator;

public class Colleague1 : Colleague
{
    public Colleague1(MyMediator myMediator) : base(myMediator)
    {
    }

    public void Send(string message)
    {
        _mediator.Send(message, this);
    }

    public void Notify(string message)
    {

    }
}