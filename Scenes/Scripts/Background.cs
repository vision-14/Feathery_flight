using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer r;
    public float backgroundspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        r.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0);
    }
}
