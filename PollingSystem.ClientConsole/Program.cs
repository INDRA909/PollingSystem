
using PollingSystem.ClientConsole;

var builder = new PollBuilder("How are you?")
    .AddAnswer(1, "Fine")
    .AddAnswer(2, "not bad")
    .AddAnswer(3, "Bad")
    .AddAnswer(4, "Perfect");

var poll = builder.Build();

poll.VoteTo(1);
poll.VoteTo(2);
poll.VoteTo(3);
poll.VoteTo(2);
poll.VoteTo(3,50);

var result = builder.GetResults(poll);
Console.WriteLine(result.GetView());


//var poll = new Poll("How are you ?")
//{
//    Answers = new List<PollAnswer>
//    {
//        new(1,"Fine" ),
//        new(2,"not bad"),
//        new(3,"Bad"),
//        new(4,"Perfect")
//    }
//};
//poll.VoteTo(1);
//poll.VoteTo(2);
//poll.VoteTo(3);
//poll.VoteTo(2);
//poll.VoteTo(3,50);
//Console.WriteLine(poll);