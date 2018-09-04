using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menus
{
    public class KarkasEditGUI : BaseMenu
    {

        public GUIButton PillowButton;
        public GUIButton FootsButton;
        public GUIButton MetalButton;
        public void SetMaterial(string materialName)
        {
            Material setMaterial = Resources.Load<Material>(materialName);
            CommonData.CurrentPartGameObject.GetComponent<Renderer>().material = setMaterial;
        }
    }
}
