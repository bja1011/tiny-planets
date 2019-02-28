using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotate : MonoBehaviour
{
	Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(0f,0.1f),Random.Range(0f,0.1f),Random.Range(0f,0.1f));
    }

    // Update is called once per frame
    void Update()
    {

    	transform.Rotate(direction.x,direction.y,direction.z);
    	// Nice shake
      //   Vector3 euler = transform.eulerAngles;
     	// euler.x = Random.Range(1f, 3f);
     	// euler.y = Random.Range(1f, 3f);
     	// euler.z = Random.Range(1f, 3f);
     	// transform.eulerAngles = euler;
    }
}
