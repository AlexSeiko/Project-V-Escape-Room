using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EbuttonTypes
{
    Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8
}

public class ChestButtons : MonoBehaviour
{
    [field: SerializeField]public EbuttonTypes ButtonType{ get; set; }

    public bool IsPressed { get; set; }

    public void PressButton()
    {
        IsPressed = true;
    }

}
