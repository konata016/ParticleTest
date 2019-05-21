using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSize : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    public float speed;
    public float sizMix = 10f;
    public float startTime = 50f;
    public float waitingTime = 50f;

    int count;

    Vector3 sizMin = new Vector3(0, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        //obj1.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
        //obj2.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
        //obj3.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        obj1.transform.localScale = new Vector3(
                obj1.transform.localScale.x - step, 0.1f,
                obj1.transform.localScale.z - step);

        Debug.Log(obj1.transform.localScale);

        if (count > startTime)
        {
            obj2.transform.localScale = new Vector3(
                obj2.transform.localScale.x - step, 0.1f,
                obj2.transform.localScale.z - step);
        }
        if (count > startTime + waitingTime)
        {
            obj3.transform.localScale = new Vector3(
                obj3.transform.localScale.x - step, 0.1f,
                obj3.transform.localScale.z - step);

        }
        if (count < startTime + waitingTime + 10f) count++;

        if (obj1.transform.localScale.x <= sizMin.x) obj1.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
        if (obj2.transform.localScale.x <= sizMin.x) obj2.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
        if (obj3.transform.localScale.x <= sizMin.x) obj3.transform.localScale = new Vector3(sizMix, 0.1f, sizMix);
    }
}
