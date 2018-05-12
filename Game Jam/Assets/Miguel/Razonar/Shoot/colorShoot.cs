using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorShoot : MonoBehaviour {
    private Color colorStart = Color.red;
    private Color colorEnd = Color.green;
    public float duration = 1.0F;
    private Renderer rend;

    Material color; 

	private void Start () {
        rend = GetComponent<Renderer>();
        colorStart = randomColor();
        colorEnd = randomColor();
    }

    private void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }

    private Color randomColor()
    {
        Color color = Color.white;
        int num = Random.Range(0, 5);
        switch (num)
        {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.yellow;
                break;
            case 2:
                color = Color.blue;
                break;
            case 3:
                color = Color.green;
                break;
            case 4:
                color = Color.magenta;
                break;
            case 5:
                color = Color.cyan;
                break;
        }
        return color;
    }
}
