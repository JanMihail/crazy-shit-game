using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenuController : MonoBehaviour
{
    public PlayerSettings playerSettings;
    public TMPro.TextMeshProUGUI lengthText;
    public UnityEngine.UI.Slider lengthSlider;

    private void Start()
    {
        lengthSlider.SetValueWithoutNotify(playerSettings.Length);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SliderLengthOnChange(float value)
    {
        playerSettings.Length = Convert.ToInt32(value);
    }

    public void ApplicationQuit()
    {
        Debug.Log("Application.Quit()");
        Application.Quit();
    }

    private void Update()
    {
        lengthText.text = String.Format("{0}", playerSettings.Length);
    }
}
