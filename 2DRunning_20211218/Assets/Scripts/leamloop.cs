
using UnityEngine;
/// <summary>
/// �j��
/// 1.While
/// 2.do while
/// 3.for
/// 4.foreach
/// </summary>
public class leamloop : MonoBehaviour



{
    //�j��@��
    //�B�z���_�{��
    public int[] scores = new int[20];
    private void Start()

    {
        #region �j�� whlie �Pfor
        print("���o");
        print("���o");
        print("���o");
        print("���o");
        print("���o");
        //while�j��y�k
        //�Pif�P�_�������ۦP
        //if(���L��){�{���϶�}
        //while(���L��){�{���϶�}

        //���L�Ȭ�Ture ����{}�@��
        if (true)
        {
            print("�P�_��if");

        }
        //���L�Ȭ�ture����i��{}
        /*
         * while(ture)
         * {
          print("�j��while");
        }
         */
        int count = 0;
        while (count < 5)
        {
            print("���o while");
            count++;
        }
        //for(��l��;���L��;�j�鵲���|���檺�{��
        for (int i = 0; i < 5; i++)
        {
            print("���o for");
        }
        //��X�Ʀr1~100
        for (int i = 0; i < 101; i++)
        {
            print("��X�Ʀr" + i);
        }
        #endregion


        //�j��P�}�C�B��

        for (int i =0;i<  scores.Length;i++)
        {
            scores[i] = 70 + i;
        }
    }
}



