using UnityEngine;

public class LearnCondition : MonoBehaviour
{
    public bool hasKey = true;
    public string weapon;
    public enum Season
    {
        spring, summer, fall, winder
    }
    public Season season;
    public void Start()

    {
        #region if�P�_��


        if (true)
        {
            print("�ڬO�P�_��if");
        }
        if (hasKey)
        {
            print("�}��");
        }
        else
        {
            print("����}��");
        }
        #endregion
        #region switch�P�_��


        switch (weapon)
        {
            case "�M�l":
                print("�����O30");
                break;
            default:
                print("�o���O�Z��");
                break;

        }
        #endregion
        switch (season)
        {
            case Season.spring:
                print("�K��");
                break;
            case Season.summer:
                print("�L��");
                break;
            case Season.fall:
                print("��Ѥ�");
                break;
            case Season.winder:
                print("�V��");
                break;
        }
    }
}
