using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ContextParticle : MonoBehaviour
{
    public Button button;
    public List<GameObject> ToChange = new List<GameObject>();
    public GameObject Gui;
    public GameObject input;
    public ContextMenu menu;
    private bool debounce = false;

    private void Awake()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        if (!debounce)
        {
            ///Aud.PlayOneShot();
            input.SetActive(true);
            ///Gui.SetActive(false);
            debounce = true;
        }
        else
        {
            foreach (GameObject help in ToChange)
            {
                help.transform.Find("Outline").gameObject.SetActive(false);
                help.GetComponent<TypeOfParticles>().type = input.GetComponent<TMP_InputField>().text;
            }
            ///Gui.SetActive(false);
            input.SetActive(false);
            ToChange.Clear();
            menu.Heck.Clear();
            menu.contdel.ToDelete.Clear();
            menu.converty.ToConvert.Clear();
            menu.collidy.ToMove.Clear();
            menu.contdel.ToDelete.Clear();
            menu.copy.ToCopy.Clear();
            menu.brighty.ToChange.Clear();
            menu.colory.ToChange.Clear();
            menu.layery.ToMove.Clear();
            menu.watery.ToChange.Clear();
            menu.ordery.ToDelete.Clear();
            menu.Previous.Clear();
            Gui.SetActive(false);
            debounce = false;
        }
    }
}
