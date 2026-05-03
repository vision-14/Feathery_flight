
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerspeed;
    private Vector2 playerdirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerdirection = new Vector2(0, directionY).normalized;

    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerdirection.y*playerspeed);
    }
}
