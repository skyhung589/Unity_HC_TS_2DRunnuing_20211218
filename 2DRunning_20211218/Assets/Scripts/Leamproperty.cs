using UnityEngine;

public class Leamproperty : MonoBehaviour
{
    public int lv { get; set; }
    public string passwordField;
    public string passwordProperty { get => "777"; }

    private void Start()
    {
        lv = 100;
        print("等級:" + lv);
        passwordField = "1234567";
        print("取得欄位密碼" + passwordField);
        print("取得欄位密碼" + passwordProperty);
    }
}
