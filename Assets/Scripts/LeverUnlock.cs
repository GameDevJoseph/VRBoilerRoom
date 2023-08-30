using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;
public class LeverUnlock : MonoBehaviour
{
    [SerializeField] int[] _lockCode = new int[6] { 1, 0, 0, 1, 1, 0 };
    [SerializeField] int[] _enteredCode = { 0, 0, 0, 0, 0, 0 };

    [SerializeField] XRLever[] _interactors;
    [SerializeField] UnityEvent _onCheck;

    private void Start()
    {

    }

    public void TurnOnOffLever0(int value)
    {
        _enteredCode[0] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }
    public void TurnOnOffLever1(int value)
    {
        _enteredCode[1] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }
    public void TurnOnOffLever2(int value)
    {
        _enteredCode[2] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }
    public void TurnOnOffLever3(int value)
    {
        _enteredCode[3] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }
    public void TurnOnOffLever4(int value)
    {
        _enteredCode[4] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }
    public void TurnOnOffLever5(int value)
    {
        _enteredCode[5] = value;

        if (CheckCode())
            _onCheck.Invoke();
    }



    private bool CheckCode()
    {
        if (_enteredCode.Length == _lockCode.Length)
        {
            for (int i = 0; i < _enteredCode.Length; i++)
            {
                if (_enteredCode[i] != _lockCode[i])
                    return false;
            }
            return true;
        }
        else return false;
    }
}
