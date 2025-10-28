using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Vector2 movementDir = Vector2.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        
    }

    public void OnMove(InputValue inputValue){
        movementDir = inputValue.Get<Vector2>();
        Debug.Log(movementDir);
    }

    void FixedUpdate() {
        Vector2 move = new Vector2(movementDir.x, movementDir.y);
        transform.position += (Vector3)move * moveSpeed * Time.fixedDeltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
