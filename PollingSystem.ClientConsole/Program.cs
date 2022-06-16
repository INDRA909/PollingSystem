

using PollingSystem.Application;

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

using (var context = new ApplicationDbContext())
{
    context.Polls.Add(poll);
    context.SaveChanges();
}
using (var context = new ApplicationDbContext())
{
    foreach (var answer in context.Answers)
    {
        Console.WriteLine(answer.Title);
    }
}
var result = builder.GetResults(poll);
Console.WriteLine(result.GetView());

