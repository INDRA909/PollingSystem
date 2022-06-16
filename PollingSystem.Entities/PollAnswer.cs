namespace PollingSystem.Entities;

public class PollAnswer
{
    public PollAnswer(int id, string title)
    {
        Id = id;
        Title=title;
    }

    public int Id { get; }

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
        return $"   {Title}({Votes} {Persents:F})";
    }
}