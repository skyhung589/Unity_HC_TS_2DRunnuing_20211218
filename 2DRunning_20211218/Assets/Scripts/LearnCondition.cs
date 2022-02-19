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
        #region if判斷式


        if (true)
        {
            print("我是判斷式if");
        }
        if (hasKey)
        {
            print("開門");
        }
        else
        {
            print("不能開門");
        }
        #endregion
        #region switch判斷式


        switch (weapon)
        {
            case "刀子":
                print("攻擊力30");
                break;
            default:
                print("這不是武器");
                break;

        }
        #endregion
        switch (season)
        {
            case Season.spring:
                print("春天");
                break;
            case Season.summer:
                print("夏天");
                break;
            case Season.fall:
                print("秋天天");
                break;
            case Season.winder:
                print("冬天");
                break;
        }
    }
}
