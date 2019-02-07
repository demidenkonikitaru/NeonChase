using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlatformConfigs", menuName = "Configs/PlatformConfigs")]
public class PlatformConfigs : ScriptableObject
{

    public float movementSpeed;
    public float xMoveRestriction;
    public float distanceToTargetY;

}
