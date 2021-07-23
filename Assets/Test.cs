using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{   

    public class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;

        //攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        //防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            //残りhpを減らす
            this.hp -= damage;
        }

        //マジック用の関数
        public void Magic(int mppower)
        {
            
                //残りmpを減らす
                this.mp -= mppower;
                Debug.Log("魔法攻撃をした。残りMPは〇〇");
            if (this.mp < 5)
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }


        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //要素数5の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        //配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素をすべて逆順に表示する
        for (int i = 4; i < 5; i--)
        {
            //配列の番号が0未満になったら
            if (i < 0)
            {
                //処理を終了する
                break;
            }
            Debug.Log(array[i]);
        }

        //Bossクラスの変数を宣言したインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //マジック用の関数を呼び出す
        for (int mp =53; mp >= 5; mp -=5)
        {
            lastboss.Magic(5);

            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
