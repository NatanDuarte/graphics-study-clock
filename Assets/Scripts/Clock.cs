using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f,
        minutesToDegrees = -6f,
        secondsToDegrees = -6f;

    [SerializeField]
    private Transform hoursPivot, minutesPivot, secondsPivot;

    private void UpdatePivots()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion
            .Euler(0, 0, hoursToDegrees * (float) time.TotalHours);

        minutesPivot.localRotation = Quaternion
            .Euler(0, 0, minutesToDegrees * (float) time.TotalMinutes);

        secondsPivot.localRotation = Quaternion
            .Euler(0, 0, secondsToDegrees * (float) time.TotalSeconds);
    }

    void Update()
    {
        UpdatePivots();
    }
}
