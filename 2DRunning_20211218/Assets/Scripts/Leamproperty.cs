using UnityEngine;

public class Leamproperty : MonoBehaviour
{
    public int lv { get; set; }
    public string passwordField;
    public string passwordProperty { get => "777"; }

    private void Start()
    {
        lv = 100;
        print("����:" + lv);
        passwordField = "1234567";
        print("���o���K�X" + passwordField);
        print("���o���K�X" + passwordProperty);
    }
}
