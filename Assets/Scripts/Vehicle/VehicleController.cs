using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public GameObject CarInPlayer;
    public GameObject YachtInPlayer;
    public GameObject AircraftInPlayer;

    public GameObject CarInArea;
    public GameObject YachtInArea;
    public GameObject AircraftInArea;

    public GameObject carExitBtn;
    public GameObject YachtExitBtn;
    public GameObject AircraftExitBtn;

    public SkinnedMeshRenderer skinnedMeshRenderer;
    public Animator animCtrl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            CarInPlayer.SetActive(true);
            CarInArea.SetActive(false);
            carExitBtn.SetActive(true);

        }

        if (other.CompareTag("Yacht"))
        {
            YachtInPlayer.SetActive(true);
            YachtInArea.SetActive(false);
            YachtExitBtn.SetActive(true);
            animCtrl.enabled = false;

        }


        if (other.CompareTag("Aircraft"))
        {
            AircraftInPlayer.SetActive(true);
            AircraftInArea.SetActive(false);
            AircraftExitBtn.SetActive(true);
            skinnedMeshRenderer.enabled = false;
        }
    }

    public void ExitCar()
    {
        CarInPlayer.SetActive(false);
        CarInArea.SetActive(true);
        this.transform.position = new Vector3(this.transform.position.x - 3, this.transform.position.y, this.transform.position.z);
        carExitBtn.SetActive(false);

    }

    public void ExitYacth()
    {
        YachtInPlayer.SetActive(false);
        YachtInArea.SetActive(true);
        this.transform.position = new Vector3(-66, this.transform.position.y, 342);
        YachtExitBtn.SetActive(false);
        animCtrl.enabled = true;
    }

    public void ExitAircraft()
    {
        AircraftInPlayer.SetActive(false);
        AircraftInArea.SetActive(true);
        this.transform.position = new Vector3(-75, this.transform.position.y, 350);
        AircraftExitBtn.SetActive(false);
        skinnedMeshRenderer.enabled = true;
        animCtrl.enabled = true;
    }
}
