
using TMPro;
using UnityEngine;
/// <summary>
/// 學習列陣
/// </summary>
public class LearnArray : MonoBehaviour
{
    //列陣作用
    //儲存相同類型的多筆資料
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;
    //列陣語法
    //資造類型[]
    public int[] atks;
    //列陣初始值
    //1.指定陣列資料數量不指定值

    public float[] speeds = new float[5];
    //指定列陣資料區
    public string[] props = { "紅水", "藍水", "黃水" };
    public Vector3[] positions = { new Vector3(0, 1, 2), new Vector3(2, 2, 2) };
    public bool[] complete = { true, false, false, false };

    private void Start()
    {
        //存取陣列資料
        //1.存放陣列資料
        //陣列名稱[編號]=值
        //將陣列第一筆資料改為70
        atks[0] = 70;
        //2.使用陣列會遇到的錯誤,超車陣列範圍
        //IdexoutORange-編號不存在
        //atk[3]=99;

        //3.取得陣列資料
        //陣列名稱[編號]
        print("第二筆道具資料:" + props[1]);
        print("第二筆座標資料:" + positions[1]);

        //4.取得陣列數量  Lenghth
        print("布林值陣列數量" + complete.Length);

    }

}
