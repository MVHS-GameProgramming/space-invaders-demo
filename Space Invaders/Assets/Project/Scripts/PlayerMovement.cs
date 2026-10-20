using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 30f;

    [SerializeField]
    private float _drag = 1.5f;

    [SerializeField]
    private float _LeftScreenPositionClamp = -2.4f;

    [SerializeField]
    private float _RightScreenPositionClamp = 2.4f;


    private Vector2 _Velocity;



    // Update is called once per frame
    void Update()
    {
        Vector2 playerInput = getPlayerInput();
        MovePlayer(playerInput);
        ClampPlayerPosition();
    }

    public Vector2 getPlayerInput()
    {
        Vector2 playerInput = Vector2.zero;
        if (Keyboard.current.aKey.isPressed)
        {
            playerInput.x -= 1f;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            playerInput.x += 1f;
        }

        return playerInput.normalized;
    }

    private void MovePlayer(Vector2 input)
    {
        _Velocity += input * _moveSpeed * Time.deltaTime;
        _Velocity -= _Velocity * _drag * Time.deltaTime;

        Vector2 moveDelta = _Velocity * Time.deltaTime;
        transform.Translate(moveDelta);
    }

    private void ClampPlayerPosition()
    {
        if (transform.position.x < _LeftScreenPositionClamp || transform.position.x > _RightScreenPositionClamp)
        {
            _Velocity = Vector2.zero;

            float xPosition = Mathf.Clamp(transform.position.x, _LeftScreenPositionClamp, _RightScreenPositionClamp);
            transform.position = new Vector2(xPosition, transform.position.y);
        }
    }
}
