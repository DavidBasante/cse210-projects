using System;
using System.Diagnostics;

namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int BonusPoints { get; set; }
        public int Progress { get; set; }

        public ChecklistGoal(string description, int points, int targetCount, int bonusPoints)
        {
            Description = description;
            Points = points;
            IsCompleted = false;
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            Progress = 0;
        }

        public override void RecordEvent()
        {
            Progress++;
            if (Progress >= TargetCount)
            {
                IsCompleted = true;
            }
        }
    }
}