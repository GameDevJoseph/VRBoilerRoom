using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Clues : MonoBehaviour
{

    [SerializeField] GameObject _clueCanvas;
   
    [SerializeField] XRSocketInteractor _snapSocket;

    

    bool _isGrabbed = false;
    

    private void Start()
    {
        transform.position = _snapSocket.attachTransform.position;
    }

    public void IsGrabbed(bool value)
    {
        _isGrabbed = !value;
    }


    public void Update()
    {
        if(_isGrabbed)
            _clueCanvas.SetActive(true);
        else
            _clueCanvas.SetActive(false);
    }

    public void SnapBack()
    {
        _clueCanvas.SetActive(false);
        transform.position = _snapSocket.attachTransform.position;
    }

    

}
