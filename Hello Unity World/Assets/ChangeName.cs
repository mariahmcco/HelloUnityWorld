using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeName : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI myText = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space"))
        {
            myText.SetText("Hello World from Mariah McCormick"); 
            Debug.Log ("Key Pressed");
        
        }
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
        
    }
}
