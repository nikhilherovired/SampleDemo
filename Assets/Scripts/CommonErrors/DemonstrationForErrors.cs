using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonstrationForErrors : MonoBehaviour
{
    public float speed;
    public GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        Function1();
        Function2();
        Function3();
    }

    void Function1()
    {
        transform.position = new Vector3(1,0,0);
    }

    void Function2()
    {
        transform.position = new Vector3(1,1,0);
    }
    void Function3()
    {
        transform.position = new Vector3(1,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed,0,0);
        ground.transform.position = transform.position;
    }
}
