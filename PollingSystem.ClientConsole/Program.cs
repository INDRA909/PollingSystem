

var builder = new PollBuilder("How are you?")
    .AddAnswer(Guid.NewGuid(), "Fine")
    .AddAnswer(Guid.NewGuid(), "not bad")
    .AddAnswer(Guid.NewGuid(), "Bad")
    .AddAnswer(Guid.NewGuid(), "Perfect")
    .AddAnswer(Guid.NewGuid(), "Bad bad");


var poll = builder.Build();

poll.VoteTo(1);
poll.VoteTo(2);
poll.VoteTo(3);
poll.VoteTo(2);
poll.VoteTo(3,50);

var result = builder.GetResults(poll);
Console.WriteLine(result.GetView());

