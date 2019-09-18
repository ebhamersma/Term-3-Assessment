using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public int health;
    public float speed;
    public int startingHealth = 1;
    public int currentHealth;

    public GameObject bullet;
    private GameObject player;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (GameObject.FindWithTag("Player") != null) player = GameObject.FindWithTag("Player");
        else player = gameObject;
        startingHealth = currentHealth;
        StartCoroutine("EnemyBulletCycle");
    }

    void FixedUpdate()
    {
        //finds the position of this enemy relative to the player
        Vector2 playerDirection = new Vector2
            (
            player.transform.position.x - transform.position.x,
            player.transform.position.y - transform.position.y
            );
        //rotates the enemy towards the player, using the Vector2 made in the previous step
        transform.up = playerDirection;
        //moves the enemy in the direction it is facing
        transform.position += transform.up * speed;

        //states that if the enemy health is equal or below 0 it destroys/deletes itself
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    //When the enemy collides with a player bullet it takes away one health
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            currentHealth -= 1;
        }
        if (collision.GetComponent<Bullet>() != null)
        {
            if (collision.GetComponent<Bullet>().bulletType == "player")
            {
                currentHealth -= 1;
                FindObjectOfType<Score>().scoreAmount += 1;
            }
        }
    }

    //This states that enemy fire routine, the enemy will fire at random times and wait 2-4secs before firing at the player again.
    IEnumerator EnemyBulletCycle()
    {
        while (true)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            yield return new WaitForSeconds(Random.Range(1f, 3f));
        }

    }

}