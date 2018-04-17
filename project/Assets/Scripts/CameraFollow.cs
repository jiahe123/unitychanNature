using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float distanceH = -4f;
    public float distanceV= 4f;
    public float smoothSpeed = 10f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void LateUpdate()
    {
        Vector3 nextpos = target.forward * -1 * distanceH + target.up * distanceV + target.position;

        this.transform.position = Vector3.Lerp(this.transform.position, nextpos, smoothSpeed * Time.deltaTime); 

        this.transform.LookAt(target);
    }
}
