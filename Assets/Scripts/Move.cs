using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public WheelCollider FrontLeftWheel, FrontRightWheel, RearLeftWheel, RearRightWheel;
    public float motorspeed,rotationalspeed;
    void Update()
    { RearRightWheel.motorTorque = motorspeed * Input.GetAxis("Vertical");
      RearLeftWheel.motorTorque = motorspeed * Input.GetAxis("Vertical");
      FrontLeftWheel.steerAngle = rotationalspeed * Input.GetAxis("Horizontal");
      FrontRightWheel.steerAngle = rotationalspeed * Input.GetAxis("Horizontal");
    }
}
