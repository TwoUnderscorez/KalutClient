using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalutClient.Objects
{
    class KalutQuiz
    {
        public KalutQuiz()
        { }
        public KalutQuiz(KalutInfo Info, List<KalutQuestion> Questions)
        {
            this.Info = Info;
            this.Questions = Questions;
        }
        public KalutInfo Info { get; set; }
        public List<KalutQuestion> Questions { get; set; }
    }
}
