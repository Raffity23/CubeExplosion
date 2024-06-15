using UnityEngine;

public class MaterialsStorage : MonoBehaviour
{
    [SerializeField] private Material[] _materials;

    public Material SetColor()
    {
        return new Material(_materials[Random.Range(0, _materials.Length)]);
    }
}
