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

        //�U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        //�h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            //�c��hp�����炷
            this.hp -= damage;
        }

        //�}�W�b�N�p�̊֐�
        public void Magic(int mppower)
        {
            
                //�c��mp�����炷
                this.mp -= mppower;
                Debug.Log("���@�U���������B�c��MP�́Z�Z");
            if (this.mp < 5)
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }


        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //�v�f��5�̔z�������������
        int[] array = new int[5];

        //�z��̊e�v�f�ɒl��������
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        //�z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //�z��̗v�f�����ׂċt���ɕ\������
        for (int i = 4; i < 5; i--)
        {
            //�z��̔ԍ���0�����ɂȂ�����
            if (i < 0)
            {
                //�������I������
                break;
            }
            Debug.Log(array[i]);
        }

        //Boss�N���X�̕ϐ���錾�����C���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //�}�W�b�N�p�̊֐����Ăяo��
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
