﻿using UnityEngine;
using UnityEngine.UI;

public class ShowStatisticsWindow : MonoBehaviour {

    public Window QueueStatisticsWindow;
    public Window MonitorStatisticsWindow;

    public void Show()
    {
        GameObject selected = SelectObject.SelectedObject;

        if (selected.GetComponent<Monitor>())
        {
            MonitorStatisticsWindow.Show();
        }
        else if (selected.GetComponent<Queue>())
        {
            QueueStatisticsWindow.Show();
        }
    }

    public void Enable()
    {
        GetComponent<Button>().interactable = SelectObject.SelectedObject != null && 
            (SelectObject.SelectedObject.GetComponent<Queue>() != null 
          || SelectObject.SelectedObject.GetComponent<Monitor>() != null ) ;
    }
}
