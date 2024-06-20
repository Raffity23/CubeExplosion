using UnityEngine;

public class BlastEffect : MonoBehaviour
{
    [SerializeField] private float _defaultExplosionRadius = 20f;
    [SerializeField] private float _defaultExplosionForce = 400f;
    
    public void Explode()
    {
        _defaultExplosionRadius = ChangeExplodeValue(_defaultExplosionRadius);
        _defaultExplosionForce = ChangeExplodeValue(_defaultExplosionForce);

        Collider[] objectsInRadius = Physics.OverlapSphere(transform.position, _defaultExplosionRadius);

        foreach (Collider objectInRadius in objectsInRadius)
        {
            if (objectInRadius.TryGetComponent<Rigidbody>(out Rigidbody cubeRigidbody))
                cubeRigidbody.AddExplosionForce(_defaultExplosionForce, 
                    gameObject.transform.position, _defaultExplosionRadius);
        }
    }

    private float ChangeExplodeValue(float value)
    {
        return value / transform.localScale.x;
    }
}
