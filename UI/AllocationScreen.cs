using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AllocationScreen : MonoBehaviour
{
    public GameObject applicantPrefab;
    public Transform applicantsContainer;
    private List<Applicant> applicants;
    
    void Start()
    {
        LoadApplicants();
        DisplayApplicants();
    }
    
    void LoadApplicants()
    {
        // Load applicants from data source
        applicants = new List<Applicant>(); // Assume this is populated from a database or other source
    }
    
    void DisplayApplicants()
    {
        foreach (var applicant in applicants)
        {
            var applicantObj = Instantiate(applicantPrefab, applicantsContainer);
            applicantObj.GetComponent<ApplicantUI>().Setup(applicant);
        }
    }
    
    public void AllocateRoom(Applicant applicant, Room room)
    {
        // Logic to allocate room to applicant
    }
    
    public void RefreshList()
    {
        // Refresh the list of applicants
        ClearApplicants();
        LoadApplicants();
        DisplayApplicants();
    }
    
    void ClearApplicants()
    {
        foreach (Transform child in applicantsContainer)
        {
            Destroy(child.gameObject);
        }
    }
}

[System.Serializable]
public class Applicant
{
    public string name;
    public string email;
    public string roomPreference;
    // Other applicant details
}

[System.Serializable]
public class Room
{
    public string roomNumber;
    public string roomType;
    // Other room details
}