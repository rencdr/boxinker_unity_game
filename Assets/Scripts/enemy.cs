using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	public Animator animator;
	public float minWaitTime = 0f;
	public float maxWaitTime = 2f;

	private float timer;

	private void Start()
	{
		timer = Random.Range(minWaitTime, maxWaitTime);
	}

	private void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0f)
		{
			animator.Play("enemyp");

			timer = Random.Range(minWaitTime, maxWaitTime);
		}
	}
	
}
