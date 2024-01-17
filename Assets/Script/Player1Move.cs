using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
	public float speed;
	Animator animator;
	//[SerializeField]
	public int jumpPower = 10;
	private Rigidbody2D rb;
	public bool isGrounded;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		speed = 5f;
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		int move;
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			animator.SetBool("isRunning", true);
			transform.localScale = new Vector2(7, 7);
			move = -1;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			animator.SetBool("isRunning", true);
			transform.localScale = new Vector2(-7, 7);
			move = 1;
		}
		else
		{
			animator.SetBool("isRunning", false);
			move = 0;
		}

		if(isGrounded && Input.GetKeyDown(KeyCode.Space)) {
			//C1
			//transform.Translate(Vector2.up * jumpPower);

			//rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
			rb.velocity = new Vector2(rb.velocity.x, jumpPower);
		}
		transform.Translate(Vector2.right * speed * Time.deltaTime * move);

	}

	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// Kiểm tra nếu người chơi chạm vào đất
		if (collision2D.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision2D)
	{
		// Kiểm tra nếu người chơi không còn chạm vào đất
		if (collision2D.gameObject.tag == "Ground")
		{
			isGrounded = false;
		}
	}
}
