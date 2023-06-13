using UnityEngine;

public class OffLimit : MonoBehaviour
{
    // Assuming you have a reference to the GrapplingHook script
    public GrapplingHook grapplingHook;

    private void Start()
    {
        SphereCollider sc = gameObject.GetComponent<SphereCollider>();
        if (sc == null)
        {
            sc = gameObject.AddComponent<SphereCollider>();
        }

        sc.isTrigger = true;
        sc.radius = grapplingHook.GetMaxDistance();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Garbage"))
        {
            Destroy(other.gameObject);
        }
    }
}