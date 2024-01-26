using System;
using System.Collections;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class RadialTrigger : MonoBehaviour
{
    public Transform objectTf;
    [Range(0f, 4f)] public float radius = 1f;

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 objPos = objectTf.position;
        
        float distance = (objPos - origin).magnitude; // expensive
        float distSqr = (objPos - origin).SqrMagnitude(); // cheaper
        
        
        // float distanceV2 = Vector2.Distance(origin, objPos); // Another alternative
        print("Distance: " + distance);
        
        bool isInside = distSqr <= radius;
        Handles.color = isInside ? Color.green : Color.red;
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
        print(isInside ? "inside" : "outside");
    }
#endif
    public void Func() => print("hello");

    // Cheaper Check Distance Function
    // IEnumerator CheckDistanceCor()
    // {
    //     while (true)
    //     {
    //         yield return new WaitForSeconds(.4f);
    //         print("Checkledim");
    //         // Check Distance Logic goes here...
    //     }
    // }
}

