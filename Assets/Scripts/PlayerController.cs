using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 6f;
    public TMP_Text hudText;
    public TMP_Text gameText;

    private Rigidbody rb;
    private int score = 0;
    private int totalCoins;
    private float timeLeft = 60f;
    private bool gameOver = false;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;

        gameText.text = "";
        UpdateHUD();
    }

    void Update()
    {
        if (gameOver == false)
        {
            timeLeft -= Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                gameOver = true;
                gameText.color = Color.red;
                gameText.text = "You Lose!";
            }

            if (transform.position.y < -5)
            {
                gameOver = true;
                gameText.color = Color.red;
                gameText.text = "You Lose!";
            }

            UpdateHUD();
        }
    }

    void FixedUpdate()
    {
        if (gameOver == true)
        {
            return;
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameOver == true)
        {
            return;
        }

        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score++;

            if (score >= totalCoins)
            {
                gameOver = true;
                gameText.color = Color.green;
                gameText.text = "You Win!";
            }

            UpdateHUD();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }
    }
    

    void UpdateHUD()
    {
        hudText.text = "Coins: " + score + " / " + totalCoins + " | Time: " + Mathf.Ceil(timeLeft);
    }
}