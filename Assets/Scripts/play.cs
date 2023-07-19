using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{
	public Button playButton;
	public void OnPlayButtonClicked()
	{
		SceneManager.LoadScene("SampleScene");
	}
}
