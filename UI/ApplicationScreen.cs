using System;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationScreen : MonoBehaviour
{
    public InputField nameInput;
    public InputField emailInput;
    public Dropdown roomPreferenceDropdown;
    public Button submitButton;

    void Start()
    {
        // Set up the dropdown options
        roomPreferenceDropdown.ClearOptions();
        roomPreferenceDropdown.AddOptions(new List<string> { "Single Room", "Shared Room", "Deluxe Room" });
        submitButton.onClick.AddListener(OnSubmit);
    }

    void OnSubmit()
    {
        string name = nameInput.text;
        string email = emailInput.text;
        string roomPreference = roomPreferenceDropdown.options[roomPreferenceDropdown.value].text;

        // Logic for submitting the application goes here
        Debug.Log("Application submitted for: " + name + " with email: " + email + " and room preference: " + roomPreference);
    }
}