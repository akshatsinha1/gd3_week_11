using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeTest : MonoBehaviour
{
    public Volume volume1;
    DepthOfField dof;
    ColorAdjustments ca;

    // Start is called before the first frame update
    void Start()
    {
        volume1.profile.TryGet(out dof);
        volume1.profile.TryGet(out ca);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            dof.focusDistance.value = Vector3.Distance(Camera.main.transform.position, hit.point);
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            ca.saturation.value = 100f;
        }

    }
}
