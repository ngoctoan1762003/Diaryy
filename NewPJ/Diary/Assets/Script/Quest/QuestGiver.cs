using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable()]
public class QuestGiver : MonoBehaviour
{
    public BoxCollider2D[] TaskCollision;
    public Quest quest;
    public Player player;

    public void Start()
    {
        for (int i = 0; i < TaskCollision.Length; i++)
        {
            TaskCollision[i].enabled = false;
        }
    }

    public void AcceptQuest()
    {
        if (quest != null)
        {
            player.quest = quest;
            EnableTaskCollision();
        }
    }
    
    public void EnableTaskCollision()
    {
        if(TaskCollision != null)
        {
            for (int i = 0; i < TaskCollision.Length; i++)
            {
                TaskCollision[i].enabled = true;
            }
        }
        
    }
}
