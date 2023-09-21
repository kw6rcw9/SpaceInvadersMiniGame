using System;

namespace ScoreSystem
{
    public  static class Score
    {
        public static Action<int> ScoreChangeAction;
 
        public static int ScoreCount { get; private set; }

        public static void IncreaseScoreCount(int score)
        {
            ScoreCount += score;
            ScoreChangeAction?.Invoke(ScoreCount);

        }
  
    }
}
