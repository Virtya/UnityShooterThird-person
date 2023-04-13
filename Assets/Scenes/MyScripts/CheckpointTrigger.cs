using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public string identifier;

    private bool _triggered;

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if (_triggered)
        {
            return;
        }

        ManagersWeatherAndImage.Weather.LogWeather(identifier);
        _triggered = true;
    }
}
