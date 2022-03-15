using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{

    [System.Serializable]
    public class ChapterEndText
    {

        [TextArea]
        public string success;

        [TextArea]
        public string failure;

    }

    public static Player player;


    [Range(0,100)]
    public int socialPressure;
    [Range(0, 100)]
    public int freedom;

    public int currentLevel = 0;
    
    public ChapterEndText[] chapterEndTexts;

    public Slider pressureSlider, freedomSlider;

    private bool successOnLast;

    public GameObject nextLevelObject;
    public TextMeshProUGUI textField;

    public bool paused = false;

    public void Start()
    {

        if (player != null)
        {
            Destroy(gameObject);
            return;
        }

        player = this;

        DontDestroyOnLoad(gameObject);

    }

    public void NextLevel()
    {
        currentLevel++;

        if (currentLevel > 7)
            currentLevel = 0;

        nextLevelObject.SetActive(true);
        paused = true;
        UpdateText();

    }

    public void Succeed()
    {
        successOnLast = true;

        UpdateUI();
    }

    public void Failed()
    {

        successOnLast = false;
        freedom -= 20;
        socialPressure += 20;

        UpdateUI();
    }

    public void PassLevel()
    {

        nextLevelObject.SetActive(false);
        paused = false;
        SceneManager.LoadScene(currentLevel);


        if (currentLevel == 0)
            currentLevel++;

    }
    
    public void UpdateUI()
    {

        pressureSlider.value = socialPressure;
        freedomSlider.value = freedom;

    }

    public void UpdateText()
    {

        string text = successOnLast ? chapterEndTexts[currentLevel].success : chapterEndTexts[currentLevel].failure;

        textField.text = "";

        StartCoroutine(Utilities.Type(text, textField));

    }

}
