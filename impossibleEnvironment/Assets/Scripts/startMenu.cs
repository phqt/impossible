using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class startMenu : MonoBehaviour
{
    public Canvas mainCanvas;
    public Canvas optionCanvas;
    public TextMeshProUGUI titleText;
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public Button startButton;
    public Button quitButton;
    public Button optionButton;
    public Button backButton;
    public Slider volumeSlider;
    public Slider brightnessSlider;


    void Start()
    {
        mainCanvas = GameObject.Find("MainCanvas").GetComponent<Canvas>();
        optionCanvas = GameObject.Find("OptionCanvas").GetComponent<Canvas>();
        titleText = GameObject.Find("TitleText").GetComponent<TextMeshProUGUI>();
        mainPanel = GameObject.Find("MainPanel");
        optionsPanel = GameObject.Find("OptionPanel");
        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        optionButton = GameObject.Find("OptionButton").GetComponent<Button>();
        backButton = GameObject.Find("BackButton").GetComponent<Button>();
        volumeSlider = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        brightnessSlider = GameObject.Find("BrightnessSlider").GetComponent<Slider>();

        
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(QuitGame);
        optionButton.onClick.AddListener(ShowOptions);
        backButton.onClick.AddListener(HideOptions);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Sample");
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void ShowOptions()
    {
        
        mainPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    void HideOptions()
    {
        optionsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
