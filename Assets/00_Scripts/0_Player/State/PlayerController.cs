using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerInput playerInput { get; private set; }
    public PlayerInput.PlayerActions playerActions { get; private set; }
    public Interaction interaction { get; private set; }

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerActions = playerInput.Player;
        if(interaction == null)
        {
            interaction = GetComponent<Interaction>();
        }
    }

    private void OnEnable()
    {
        playerInput.Enable();
        playerInput.Player.Interaction.started += interaction.OnInteractInput;
    }

    private void OnDisable()
    {
        playerInput.Disable();
        playerInput.Player.Interaction.started -= interaction.OnInteractInput;
    }
}


