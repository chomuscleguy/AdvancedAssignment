using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroine : MonoBehaviour, IInteractable
{
    public string GetInteractPrompt()
    {
        return string.Format("고백하기 {0}" );
    }

    public void OnInteract()
    {
        //애니메이션 실행
    }
}
