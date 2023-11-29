using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 계산기 디스플레이
    public TMP_Text displayText;

    // 버튼 클릭 이벤트
    public void OnClickButton()
    {
        displayText.text += "1";
    }
}
