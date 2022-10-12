using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action<string> SpeedMove;
    public static event Action<string> DistanseLife;
    public static event Action<string> SpeedRespawn;

    public static void OnUpdateSpeedMove(string speedValue)
    {
        SpeedMove?.Invoke(speedValue);
    }

    public static void OnUpdateDistanseLife(string distanceValue)
    {
        DistanseLife?.Invoke(distanceValue);
    }

    public static void OnUpdateSpeedRespawn(string speedValue)
    {
        SpeedRespawn?.Invoke(speedValue);
    }
}
