using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace States
{
    public class KarkasEdit : BaseState
    {
        private Menus.KarkasEditGUI menuComponent;
        public KarkasEdit() { }
        public override void Initialize()
        {

            InitializeUI();
        }
        private void InitializeUI()
        {
            if (menuComponent == null)
            {
                menuComponent = SpawnUI<Menus.KarkasEditGUI>(StringConstants.Prefab_KarkasEdit_GUI);
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
            else if (source == menuComponent.FootsButton.gameObject)
            {
                Debug.Log(source.name);
                 manager.SwapState(new FootsEdit());
            }

        }
    }
}
