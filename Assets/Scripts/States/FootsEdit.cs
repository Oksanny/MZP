using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace States
{
    public class FootsEdit : BaseState
    {
        private Menus.FootsEditGUI menuComponent;
        public FootsEdit() { }
        public override void Initialize()
        {

            InitializeUI();
        }
        private void InitializeUI()
        {
            if (menuComponent == null)
            {
                menuComponent = SpawnUI<Menus.FootsEditGUI>(StringConstants.Prefab_FootsEdit_GUI);
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
           if (source == menuComponent.PillowButton.gameObject)
           {
               Debug.Log(source.name);
              manager.SwapState(new PillowEdit());
           }
           else if (source == menuComponent.MetalButton.gameObject)
           {
               Debug.Log(source.name);
               manager.SwapState(new MetalEdit());
           }
           else if (source == menuComponent.KarkasButton.gameObject)
           {
               Debug.Log(source.name);
                manager.SwapState(new KarkasEdit());
           }

        }
    }
}
