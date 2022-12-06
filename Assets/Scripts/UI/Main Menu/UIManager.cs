using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject characterSelectionPanel;

    public void EnableCharacterSelectionPanel () 
    {
        Debug.Log("This is getting enabled");
        characterSelectionPanel.SetActive(true);
    }

    public void DisableCharacterSelectionPanel ()
    {
        Debug.Log("This is getting disabled");
        characterSelectionPanel.SetActive(false);
    }
}
