using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bamboo : MonoBehaviour
{
    public float speed = 10f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -14)
            Destroy(gameObject);
    }
    public void die()
    {
        Debug.Log("Destroyed "+ this.name);
        animator.SetTrigger("cut");
        GetComponent<Collider2D>().enabled = false;
    }
}
