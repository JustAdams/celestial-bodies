using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CelestialBody : MonoBehaviour
{
    public Rigidbody rb;
    public TrailRenderer trail;
    public Vector3 initialForce;

    private void Start()
    {
        rb.AddForce(initialForce);
    }

    public void ApplyGravitationalPull(CelestialBody otherBody)
    {
        float distance = Vector3.SqrMagnitude(transform.position - otherBody.transform.position);
        var force = UniversalConstants.gravity * (rb.mass * otherBody.rb.mass) / distance;

        rb.AddForce(force * transform.position);
    }
}
