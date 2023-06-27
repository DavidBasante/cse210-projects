using System;
namespace Develop05

{
    public class EternalGoal : Goal
    {
        public EternalGoal(string description, int points)
        {
            Description = description;
            Points = points;
            IsCompleted = false;
        }

        public override void RecordEvent()
        {
            IsCompleted = true;
        }
    }
}