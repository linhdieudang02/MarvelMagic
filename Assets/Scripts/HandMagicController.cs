using UnityEngine;
using UnityEngine.VFX;

public class HandMagicController : MonoBehaviour
{
    public OVRHand rightHand;
    public VisualEffect vfxIdle;
    public VisualEffect vfxCharged;

    private bool isCharged = false;

    void Start()
    {
        // Ensure idle effect is active at start
        if (vfxIdle != null) vfxIdle.gameObject.SetActive(true);
        if (vfxCharged != null) vfxCharged.gameObject.SetActive(false);
    }

    void Update()
    {
        if (rightHand == null) return;

        bool isPalmOpen = !rightHand.GetFingerIsPinching(OVRHand.HandFinger.Index)
                       && !rightHand.GetFingerIsPinching(OVRHand.HandFinger.Middle);

        bool isFist = rightHand.GetFingerPinchStrength(OVRHand.HandFinger.Index) > 0.9f &&
                      rightHand.GetFingerPinchStrength(OVRHand.HandFinger.Middle) > 0.9f;

        if (isPalmOpen && isCharged)
        {
            isCharged = false;
            SwitchToIdle();
            Debug.Log("Switched to Idle Effect");
        }

        if (isFist && !isCharged)
        {
            isCharged = true;
            SwitchToCharged();
            Debug.Log("Switched to Charged Effect");
        }
    }

    private void SwitchToIdle()
    {
        if (vfxIdle != null && vfxCharged != null)
        {
            vfxIdle.gameObject.SetActive(true);
            vfxCharged.gameObject.SetActive(false);
        }
    }

    private void SwitchToCharged()
    {
        if (vfxIdle != null && vfxCharged != null)
        {
            vfxIdle.gameObject.SetActive(false);
            vfxCharged.gameObject.SetActive(true);
        }
    }
}