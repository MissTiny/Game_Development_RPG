using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelAll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public void OnClick()
    {
        Listener.resetCoursesList();
        canvas.SetActive(false);
    }
}
