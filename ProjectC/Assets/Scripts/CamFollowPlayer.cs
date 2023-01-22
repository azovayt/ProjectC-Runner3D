using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform _cameraTarget;
    public float _sSpeed;
    public Vector3 _dist;
    public Transform _lookTarget;

    private void LateUpdate() {
        Vector3 _dPos = _cameraTarget.position + _dist;
        Vector3 _sPos = Vector3.Lerp(transform.position, _dPos, _sSpeed * Time.deltaTime);
        transform.position = _sPos;
        transform.LookAt(_lookTarget.position);
    }
}
