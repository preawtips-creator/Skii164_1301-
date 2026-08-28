using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;

    public static UIManager Instance;

    public static object instance { get; internal set; }

    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 88.5f, -86f);
        player.Hp = 100;

        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);
    }
    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }

}
