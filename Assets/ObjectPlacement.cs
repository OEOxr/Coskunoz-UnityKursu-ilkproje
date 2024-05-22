using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectPlacement : MonoBehaviour
{

    public GameObject targetobj;
    public TMP_Text TextArea;
    public string SuccessNote;


    //Bu dosya ders için oluşturulmuş örnek C dosyasıdır.

    public void OnTriggerEnter(Collider other)
    {
        if (targetobj == null || TextArea == null)
            return;
        else
            if(other.gameObject ==  targetobj)
        {
            //Debug.Log("Object is Placed");
            TextArea.text = "Tebrikler; "+ SuccessNote +" Yerinde.";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (targetobj == null || TextArea == null)
            return;
        else
            if (other.gameObject == targetobj)
        {
            //Debug.Log("Object is removed");
            TextArea.text = SuccessNote + " Yerinde Değil!";
        }
    }
}
