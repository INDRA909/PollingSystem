using PollingSystem.Entities.Base;

namespace PollingSystem.Entities;

public class Answer : Identity
{
    public Answer(Guid id, string title)
    {
        Id = id;
        Title=title;
    }
    public string Title { get; init; } 
    public int Votes { get; set; }
    public double Percents { get; private set; }

    public void SetPercents(int totalVotes)
    {
        if (totalVotes > 0)
        {
            Percents = Votes * 100d / totalVotes;
        }
    }

    public override string ToString()
    {
        return $" {Title} - {Votes} ({Percents:F}%)";
    }
}