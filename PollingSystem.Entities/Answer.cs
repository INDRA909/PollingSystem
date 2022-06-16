using PollingSystem.Entities.Base;

namespace PollingSystem.Entities;

public class Answer : Identity
{
    public Answer(Guid id, string title)
    {
        Id = id;
        Title=title;
    }
    public string Title { get; } 
    public int Votes { get; set; }
    public double Persents { get; set; }

    public void SetPersents(int totalVotes)
    {
        if (totalVotes > 0)
        {
            Persents = Votes * 100d / totalVotes;
        }
    }

    public override string ToString()
    {
        return $" {Title} - {Votes} ({Persents:F}%)";
    }
}