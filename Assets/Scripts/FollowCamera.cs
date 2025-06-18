using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;        
    public Vector3 offset = new Vector3(0, 10, -6); 

    public float followSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        
        transform.LookAt(target);
    }
}
