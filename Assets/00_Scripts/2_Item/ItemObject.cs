using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string GetInteratPrompt();
    public void OnInteract();

}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;
    

    public string GetInteratPrompt()
    {
        string str = $"{data.displayName}";
        return str;
    }

    public void OnInteract()
    {
        Player.player.itemData = data;
        Player.player.addItem?.Invoke();
        Destroy(gameObject);

    }
}
    
