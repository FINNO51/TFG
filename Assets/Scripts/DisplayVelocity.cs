using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DisplayVelocity : MonoBehaviour
{

    private InputData _inputData;
    public float _leftSpeed = 0f;
    public float _rightSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_inputData._leftController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            _leftSpeed = leftVelocity.magnitude;
        }
        if(_inputData._rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            _rightSpeed = rightVelocity.magnitude;
        }
    }
}
