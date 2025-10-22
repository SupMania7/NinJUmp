using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject box;
    public GameObject longbox;
    public GameObject bamboo;
    private float spawnTimer=0f;
    private float spawnTime;
   

    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime = Random.Range(1, 4);
        float rand=Random.Range(0.25f,2f);
        spawnTimer += Time.deltaTime*rand;
        if (spawnTime < spawnTimer)
        {
            float r = Random.Range(0,20);
            if (r<7) 
            Instantiate(box, new Vector2(transform.position.x,- 2.92f), Quaternion.identity);
            else if(r>=7 && r<12)
                Instantiate(longbox, new Vector2(transform.position.x, -2.62f), Quaternion.identity);
            else 
                Instantiate(bamboo, new Vector2(transform.position.x, -1.66f), Quaternion.identity);
            spawnTimer = 0f;
        }
    }
}
