﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas impactCanvas;
    [SerializeField] float impactTime = 0.3f;


    private void Start()
    {
        impactCanvas.enabled = false;
    }

    public void DisplayCanvasDamage()
    {
        StartCoroutine(ShowDamage());
    }
    IEnumerator ShowDamage()
    {
        impactCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        impactCanvas.enabled = false;
    }
}
