using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {

    public float WaitForMoveTime = 5;
    public int MovementSpeed = 5;

    private bool _waitForMove = false;
    private Rigidbody _rigidbody;
	
	// Update is called once per frame
	void Update () {
        if(_waitForMove)
        {
            WaitForMoveTime -= Time.deltaTime;
            if (WaitForMoveTime <= 0)
                _waitForMove = false;
            return;
        }

        _rigidbody.velocity = _rigidbody.velocity.normalized * MovementSpeed;
    }

    /// <summary>
    /// Initialize the object
    /// </summary>
    private void OnEnable()
    {
        // Initialize fields
        _rigidbody = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

        _rigidbody.velocity = transform.forward * MovementSpeed;
    }
}
