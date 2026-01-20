// UserInterfaceManager.cs

using System;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public void DisplayCaseDetails(string caseDetails)
    {
        // Logic to display case details on the screen
        Debug.Log(caseDetails);
    }

    public string GetUserInput(string prompt)
    {
        // Logic to get user input
        Debug.Log(prompt);
        return Console.ReadLine(); // This is for console applications; replace with actual UI input handling.
    }
}