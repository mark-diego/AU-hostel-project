using System;
using UnityEngine;
using UnityEngine.UI;

public class DashboardScreen : MonoBehaviour
{
    public Text appStatusText;
    public Text allocatedRoomText;

    void Start()
    {
        UpdateDashboard();
    }

    void UpdateDashboard()
    {
        // Example data for demonstration purposes
        string appStatus = "Application Status: Running";
        string allocatedRoom = "Allocated Room: Room 101";

        appStatusText.text = appStatus;
        allocatedRoomText.text = allocatedRoom;
    }
}