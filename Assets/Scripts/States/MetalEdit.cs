using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace States
{
    public class MetalEdit : BaseState
    {
        private Menus.MetalEditGUI menuComponent;
        public MetalEdit() { }
        public override void Initialize()
        {
            CommonData.CurrentPartGameObject = CommonData.prefabs.gameobjectLookup[StringConstants.Prefab_Metal];
            InitializeUI();
        }
        private void InitializeUI()
        {
            if (menuComponent == null)
            {
                menuComponent = SpawnUI<Menus.MetalEditGUI>(StringConstants.Prefab_MetalEdit_GUI);
            }
            ShowUI();

        }
        public override void Suspend()
        {

            HideUI();
        }

        public override StateExitValue Cleanup()
        {

            DestroyUI();
            return null;
        }

        public override void HandleUIEvent(GameObject source, object eventData)
        {
           if (source == menuComponent.PillowlButton.gameObject)
           {
               Debug.Log(source.name);
              manager.SwapState(new PillowEdit());
           }
           else if (source == menuComponent.KarkasButton.gameObject)
           {
               Debug.Log(source.name);
               manager.SwapState(new KarkasEdit());
           }
           else if (source == menuComponent.FootsButton.gameObject)
           {
               Debug.Log(source.name);
                manager.SwapState(new FootsEdit());
           }

        }
    }
}
