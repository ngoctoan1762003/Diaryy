using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable()]
public class QuestGoal
{
    public int currentAmount;
    public int requiredAmount;
    public bool isReached()
    {
        return(currentAmount>=requiredAmount);
    }

    public void increaseAmount()
    {
        currentAmount++;
    }
}
