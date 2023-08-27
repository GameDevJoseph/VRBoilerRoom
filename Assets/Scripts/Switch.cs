using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    Animator _anim;
    [SerializeField] string _boolName;
    bool _isOn = false;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void SetBool()
    {
        _anim.SetBool(_boolName, _isOn);
    }


    public void IsOn()
    {
        _isOn = !_isOn;
        SetBool();
    }
}
