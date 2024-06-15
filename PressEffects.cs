using UnityEngine;

public class PressEffects : MonoBehaviour
{
    [SerializeField] private Cube _cube;
    [SerializeField] private int _minNumberOfNewCubes;
    [SerializeField] private int _maxNumberOfNewCubes;
    [SerializeField] private BlastEffect _blastEffect;

    private void OnMouseDown()
    {
        if (Random.Range(0, _cube.SplitChancer) == 0)
            CreateNewCubes();

        Destroy(gameObject);
    }

    private void CreateNewCubes()
    {
        int numberOfNewCubes = Random.Range(_minNumberOfNewCubes, _maxNumberOfNewCubes);
        int splitChanceChangeValue = 2;
        int newSplitChancer = _cube.SplitChancer * splitChanceChangeValue;
        float resizingValue = 2f;
        Vector3 newSize = transform.localScale / resizingValue;
        Cube[] cubes = new Cube[numberOfNewCubes];

        for (int i = 0; i < numberOfNewCubes; i++)
        {
            cubes[i] = Instantiate(_cube, transform.position, Quaternion.identity);

            cubes[i].InitializeParameters(newSize, newSplitChancer);
        }

        _blastEffect.Explode(cubes);
    }
}
