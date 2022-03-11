using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool isTouching = false;
    public string sceneToLoad;
    public string exitName;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTouching = false;
        }
    }

    private void Update()
    {
        if (isTouching)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(sceneToLoad);
                PlayerPrefs.SetString("LastExitName", exitName);
            }
        }
    }
}
