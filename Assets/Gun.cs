using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera FPCamra;
    public float reange = 100f;

    public ParticleSystem MuzzleFlash;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            MuzzleFlashEffect();
        }
    }

    private void MuzzleFlashEffect()
    {
        MuzzleFlash.Play();
    }
    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(FPCamra.transform.position,FPCamra.transform.forward,out hit,reange))
        {
            Debug.Log("I hit this thing : " + hit.transform.name);
        }
        else
        {
            return;
        }
    }

}
