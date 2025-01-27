using System.Collections.Generic;
using UnityEngine;

public class AutoAssignMaterial : MonoBehaviour
{
    [Header("auto assign all children this material")]
    [SerializeField] public Material materialToAssign;

    // List to store all old materials and their corresponding GameObjects
    public readonly List<KeyValuePair<GameObject, Material>> oldMaterials = new List<KeyValuePair<GameObject, Material>>();

    private void Start()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            // Store the old material and corresponding GameObject in the list
            oldMaterials.Add(new KeyValuePair<GameObject, Material>(renderer.gameObject, renderer.material));

            // Assign the new material
            renderer.material = materialToAssign;
        }
    }
}