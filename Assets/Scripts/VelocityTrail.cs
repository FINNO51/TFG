using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VelocityTrail : MonoBehaviour
{

    private InputData _inputData;
    public float _leftSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
        GetComponent<TrailRenderer>().material.color = new Color(0.0f, 1.0f, 0.0f, 1.0f);


    }

    // Update is called once per frame
    void Update()
    {
        if(_inputData._leftController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            _leftSpeed = leftVelocity.magnitude;
        }

        if(_leftSpeed <= 0.5f)
        {
            GetComponent<TrailRenderer>().material.color = new Color(_leftSpeed*2.0f, 1.0f, 0.0f, 1.0f);
        }
        else
        {
            GetComponent<TrailRenderer>().material.color = new Color(1.0f, 2.0f - _leftSpeed*2.0f, 0.0f, 1.0f);
        }
    }
}
