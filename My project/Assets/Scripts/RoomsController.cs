using UnityEngine;

public class RoomsController : MonoBehaviour
{
    public Sprite backgroundSprite;

    void Start()
    {

    }

    public void SetupBackground()
    {
        // Create a new GameObject to hold the background image
        GameObject backgroundObject = new GameObject("Background");

        // Add a SpriteRenderer component to the background GameObject
        SpriteRenderer spriteRenderer = backgroundObject.AddComponent<SpriteRenderer>();

        // Set the background sprite
        spriteRenderer.sprite = backgroundSprite;

        // Adjust the position and scale as needed
        backgroundObject.transform.position = Vector2.zero;
        backgroundObject.transform.localScale = Vector2.one * 10;
    }
}