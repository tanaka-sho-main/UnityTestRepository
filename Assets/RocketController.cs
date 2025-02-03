using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RocketController : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キーボードの情報
        var current = Keyboard.current;
        // キーボード接続チェック
        if (current == null)
        {
            return;
        }

        if (current.leftArrowKey.isPressed && transform.position.x > -2)
        {
            transform.Translate(-0.01f, 0, 0);
        }
        if (current.rightArrowKey.isPressed && transform.position.x < 2)
        {
            transform.Translate(0.01f, 0, 0);
        }
        if (current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

    }
}
