using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 30f;
    [SerializeField] private float _resetOffset = 20f; // Offset for resetting the background

    private SpriteRenderer _spriteRenderer;
    private Vector2 _startSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = _spriteRenderer.size;
    }

    private void Update()
    {
        float newSizeX = _spriteRenderer.size.x + _speed * Time.deltaTime;

        // Check if the background has moved beyond the reset point
        if (newSizeX > _width + _resetOffset)
        {
            // Reset the background size
            _spriteRenderer.size = _startSize;
        }
        else
        {
            // Continuously increase the background size
            _spriteRenderer.size = new Vector2(newSizeX, _spriteRenderer.size.y);
        }
    }
}
