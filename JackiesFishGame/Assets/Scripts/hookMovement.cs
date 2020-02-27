using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown("4th Axis))
		{
			this.transform.position = this.transform.position + new Vector3(-1, 0, 0);
		}
		else if(Input.GetKeyDown("joystick button 1"))
		{
			this.transform.position = this.transform.position + new Vector3(1, 0, 0);
		}
    }
}
