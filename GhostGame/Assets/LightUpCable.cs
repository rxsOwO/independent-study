using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUpCable : MonoBehaviour
{
    public LineRenderer line;

    public Color on;
    public Color off;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ColorOff() {
        line.endColor = off;
        line.startColor = off;
    }
    public void ColorOn() {
        line.endColor = on;
        line.startColor = on;
    }
}
