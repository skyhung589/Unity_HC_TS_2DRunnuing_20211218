
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    [Header("血條")]
    public Image imghp;
    [Header("時間")]
    public Text textTime;
    [Header("分數")]
    public Text textScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;
    [Header("道具標籤")]
    public string tagProp = "道具";
    [Header("陷阱標籤")]
    public string tagTrop = "陷阱";
    [Header("吃到補包道具恢復血量"), Range(0, 50)]
    public float valueEatToaddhp = 10;
    [Header("結束畫面")]
    public CanvasGroup groupFinal;
    [Header("結束畫面標題")]
    public Text textFinalTitle;
    [Header("結束畫面")]
    public float showFinalInterval = 0.1f;
    [Header("死亡動畫參數")]
    public string parameterDead = "觸發死亡";
    [Header("過關區域名稱")]
    public string namePass = "過關";


    private int Score;
    private float hpMax;
    private Animator ani;
    private Player player;
    private void Start()
    {
        ani = GetComponent<Animator>();
        player = GetComponent<Player>();
        hpMax = hp;
    }


    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }
    private void Showfinal()
    {
        groupFinal.alpha += 0.2f;
    }
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imghp.fillAmount = hp / hpMax;
        Lose();
    }

    private void UpdateTimeUI()
    {
        textTime.text = "時間" + Time.timeSinceLevelLoad.ToString("F2");

    }
    private void AddScoreAndUpdateUI(int add)
    {
        Score += add;
        textScore.text = "分數" + Score;
    }
    private void ChangeHPAndupdataUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imghp.fillAmount = hp / hpMax;
        Lose();

    }
    private void Lose()
    {
        if (hp == 0&&  groupFinal.alpha ==0) //如果 血量 等於0 透明度 等於0
        {
            textFinalTitle.text = "挑戰失敗";
            groupFinal.interactable = true;
            ani.SetTrigger(parameterDead);
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }
    private void    win()
    {
        textFinalTitle.text = "挑戰成功";
        groupFinal.interactable = true;
        ani.SetTrigger(parameterDead);
        InvokeRepeating("ShowFinal", 0, showFinalInterval);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag==tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().Score);
            if (collision.name.Contains("apple_0")) ChangeHPAndupdataUI(10);
            Destroy(collision.gameObject);
        }
        if(collision.tag==tagTrop)
        {
            ChangeHPAndupdataUI(-collision.GetComponent<Trap>().damage);  
        }
        if(collision.name==namePass)
        {
            win();
        }
    }
}

