using ConsoleApp11.ChainOfResponsibility;
using ConsoleApp11.Iterator;
using ConsoleApp11.Mediator;


var myMainMediator = new MyMainMediator();

var colleague1 = new Colleague1(myMainMediator);
var colleague2 = new Colleague2(myMainMediator);

myMainMediator.Colleague1 = colleague1;
myMainMediator.Colleague2 = colleague2;

colleague1.Send("Привет");
colleague2.Send("Пока");