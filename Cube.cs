using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private MaterialsStorage _materialsStorage;

    private int _splitChancer;

    public int SplitChancer => _splitChancer;

    private void Awake()
    {
        GetComponent<MeshRenderer>().material = _materialsStorage.SetColor();
        _splitChancer = 1;
    }

    public void InitializeParameters(Vector3 scale, int splitChancer)
    {
        transform.localScale = scale;
        _splitChancer = splitChancer;
    }
}
