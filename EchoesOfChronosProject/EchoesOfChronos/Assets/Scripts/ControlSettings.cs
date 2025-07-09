using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ControlSettings : MonoBehaviour
{
    public ScrollView ScrollView;
    public Scrollbar Scrollbarview;

    void Start()
    {
        Scrollbarview.value = 1f;
    }

    void Update()
    {
        
    }
}
