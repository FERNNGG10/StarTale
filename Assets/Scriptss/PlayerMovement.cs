using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    private RectTransform playerRect;

    void Start()
    {
        playerRect = GetComponent<RectTransform>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 newPosition = playerRect.anchoredPosition;
        newPosition.x += moveX * moveSpeed;
        newPosition.y += moveY * moveSpeed;

        playerRect.anchoredPosition = newPosition;
    }
}