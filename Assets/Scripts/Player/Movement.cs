using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public VariableJoystick joystick;
    public Animator animatorController;

    public float PlayerSpeed = 5f;
    public float PlayerRotationSpeed = 10f;

    void Update()
    {
        Vector2 directionJoystick = joystick.Direction;
        Vector3 movementVector = new Vector3(directionJoystick.x, 0, directionJoystick.y);

        movementVector = movementVector * Time.deltaTime * PlayerSpeed;
        transform.position += movementVector;

        if (movementVector.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movementVector, Vector3.up), Time.deltaTime * PlayerRotationSpeed);
        }

        bool isWalking = directionJoystick.magnitude > 0;
        animatorController.SetBool("isWalking", isWalking);
        animatorController.SetFloat("AnimationSpeedValue", directionJoystick.magnitude);

    }
}
