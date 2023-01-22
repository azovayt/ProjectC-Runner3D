using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _runSpeed;
    float _touchXDelta;
    float _newX = 0;
    public float _xSpeed;
    public float _limitX;
    void Start()
    {
        
    }

    void Update()
    {
        SwipeCheck();
    }

    private void SwipeCheck() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            _touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if (Input.GetMouseButton(0)) {
            _touchXDelta = Input.GetAxis("Mouse X");
        }
        else {
            _touchXDelta = 0;
        }
        _newX = transform.position.x + _xSpeed * _touchXDelta * Time.deltaTime;
        _newX = Mathf.Clamp(_newX, -_limitX, _limitX);

        Vector3 newPosition = new Vector3(_newX, transform.position.y, transform.position.z + _runSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
