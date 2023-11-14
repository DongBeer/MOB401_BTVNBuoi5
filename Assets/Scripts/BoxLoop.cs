using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Box;
    public GameObject Zone_1;
    public GameObject Zone_2;

    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MOVE();
    }
    
    public void MAKE()
    {
        Zone_2 = Zone_1;
        int a = Random.Range(0,5);
        Zone_1 = Instantiate(Box[a], new Vector3(-13, -3, 0), transform.rotation) as GameObject;
    }
    
    public void MOVE()
    {
        Zone_1.transform.Translate(Vector3.left*speed*Time.deltaTime, Space.World);
        Zone_2.transform.Translate(Vector3.left*speed*Time.deltaTime, Space.World);
        if (Zone_1.transform.position.x <= -7)
        {
            DEATH();
        }
    }
    
    public void DEATH()
    {
        Destroy(Zone_2);
        MAKE();
    }
}
