using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menus
{
    public class FootsEditGUI : BaseMenu
    {

        public GUIButton KarkasButton;
        public GUIButton PillowButton;
        public GUIButton MetalButton;

        public void SetMaterial(string materialName)
        {
            Material setMaterial = Resources.Load<Material>(materialName);
            CommonData.CurrentPartGameObject.GetComponent<Renderer>().material = setMaterial;
        }
    }

}
