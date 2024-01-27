using UnityEngine;

public class RoomsController : MonoBehaviour
{
    // this script just renders the background you ask it to (very unoptimized, but who cares)
    public Sprite backgroundSprite;

    private GameObject backgroundObject;
    private SpriteRenderer spriteRenderer;

    public void SetupBackground()
    {
        // Create a new GameObject to hold the background image
        backgroundObject = new GameObject("Background");

        // Add a SpriteRenderer component to the background GameObject
        spriteRenderer = backgroundObject.AddComponent<SpriteRenderer>();

        // Set the background sprite
        spriteRenderer.sprite = backgroundSprite;

        // Adjust the position and scale as needed
        backgroundObject.transform.position = Vector2.zero;
        backgroundObject.transform.localScale = Vector2.one * 10;
    }

    // Method to toggle the visibility of the background
    public void ToggleBackground(bool isVisible)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = isVisible;
        }
    }
}
