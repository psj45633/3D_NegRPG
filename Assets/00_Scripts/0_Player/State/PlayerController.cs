using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Cinemachine;


public class PlayerController : MonoBehaviour
{
    public PlayerInput playerInput { get; private set; }
    public PlayerInput.PlayerActions playerActions { get; private set; }
    public Interaction interaction { get; private set; }

    public CinemachineBrain cinemachine;

    public bool canLook = true;

    public Action inven;

    public UIInventory inventory { get; private set; }

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerActions = playerInput.Player;
        if(interaction == null)
        {
            interaction = GetComponent<Interaction>();
        }
        if(inventory == null)
        {
            inventory = FindObjectOfType<UIInventory>();
        }
    }

    private void FixedUpdate()
    {
        
    }

    private void OnEnable()
    {
        playerInput.Enable();
        playerInput.Player.Interaction.started += interaction.OnInteractInput;
        playerInput.Player.Inventory.started += inventory.OnInventory;
    }

    private void OnDisable()
    {
        playerInput.Disable();
        playerInput.Player.Interaction.started -= interaction.OnInteractInput;
        playerInput.Player.Inventory.started -= inventory.OnInventory;
    }
}


