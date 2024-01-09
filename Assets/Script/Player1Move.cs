using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed *Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
			transform.Translate(Vector3.right * speed * Time.deltaTime *-1);
        }
        else
        {
			transform.Translate(Vector3.right * speed * Time.deltaTime * 0);
		}
    }
}
