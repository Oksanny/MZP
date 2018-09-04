using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menus
{
    public class MetalEditGUI : BaseMenu
    {

        public GUIButton KarkasButton;
        public GUIButton FootsButton;
        public GUIButton PillowlButton;
        public void SetMaterial(string materialName)
        {
            Material setMaterial = Resources.Load<Material>(materialName);
            CommonData.CurrentPartGameObject.GetComponent<Renderer>().material = setMaterial;
        }
    }
}
