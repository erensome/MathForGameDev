using UnityEngine;

public class VectorThing : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Vector2 point = transform.position;
        Vector2 dirToPt = point.normalized;
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector2.zero, dirToPt);
    }
}
