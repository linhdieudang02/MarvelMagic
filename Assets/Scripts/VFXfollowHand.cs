using UnityEngine;

public class VFXFollowHand : MonoBehaviour
{
    public Transform handTransform;  // The hand or bone you want to follow
    public Vector3 offset = Vector3.zero;  // Optional offset from hand center
    public float followSpeed = 10f;   // How quickly the effect follows the hand

    void Update()
    {
        if (handTransform != null)
        {
            // Smoothly move the VFX toward the hand + offset
            Vector3 targetPosition = handTransform.position + handTransform.TransformDirection(offset);
            transform.position = targetPosition;
        }
    }
}