using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController: MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public float longitudRaaycast = 0.1f;
    public LayerMask groundLayer;

    public bool onFloor;
    private Rigidbody2D rb;

    public Animator animator;
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        // Handle player input and movement here
        float speedHorizontal = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;
        transform.position = new Vector3(position.x + speedHorizontal * speed * Time.deltaTime, position.y, position.z);
        RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.down,longitudRaaycast,groundLayer);
        onFloor = hit.collider != null;

        if (Input.GetKeyDown(KeyCode.Space) && onFloor) {
            rb.AddForce( new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitudRaaycast);
    }
}
