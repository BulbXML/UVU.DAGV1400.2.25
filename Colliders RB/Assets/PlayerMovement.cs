using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
    }
    
    private void MoveCharacter()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector *= (speed * Time.deltaTime);
        controller.Move(movementVector);
    }

    private void KeepCharacterOnXAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}