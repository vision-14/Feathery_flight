
using UnityEngine;

public class Cameramov : MonoBehaviour
{ public float cameraspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraspeed * Time.deltaTime, 0,0);
        
    }
}
