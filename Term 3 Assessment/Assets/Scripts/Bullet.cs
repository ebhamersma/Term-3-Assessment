using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string bulletType;
    public float speed;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.up * speed;
    }

    public void instantiateBullet (string type, float bSpeed, Quaternion rotation, Color color)
    {
        bulletType = type;
        speed = bSpeed;
        transform.rotation = rotation;
        this.gameObject.GetComponent<SpriteRenderer>().color = color;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayspaceTrigger") Destroy(gameObject);
        Debug.Log(collision.gameObject.name);
    }
}
