using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorExit : MonoBehaviour
{
    bool _key1Off = false;
    bool _key2Off = false;

    public UnityEvent _onCheck;

    public void Key1Unlocked()
    {
        _key1Off = true;

        if (CheckLocks())
            _onCheck.Invoke();
    }

    public void Key2Unlocked()
    {
        _key2Off = true;

        if (CheckLocks())
            _onCheck.Invoke();
    }

    bool CheckLocks()
    {
        if (!_key1Off || !_key2Off)
        {
            return false;
           
        }
        else if(_key1Off && _key2Off)
            return true;

        return false;
    }



}
