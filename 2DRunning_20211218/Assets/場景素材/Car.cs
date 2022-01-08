using UnityEngine; // 引用  unity 引擎空間    讓我們可以使用裡面的API(倉庫)
// 121321
//類別 類別名稱 (必須與檔案名稱一致 大小寫也是)
public class car : MonoBehaviour
{
    //此類別的內容

    #region 欄位  firld
    //欄位語法
    //資料類型  欄位語法 (指定 預設值)  結尾
    //四大常用資料類型
    //整數    int
    //浮點數   float 
    //字串    string
    //布林值   bool
    //修飾詞   
    //私人:不給外部存取 預設  不顯示 private
    //公開:允許外部存取 顯示 public
    public  int cc  =1000;
    public  float weight    =3.5f;  //f或F結尾
    public  string brand   = "bmw";  //要雙引號名稱("")
    public  bool window =true;  //ture  false   是與否這兩個結尾
    //unity 常用語法
    //預設顏色 Color
    //指定顏色  color.要得顏色
    //自訂義顏色 new Color
    public Color ColorA;
    public Color red = Color.red;
    public Color white = Color.white;
    public Color ColorB =new Color(0.8f, 1, 0.1f);
    public Color ColorC = new Color(0.6f, 0.4f, 0.5f);
    //向量  Vector 2~4
    public Vector2 vector2;
    public Vector2 V2right = Vector2.right;
    public Vector2 V2up = Vector2.up;
    public Vector2

       #endregion



}
//非汽車類別資料