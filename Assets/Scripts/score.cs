using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Animator animator;
	public int score = 0;
	public Text scoreText;
	public GameObject gameOverPanel;
	public Button retryButton;

	private void Start()
	{
		UpdateScoreText();
		gameOverPanel.SetActive(false);
		retryButton.gameObject.SetActive(false);
		retryButton.onClick.AddListener(Retry);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit(); 
		}

		animator.SetFloat("animSpeed", Random.Range(0.0f, 1.0f));

		if (score < 0)
		{
			Time.timeScale = 0f;
			gameOverPanel.SetActive(true);
			retryButton.gameObject.SetActive(true);

		}
	}

	public void OnAttackButtonClicked()
	{
		if (animator.GetCurrentAnimatorStateInfo(0).IsName("enemyp"))
		{
			score += 10;
		}
		else
		{
			score -= 10;
		}

		UpdateScoreText();
	}

	private void UpdateScoreText()
	{
		if (score < 0)
		{
			scoreText.text = "More Training";
		}
		else
		{
			scoreText.text = "Score: " + score.ToString();
		}
	}

	private void Retry()
	{
		Time.timeScale = 1f;
		NewGame();
	}

	private void NewGame()
	{
		
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);

		animator = GetComponent<Animator>();
		animator.SetFloat("animSpeed", Random.Range(0.0f, 1.0f));
		animator.Play("enemyp");
	}
}

