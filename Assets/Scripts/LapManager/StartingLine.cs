using UnityEngine;

public class StartingLine : DirectionTrigger
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") { return; }

        float dir_coll = base.GetCollisionDirection(other);

        if (dir_coll >= 0)
        {
            parent.ValidateLap();
        }
        else
        {
            parent.ResetCheckCount();
        }
    }
}
