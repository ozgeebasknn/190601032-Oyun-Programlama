using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VagoonMovement : MonoBehaviour
{
    public TrainMovement trainMovement;
    public float offset = -0.035f;

    // Update is called once per frame
    void Update()
    {
        if (trainMovement == null)
            return;

        var timeTravelled = trainMovement.GetCurrentTimeTravelled() + offset;
        transform.position = trainMovement.pathCreator.path.GetPointAtTime(timeTravelled, trainMovement.endOfPathInstruction);
        transform.rotation = trainMovement.pathCreator.path.GetRotation(timeTravelled, trainMovement.endOfPathInstruction);

    }
}
