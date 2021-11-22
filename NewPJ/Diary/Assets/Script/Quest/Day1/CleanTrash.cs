using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanTrash : MonoBehaviour
{
    public bool isTouching;
    public QuestGiver questGiver;

    public void Update()
    {
        if (isTouching)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Ok");
                GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().quest.goal.increaseAmount();
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().quest.goal.isReached())
                {
                    questGiver.gameObject.GetComponent<IQuestComplete>().Completed();
                }
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTouching = true;
        }
    }
}
