using System;
using System.Text.Json;

namespace Develop05;

public class EternalQuest
{
    private List<Goal> goals;

    public EternalQuest()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return goals;
    }

    public Goal GetGoalAtIndex(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            return goals[index];
        }
        return null;
    }

    public void RecordEvent(Goal goal)
    {
        if (goal != null)
        {
            goal.RecordEvent();
        }
    }
}