using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float axisX, speed, jumpForce, fire;
    private Rigidbody2D rbody;
    private SpriteRenderer spriteRender;
    public int facingDirection, playerLife;
    public bool grounded, isDown, damageAnim;
    public GameObject shot, shotStart;
    public SoundManager soundMng;
    private Animator playerAnim;
    private float counter;
    public GameObject[] lifeHearts;

    void Start()
    {
        speed = 10;
        jumpForce = 200;
        counter = 0;
        playerLife = 3;
        isDown = false;
        damageAnim = false;
        rbody = GetComponent<Rigidbody2D>();
        spriteRender = this.GetComponent<SpriteRenderer>();
        playerAnim = this.GetComponent<Animator>();

        if (this.transform.position.x <= 0) { this.facingDirection = 1; }
        else { facingDirection = -1; spriteRender.flipX = true; }
    }

    void FixedUpdate()
    {
        axisX = Input.GetAxis("Horizontal");
        rbody.velocity = new Vector2(axisX * speed, transform.position.y);
        if (Input.GetKeyDown("w") && grounded && !damageAnim)
        {
            soundMng.PlayJump();
            rbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.SetBool("jumping", true);
        }

        if (Input.GetKeyDown("s") && grounded && !isDown && !damageAnim)
        {
            playerAnim.SetBool("down", true);
            isDown = true;
        }
        if (counter >= 1.5f && isDown && !damageAnim)
        {
            counter = 0;
            playerAnim.SetBool("down", false);
            isDown = false;
        }
        if(isDown)
        {
            counter += Time.deltaTime;
        }

        if(Input.GetKeyDown("mouse 0") && !damageAnim)
        {
            soundMng.PlayShot();
            Instantiate(shot, shotStart.transform.position, Quaternion.identity);
        }

        if (damageAnim)
        {
            counter += Time.deltaTime;
            playerAnim.SetBool("damage", true);
        }
        if (counter >= 1 && damageAnim)
        {
            playerAnim.SetBool("damage", false);
            counter = 0;
            damageAnim = false;
        }

        /*if (axisX > 0) { this.facingDirection = 1; spriteRender.flipX = false; }
        else if (axisX < 0) { this.facingDirection = -1; spriteRender.flipX = true; }*/
    }

    void Update()
    {
        if(playerLife == 3)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(true);
            lifeHearts[2].SetActive(true);
        }
        else if(playerLife == 2)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(true);
            lifeHearts[2].SetActive(false);
        }
        else if (playerLife == 1)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(false);
            lifeHearts[2].SetActive(false);
        }
    }
}
