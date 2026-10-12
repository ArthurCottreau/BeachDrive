using UnityEngine;

public class DirectionTrigger : MonoBehaviour
{
    [System.NonSerialized] public LapManager parent;

    private void Start()
    {
        parent = GetComponentInParent<LapManager>();
    }

    public float GetCollisionDirection(Collider other)
    {
        CharacterController controller = other.gameObject.GetComponent<CharacterController>();
        return Vector3.Dot(transform.forward, controller.velocity);
    }
}
