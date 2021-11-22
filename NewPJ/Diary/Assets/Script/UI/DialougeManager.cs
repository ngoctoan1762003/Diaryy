using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{
    public Text Name;
    public Text dialougeSentence;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        gameObject.SetActive(false);
    }

    public void StartDialouge(TriggerDialouge dialouge)
    {
        sentences.Clear();
        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }
        string sentence = sentences.Dequeue();
        dialougeSentence.text = sentence;
    }

    public void EndDialouge()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
