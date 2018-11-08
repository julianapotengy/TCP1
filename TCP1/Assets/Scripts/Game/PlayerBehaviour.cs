using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Atributos da movimentação do Player")]
    public float maxHeight;
    public float minHeight;
    public float speedY;
    public float speedX;
    public int life;

    [Header("Imagens da vida do Player")]
    public GameObject[] lifeHearts;

    private bool damageAnim;
    private Animator playerAnim;
    private float counter;

    [Header("Referências do tiro do Player")]
    public GameObject shot;
    public GameObject shotPos;

    [Header("Referência do GameManager")]
    public GameObject gameManager;

    void Start ()
    {
        playerAnim = this.GetComponent<Animator>();
    }
	
	void Update ()
    {
        float translationY = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        float translationX = Input.GetAxis("Horizontal") * speedX * Time.deltaTime;
        this.transform.Translate(translationX, translationY, 0);

        if(this.transform.position.y > maxHeight)
        {
            this.transform.position = new Vector2(transform.position.x, maxHeight);
        }
        else if (this.transform.position.y < minHeight)
        {
            this.transform.position = new Vector2(transform.position.x, minHeight);
        }

        if (Input.GetKeyDown("mouse 0") && !damageAnim)
        {
            gameManager.GetComponent<SoundManager>().PlayShot();
            Instantiate(shot, shotPos.transform.position, Quaternion.identity);
        }

        /*(this.transform.position.x > maxHeightX)
        {

        }*/

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

        CheckLife();
    }

    void CheckLife()
    {
        if (life == 3)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(true);
            lifeHearts[2].SetActive(true);
        }
        else if (life == 2)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(true);
            lifeHearts[2].SetActive(false);
        }
        else if (life == 1)
        {
            lifeHearts[0].SetActive(true);
            lifeHearts[1].SetActive(false);
            lifeHearts[2].SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag.Equals("Enemy") || col.tag.Equals("Rock"))
        {
            life -= 1;
            damageAnim = true;
        }
    }
}
