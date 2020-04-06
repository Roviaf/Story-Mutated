using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baterypickup : MonoBehaviour
{
    [SerializeField] int restoreIntensity = 5;
    [SerializeField] int restoreAngle = 40;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLight>().RestoreLightIntensity(restoreIntensity);
            other.GetComponentInChildren<FlashLight>().RestoreLightAngle(restoreAngle);
            Destroy(gameObject);
        }

    }
}
