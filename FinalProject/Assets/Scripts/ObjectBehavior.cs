using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.WSA.Input;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var interactionSourceStates = InteractionManager.GetCurrentReading();
        foreach (var interactionSourceState in interactionSourceStates)
        {
            if (interactionSourceState.selectPressed)
            {
                //Debug.Log("hello");
            }
        }
       
    }

    void OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("focusing...");
    }

    void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        Debug.Log("pointer clicked");
    }
}
