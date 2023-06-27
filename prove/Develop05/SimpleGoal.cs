using System;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string description, int points)
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