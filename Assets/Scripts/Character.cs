using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public float Speed;
	public float JumpForce;

	Rigidbody2D m_Body;
	PhotonView m_PhotonView;

	
	void Awake() 
	{
		//m_Animator = GetComponent<Animator>();
		m_Body = GetComponent<Rigidbody2D>();
		m_PhotonView = GetComponent<PhotonView>();
	}
	
	void Update() 
	{
	}
	
	void FixedUpdate()
	{
		if( m_PhotonView.isMine == false )
		{
			return;
		}
		
		UpdateMovement();
	}

	void UpdateMovement()
	{
		Vector2 movementVelocity = m_Body.velocity;
		
		if( Input.GetAxisRaw( "Horizontal" ) > 0.5f )
		{
			movementVelocity.x = Speed;
			
		}
		else if( Input.GetAxisRaw( "Horizontal" ) < -0.5f )
		{
			movementVelocity.x = -Speed;
		}
		else
		{
			movementVelocity.x = 0;
		}
		
		m_Body.velocity = movementVelocity;
	}

	public void ReceiveDamages(int atq){
		
	}

	void Vote(){
		#if UNITY_ANDROID 
		
		#endif
	}
	

}
