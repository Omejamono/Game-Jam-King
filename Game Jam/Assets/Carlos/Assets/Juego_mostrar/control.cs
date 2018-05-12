using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    //public variables
    public GameObject[] max;
    public GameObject[] min;
    public GameObject[] middle;
    public int pos;


    //private variables
    private Vector3 aux;
    private Vector3 move;
    // Use this for initialization
    void Start () {
        aux = new Vector3(0.0f, 0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {

            if (pos >= max.Length)
            {
                pos = 0;
            }
            float moveVertical = Input.GetAxis("Vertical");
            if ((aux.y + moveVertical * 0.3f) < 2 && (aux.y + moveVertical * 0.3f) > -5)
            {
                aux.y += moveVertical * 0.3f;
            }
            if (((transform.position.y > -5) || (moveVertical > 0)) && ((transform.position.y < 2) || (moveVertical < 0)))
            {
                transform.position = new Vector3(transform.position.x, aux.y, transform.position.z);
            }
        
    }


}
