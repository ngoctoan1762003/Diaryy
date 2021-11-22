using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadQuest : MonoBehaviour, IQuestComplete
{
    public void Completed()
    {
        Destroy(gameObject.GetComponent<QuestGiver>());
        gameObject.GetComponent<TriggerDialouge>().sentences = new string[] {
            "Huh, don't bother me"
        };
    }
}
