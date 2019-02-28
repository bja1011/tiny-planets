using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepOffset : MonoBehaviour
{
    public GameObject offsetTarget;
    private Vector3 offsetValue;
    // Start is called before the first frame update
    void Start()
    {
        offsetValue = offsetTarget.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offsetTarget.transform.position - offsetValue;
    }
}
