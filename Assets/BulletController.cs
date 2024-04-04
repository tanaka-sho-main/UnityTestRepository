using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;
    UIController canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<UIController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.02f, 0);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canvas.AddScore();
        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(effect, 1.0f);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
