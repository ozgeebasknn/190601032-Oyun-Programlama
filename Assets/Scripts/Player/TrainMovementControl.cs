using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovementControl : MonoBehaviour
{
    public TrainMovement trainMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StartTrain"))
        {
            trainMovement.StartMovement();
        }

        if (other.CompareTag("StopTrain"))
        {
            trainMovement.StopMovement();
        }
    }
}
