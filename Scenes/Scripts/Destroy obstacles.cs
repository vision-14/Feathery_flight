
using Unity.VisualScripting;
using UnityEngine;

public class Destroyobstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BORDER"))
        { Destroy(this.gameObject); }
    }

    // Update is called once per frame
}