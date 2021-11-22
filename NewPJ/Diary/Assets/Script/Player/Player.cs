using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    public Rigidbody2D riGid;
    public float speed, horizontal, vertical;
    public Quest quest;

    // Start is called before the first frame update
    void Start()
    {
        riGid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        riGid.velocity = new Vector2 ( speed*horizontal, speed*vertical );
    }
}
