using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Hammer : ItemBase
{
   
    protected override void OnItemUsed(PlayerActionScript playerActionScript)
    {

        

        if(Camera.main.transform.rotation== Quaternion.Euler(90.0f, 0.0f, 0.0f))
        {
            Camera.main.transform.rotation = Quaternion.Euler(36.864f, 0.0f, 0.0f);
            Camera.main.transform.position = new Vector3(0, 9.09f, -12.52f);
        }
        else if (Camera.main.transform.rotation == Quaternion.Euler(36.864f, 0.0f, 0.0f))
        {
            Camera.main.transform.rotation = Quaternion.Euler(90.0f, 0.0f, 0.0f);
            Camera.main.transform.position = new Vector3(0, 17.5f, 0);
        }

    }
 

}

