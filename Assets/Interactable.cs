
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 30f;

    private bool isFocus = false;
    Transform player;

    bool hasInteracted = false;


    public virtual void Interact()
    {
        //Interactions differentes en fonction de la classe.
        Debug.Log("Interacting with " + transform.name);
    }


    void Update()
    {
        if(isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= radius)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }


    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }
}
