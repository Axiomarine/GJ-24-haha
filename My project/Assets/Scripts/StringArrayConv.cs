using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringArrayConv : MonoBehaviour
{
    // Method to convert string to array of characters
    public char[] ConvertStringToArray(string inputString)
    {
        // Check if input string is not null or empty
        if (!string.IsNullOrEmpty(inputString))
        {
            // Convert string to char array
            char[] charArray = inputString.ToCharArray();
            return charArray;
        }
        else
        {
            Debug.LogError("Input string is null or empty!");
            return null;
        }
    }
}
