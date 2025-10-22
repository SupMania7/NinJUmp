using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{   public float speed =5f;
    private bool grounded = false;
    private Animator animator;
    private Animator Sword;
    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask enemyLayer;
    public logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Sword = GameObject.FindGameObjectWithTag("sword").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;

        
        if (Input.GetKeyDown(KeyCode.W) && grounded)
                GetComponent<Rigidbody2D>().velocity = Vector3.up *15f;
        if (Input.GetKeyDown(KeyCode.S) && !grounded)
            GetComponent<Rigidbody2D>().velocity = Vector3.down * 10f;
        if (grounded)
            animator.speed = 1f;
        else
            animator.speed = 0f;
        if (Input.GetKeyDown(KeyCode.F))
            {
            attack();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.CompareTag("ground"))
               grounded=true ;
        if (collision.gameObject.CompareTag("enemy"))
            logic.gameOver();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            grounded = false;
    }
   
    void attack()
    {
        Sword.SetTrigger("attack");
       Collider2D[] hitEnemies= Physics2D.OverlapCircleAll(attackPoint.position, attackRange,enemyLayer);
    foreach(Collider2D  enemy  in hitEnemies)
        {
            Debug.Log("we hit " + enemy.name);
            enemy.GetComponent<bamboo>().die();
            
        }
    }
    private void OnDrawGizmosSelected()
    {   if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
