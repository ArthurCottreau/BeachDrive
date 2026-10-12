using UnityEngine;

public class LapManager : MonoBehaviour
{
    private Checkpoint[] checkpoint_list;
    private int checkpoint_count;
    private int check_count = 0;
    private int lap_count = 0;

    private void Start()
    {
        checkpoint_list = GetComponentsInChildren<Checkpoint>();
        checkpoint_count = transform.childCount - 1; // Need to take into account the starting line
    }

    public void CheckCountAdd()
    {
        check_count += 1;
        Debug.Log(check_count + " out of " + checkpoint_count + " checkpoints finished !");
    }

    public void ValidateLap()
    {
        if (check_count >= checkpoint_count)
        {
            lap_count += 1;
        }  

        ResetCheckCount();
        Debug.Log(lap_count + " laps done !");
    }

    public void ResetCheckCount()
    {
        check_count = 0;
        foreach (var checkpoint in checkpoint_list)
        {
            checkpoint.is_validated = false;
        }
    }
}
