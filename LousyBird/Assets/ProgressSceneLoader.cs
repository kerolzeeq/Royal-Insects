using System;
using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressSceneLoader : MonoBehaviour
{
	[SerializeField]
	private Text progressText;
	[SerializeField]
	private Slider slider;

	private AsyncOperation operation;
	private Canvas canvas;
	public GameObject[] facts;

	System.Random random = new System.Random();
	int rand;

	private void Awake()
	{
		
		canvas = GetComponentInChildren<Canvas>(true);
		DontDestroyOnLoad(gameObject);
	}

	public void LoadScene(string sceneName)
	{
		UpdateProgressUI(0);
		canvas.gameObject.SetActive(true);
		rand = random.Next(0, 10);
		if(canvas.gameObject.activeInHierarchy == true)
        {
			facts[rand].SetActive(true);
        }
		StartCoroutine(BeginLoad(sceneName));
	}

	private IEnumerator BeginLoad(string sceneName)
	{
		operation = SceneManager.LoadSceneAsync(sceneName);

		while (!operation.isDone)
		{
			UpdateProgressUI(operation.progress);
			yield return null;
		}

		UpdateProgressUI(operation.progress);
		operation = null;
		for (int i = 0; i < facts.Length; i++)
		{
			facts[i].SetActive(false);
		}
		canvas.gameObject.SetActive(false);
	}

	private void UpdateProgressUI(float progress)
	{
		slider.value = progress;
		progressText.text = (int)(progress * 100f) + "%";
	}
}

