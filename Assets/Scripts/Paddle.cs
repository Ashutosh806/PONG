using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed = 10.0f;

    private void Awake() 
    {
      rb = GetComponent<Rigidbody2D>();    
    }

    public void ResetPosition()
    {
      rb.position = new Vector2(rb.position.x,0.0f);
      rb.velocity = Vector3.zero;
    }
}
