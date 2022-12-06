using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewManager : MonoBehaviour
{
    public GameObject buttonTemplate;
    public int numberOfButtonsToBeCreated = 10;

    // Start is called before the first frame update
    void Start()
    {
        InitialiseButtons();
    }

    public void InitialiseButtons()
    {
        Debug.Log("This has successfully started");
        int buttonCountTracker = 0;

        for(int i=0;i<numberOfButtonsToBeCreated - 1;i++)
        {
            Instantiate(buttonTemplate, transform);
            buttonCountTracker += 1;
            if(buttonCountTracker%6 == 0)
            {
                GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().rect.width, GetComponent<RectTransform>().rect.height + 300);
            }
        }
    }
}
