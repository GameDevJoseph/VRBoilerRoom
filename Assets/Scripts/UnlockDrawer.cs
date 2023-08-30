using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDrawer : MonoBehaviour
{
    [SerializeField] ConfigurableJoint _joint;



    public void SetUnlockedJoint()
    {
        _joint.connectedAnchor = new Vector3(-7.05f, 0.7337375f, -1.40169f);
        SoftJointLimit softJointLimit = new SoftJointLimit();
        softJointLimit.limit = 0.15f;
        _joint.linearLimit = softJointLimit;
    }
}
