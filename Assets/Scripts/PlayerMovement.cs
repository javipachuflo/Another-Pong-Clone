using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Transform t;
    private BoxCollider2D boxCollider2D;
    [SerializeField] float moveSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        t = transform;
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void OnMovement(InputValue inputValue)
    {
        if (inputValue.isPressed)
        {
            transform.position = new Vector2(transform.position.x, 0.5f);
        }
    }
}
