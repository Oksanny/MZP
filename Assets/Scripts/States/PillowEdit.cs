using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace States
{
    public class PillowEdit : BaseState
    {
        private Menus.PillowEditGUI menuComponent;
        public PillowEdit() { }
        public override void Initialize()
        {

            InitializeUI();
        }
        private void InitializeUI()
        {
            if (menuComponent == null)
            {
                menuComponent = SpawnUI<Menus.PillowEditGUI>(StringConstants.Prefab_PillowEdit_GUI);
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
          if (source == menuComponent.KarkasButton.gameObject)
          {
              Debug.Log(source.name);
               manager.SwapState(new KarkasEdit());
             
          }
          else if (source == menuComponent.FootsButton.gameObject)
          {
              Debug.Log(source.name);
             manager.SwapState(new FootsEdit());
          }
          else if (source == menuComponent.MetalButton.gameObject)
          {
              Debug.Log(source.name);
               manager.SwapState(new MetalEdit());
          }

        }
    }
}
