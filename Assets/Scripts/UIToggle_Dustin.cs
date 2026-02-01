using UnityEngine;

public class UIToggle_Dustin : MonoBehaviour
{
    public GameObject helpScreenUI;

    private bool isHelpScreenActive = false;

    void Start()
    {
        // Make sure menu starts hidden
        helpScreenUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleHelpScreen();
        }
    }

    void ToggleHelpScreen()
    {
        isHelpScreenActive = !isHelpScreenActive;
        helpScreenUI.SetActive(isHelpScreenActive);
        Time.timeScale = isHelpScreenActive ? 0f : 1f;
    }
}