using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDialouge : MonoBehaviour
{
    public Text nameText;
    public GameObject Dialouge;
    public DialougeManager dialougeManager;
    public string Name;
    [TextArea(3,10)]
    public string[] sentences;
    public bool isTouching;

    private void Update()
    {
        if (isTouching == true)
        {
            Trigger();
        }
    }

    public void Trigger()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            nameText.text = Name;
            Time.timeScale = 0;
            Dialouge.SetActive(true);
            dialougeManager.StartDialouge(this);
            if (gameObject.GetComponent<QuestGiver>() != null)
            {
                gameObject.GetComponent<QuestGiver>().AcceptQuest();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            isTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isTouching = false;
    }
}
