using System;
using UnityEngine;

public class VectorThing : MonoBehaviour
{
    public Vector2 c;
    public Transform aTf, bTf;

    [Range(0f, 4f)]
    public float offset = 1f;
    
    private void OnDrawGizmos()
    {
        Vector2 point = transform.position;
        Vector2 dirToPt = point.normalized;
        Gizmos.color = Color.green;
        // Gizmos.DrawLine(Vector2.zero, dirToPt);
        
        Vector2 aVec = aTf.position;
        Vector2 bVec = bTf.position;
        Vector2 dir = (bVec - aVec).normalized;
        Gizmos.DrawLine(aVec, (dir + aVec)); // same as Gizmos.DrawLine(aVec, bVec);
        
        // Point Along Direction
        Gizmos.DrawSphere(aVec + dir * offset, .05f );
        
        Vector2 a = new Vector2(3f, 4f);
        c = a / a.magnitude; // normalization
    }
}
