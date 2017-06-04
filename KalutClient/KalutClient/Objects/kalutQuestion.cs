using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalutClient.Objects
{
    public class KalutQuestion
    {
        public KalutQuestion()
        {

        }
        public KalutQuestion(string q)
        {
            Question = q;
            Answers = new List<KeyValuePair<string, bool>>();
            for (int i = 0; i < 4; i++)
                Answers.Add(new KeyValuePair<string, bool>("", false));
            Time = 60;
        }
        public int Time { get; set; }
        public string Question { get; set;}
        public List<KeyValuePair<string, bool>> Answers { get; set; }
        public string HTMLContent { get; set; }
        public override string ToString()
        {
            return Question;
        }
    }
}
