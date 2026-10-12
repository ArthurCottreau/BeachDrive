using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : DirectionTrigger
{
    [System.NonSerialized] public bool is_validated = false;

    private void OnTriggerExit(Collider other)
    {
        if (is_validated == true) { return; }
        if (other.gameObject.tag != "Player") { return; }

        // TODO: Use 'GetCollisionDirection' to show the player they're driving in the wrong direction

        parent.CheckCountAdd();
        is_validated = true;
    }
}
