using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractText : MonoBehaviour
{
    public Text interactText; 
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y + 1, player.transform.position.z);
    }

    public void ChangeText(string changeText)
    {
        interactText.text = changeText;
    }
}
