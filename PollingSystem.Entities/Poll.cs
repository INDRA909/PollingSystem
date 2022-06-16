﻿
using PollingSystem.Entities.Base;

namespace PollingSystem.Entities
{
    public class Poll : Identity
    {
        public Poll(string questionText,List<Answer> answers)
        {
            QuestionText=questionText;
            Answers=answers;
        }
        public string QuestionText { get; } 
        public List<Answer>? AnszZwers { get; }

        public void VoteTo(Guid id,int value=1)
        {
            var item = Answers?.SingleOrDefault(x => x.Id == id);
            if (item == null)
            {
              return;
            }
            item.Votes += value;
            var totalVotes = Answers?.Sum(x => x.Votes) ?? 0;
            Answers?.ForEach(x=>x.SetPersents(totalVotes));
        }
    }
}
