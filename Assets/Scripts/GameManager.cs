using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���� ���÷���
    public TMP_Text displayText;

    // ��ư Ŭ�� �̺�Ʈ
    public void OnClickButton()
    {
        displayText.text += "1";
    }
}
