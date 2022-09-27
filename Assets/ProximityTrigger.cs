using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProximityTrigger : MonoBehaviour
{
    public Transform target;

    public float distanceThreshold;

    public UnityEvent OnProximityTrigger;    

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(transform.position, target.position);

        if (currentDistance < distanceThreshold)
        {
            OnProximityTrigger.Invoke();
        }
    }

    private void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        if (rb != null)
            rb.useGravity = false;
    }
}


