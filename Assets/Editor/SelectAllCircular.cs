using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SelectAllCircular : ScriptableWizard
{

    // public string searchTag = "Your tag here";

    public GameObject prefab;
    public float HajjNumber;
     GameObject parent;
    [MenuItem("My Tools/Select All Of Tag...")]
    static void SelectAllOfTagWizard()
    {
        ScriptableWizard.DisplayWizard<SelectAllCircular>("Create Hajj");
    }

    void OnWizardCreate()
    {
        parent = new GameObject();
        

        parent.name = "HajjGroup - " + HajjNumber;

        for (int x = 0; x < HajjNumber; x++)
        {
            GameObject HajjGo = Instantiate(prefab);
            HajjGo= PrefabUtility.ConnectGameObjectToPrefab(HajjGo, prefab);

            HajjGo.name = "Hajj-" + x;
            HajjGo.transform.parent = parent.transform;

            Circular circularComponent = HajjGo.GetComponent<Circular>();

            circularComponent.whidth = Random.Range(20, 45);
            circularComponent.hight = circularComponent.whidth;
            circularComponent.speed = Random.Range(0.1f, 0.15f);
            //circularComponent.isRandom = false;
        }
    }
   
}