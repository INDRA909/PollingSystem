using PollingSystem.Entities.Base;
namespace PollingSystem.Entities;
public class Poll : Identity
{
    public Poll(string questionText, List<Answer> answers) : this(questionText)
    {
        Answers = answers;
    }
    private Poll(string questionText)
    {
        QuestionText = questionText;
    }
    public string QuestionText { get; init; }
    public List<Answer>? Answers { get; init; }

    /// <summary>
    /// Отдать value голосов за  ответ(id)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="value"></param>
    public void VoteTo(Guid id, int value = 1)
    {
        var item = Answers?.SingleOrDefault(x => x.Id == id);
        if (item == null)
        {
            return;
        }
        item.Votes += value;

        //Всего голосов по текущему варианту
        var totalVotes = Answers?.Sum(x => x.Votes) ?? 0; //Сумма голосов если !null,иначе 0;

        //Пересчёт процентов голосов для всех вариантов ответа
        Answers?.ForEach(x => x.SetPercents(totalVotes));

    }
}
