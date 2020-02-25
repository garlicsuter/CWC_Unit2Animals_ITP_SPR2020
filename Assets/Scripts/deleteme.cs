using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteme : MonoBehaviour
{
    public float speed = 10.0f;
    public int[] myInts = {5,0,9};
    // Start is called before the first frame update
    void Start()
    {
        speed -= 5.0f;
        Debug.Log(myInts[1]);
        //speed = speed -5
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 6.0f || speed == 5.0f)
        {
            Debug.Log("Hello");
        }
    }
}
