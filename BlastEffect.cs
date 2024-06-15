using UnityEngine;

public class BlastEffect : MonoBehaviour
{
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    public void Explode(Cube[] cubes)
    {
        foreach (Cube cube in cubes)
        {
            cube.TryGetComponent<Rigidbody>(out Rigidbody cubeRigidbody);
            cubeRigidbody.AddExplosionForce(_explosionForce, gameObject.transform.position, _explosionRadius);
        }
    }
}