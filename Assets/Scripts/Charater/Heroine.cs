using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroine : MonoBehaviour, IInteractable
{
    public string GetInteractPrompt()
    {
        return string.Format("����ϱ� {0}" );
    }

    public void OnInteract()
    {
        //�ִϸ��̼� ����
    }
}
