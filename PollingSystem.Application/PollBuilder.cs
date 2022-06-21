using PollingSystem.Entities;
namespace PollingSystem.Application;
public class PollBuilder
{
    private readonly string _questionText;

    private readonly  List<Answer> _items = new();

    public PollBuilder(string questionText)
    {
        _questionText = questionText;
    }
    /// <summary>
    /// Добавить вариант ответа в список
    /// </summary>
    /// <param name="id"></param>
    /// <param name="title"></param>
    /// <returns></returns>
    public PollBuilder AddAnswer(Guid id, string title)
    {
        _items.Add(new Answer(id, title));
        return this;
    }
    /// <summary>
    /// Возвращает опрос(Вопрос, список ответов)
    /// </summary>
    /// <returns></returns>
    public Poll Build()
    { 
        return new Poll(_questionText,_items);
    }
    /// <summary>
    /// Возвращает опрос в удобном формате для вывода
    /// </summary>
    /// <param name="poll"></param>
    /// <returns></returns>
    public PollResults GetResults(Poll poll) => new(poll);
}