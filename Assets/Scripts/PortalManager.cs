using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public enum PortalType
    {
        OneWay,
        TwoWay
    }

    public PortalType portalType;

    public void ClosePortalAndOtherWorld()
    {
        // Disable the portal and all objects in the overworld
        gameObject.SetActive(false);

        GameObject[] otherWorldObjects = GameObject.FindGameObjectsWithTag("OtherWorldObject");
        foreach (GameObject otherWorldObject in otherWorldObjects)
        {
            otherWorldObject.SetActive(false);
        }

        TurnOffPassthrough();
    }

    private void TurnOffPassthrough()
    {
        OVRManager.instance.isInsightPassthroughEnabled = false;
    }
}