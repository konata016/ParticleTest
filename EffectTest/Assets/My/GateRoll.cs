using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRoll : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    public float speed;
    public float waitingTime = 50f;

    int count;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        count++;

        obj1.transform.Rotate(0, -speed, 0);

        if (count > waitingTime) obj2.transform.Rotate(0, speed, 0);
    }
}
