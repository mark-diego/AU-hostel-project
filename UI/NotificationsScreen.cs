using System;
using UnityEngine;
using UnityEngine.UI;

public class NotificationsScreen : MonoBehaviour
{
    public GameObject notificationPrefab;
    public Transform notificationContainer;

    // Sample notification data
    private string[] notifications = {
        "Your booking has been confirmed.",
        "You have a new message from the admin.",
        "Reminder: Check-out is at 10 AM."
    };

    void Start()
    {
        DisplayNotifications();
    }

    void DisplayNotifications()
    {
        foreach (var message in notifications)
        {
            GameObject notification = Instantiate(notificationPrefab, notificationContainer);
            notification.GetComponent<Text>().text = message;
        }
    }
}