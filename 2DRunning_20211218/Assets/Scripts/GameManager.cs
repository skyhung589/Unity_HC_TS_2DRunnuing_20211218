
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    [Header("���")]
    public Image imghp;
    [Header("�ɶ�")]
    public Text textTime;
    [Header("����")]
    public Text textScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;
    [Header("�D�����")]
    public string tagProp = "�D��";
    [Header("��������")]
    public string tagTrop = "����";
    [Header("�Y��ɥ]�D���_��q"), Range(0, 50)]
    public float valueEatToaddhp = 10;
    [Header("�����e��")]
    public CanvasGroup groupFinal;
    [Header("�����e�����D")]
    public Text textFinalTitle;
    [Header("�����e��")]
    public float showFinalInterval = 0.1f;
    [Header("���`�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("�L���ϰ�W��")]
    public string namePass = "�L��";


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
        textTime.text = "�ɶ�" + Time.timeSinceLevelLoad.ToString("F2");

    }
    private void AddScoreAndUpdateUI(int add)
    {
        Score += add;
        textScore.text = "����" + Score;
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
        if (hp == 0&&  groupFinal.alpha ==0) //�p�G ��q ����0 �z���� ����0
        {
            textFinalTitle.text = "�D�ԥ���";
            groupFinal.interactable = true;
            ani.SetTrigger(parameterDead);
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }
    private void    win()
    {
        textFinalTitle.text = "�D�Ԧ��\";
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

