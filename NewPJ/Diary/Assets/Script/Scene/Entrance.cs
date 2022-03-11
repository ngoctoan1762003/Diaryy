using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    public string lastExitName;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (PlayerPrefs.GetString("LastExitName") == lastExitName)
        {
            PlayerManager.instance.transform.position = transform.position;
            Debug.Log("ok" + PlayerPrefs.GetString("LastExitName"));
        }
    }


}
