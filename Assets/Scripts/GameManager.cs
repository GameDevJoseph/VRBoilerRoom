using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    [SerializeField] LocomotionSystem _locomotionSystem;
    [SerializeField] ActionBasedContinuousMoveProvider _dynamicMovement;
    [SerializeField] ContinuousTurnProviderBase _turnProvider;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void MovementDisabled()
    {
        _locomotionSystem.enabled = false;
        _dynamicMovement.enabled = false;
        _turnProvider.enabled = false;
    }
}
