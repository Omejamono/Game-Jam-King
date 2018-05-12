using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    //public variables
    public int dificultad;
    public bool can_inf;
    public bool can_sup;

    //private variables
    private Vector3 aux;
    private Vector3 move;
    private float vel;
    // Use this for initialization
    void Start () {
        aux = new Vector3(0.0f, transform.position.y, 0.0f);
        can_inf = true;
        can_sup = true;
        if (dificultad == 1)
        {
            vel = 0.2f;
        }
        if (dificultad == 2)
        {
            vel = 0.3f;
        }
        if (dificultad == 3)
        {
            vel = 0.4f;
        }
    }

    // Update is called once per frame
    void Update()
    {
           float moveVertical = Input.GetAxis("Vertical");
           //if ((aux.y + moveVertical * vel) < 2 && (aux.y + moveVertical * vel) > -5)
           //{
           //aux.y += moveVertical * vel;
           //}
           if (((can_inf) || (moveVertical > 0)) && ((can_sup) || (moveVertical < 0)))
           {
                aux.y += moveVertical * vel;
                transform.position = new Vector3(transform.position.x, aux.y, transform.position.z);
                can_inf = true;
                can_sup = true;
           }
        
    }


}
