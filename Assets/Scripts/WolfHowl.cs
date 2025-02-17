using UnityEngine;
using System.Collections;

public class WolfHowl : MonoBehaviour
{
    private const float MinInterval = 2f;
    private const float MaxInterval = 10f;

    private float nextInterval;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextInterval)
        {
			AudioHandler.Instance.PlaySound(AudioHandler.Instance.ZombieSounds);
            nextInterval = Time.time + Random.Range(MinInterval, MaxInterval);
        }
    }
}
