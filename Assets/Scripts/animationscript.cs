using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationscript : MonoBehaviour
{
	private Animator animator;
	[SerializeField] private Button attackButton;
	[SerializeField] private Button defenceButton;

	void Start()
	{
		animator = GetComponent<Animator>();
	}

	public void PlayPunchAnimation()
	{
		animator.Play("playerpunch");
	}
	public void PlayDefenceAnimation()
	{
		animator.Play("playerdefence");
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			attackButton.onClick.Invoke();
			Debug.Log("Attack button: " + attackButton);

		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			defenceButton.onClick.Invoke();
		}

	}




}
