using UnityEngine;
using UnityEngine.VFX;

public class HandMagicController : MonoBehaviour
{
    public OVRHand leftHand;
    public OVRHand rightHand;
    public VisualEffect photonEffect;

    private bool isCharging = false;

    void Update()
    {
        if (rightHand != null)
        {
            bool isPalmOpen = rightHand.GetFingerIsPinching(OVRHand.HandFinger.Index) == false
                            && rightHand.GetFingerIsPinching(OVRHand.HandFinger.Middle) == false;

            bool isFist = rightHand.GetFingerPinchStrength(OVRHand.HandFinger.Index) > 0.9f &&
                          rightHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle) > 0.9f;

            if (isPalmOpen && !isCharging)
            {
                isCharging = true;
                photonEffect.SetBool("IsCharging", true);
                Debug.Log("Charging Photon Energy...");
            }

            if (isFist && isCharging)
            {
                isCharging = false;
                photonEffect.SetBool("IsCharging", false);
                photonEffect.SendEvent("OnBlast");
                Debug.Log("Photon Blast Released!");
            }
        }
    }
}