using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace States
{
    // Utility state, for fetching structures from the database.
    // Returns the result in the result struct.
    class WaitingForDBLoad <T> : BaseState
    {
        protected bool isComplete = false;
        protected bool wasSuccessful = false;
        protected string path;
        protected int failedFetches = 0;

        const int MaxDatabaseRetries = 5;
        protected T result = default(T);
       
        Menus.SingleLabelGUI menuComponent;
        public WaitingForDBLoad(string path)
        {
            this.path = path;
        }
        // Initialization method.  Called after the state
        // is added to the stack.
        public override void Initialize()
        {
            Debug.Log("Init WaitingForDB");
         
            menuComponent = SpawnUI<Menus.SingleLabelGUI>(StringConstants.PrefabsSingleLabelMenu);
            UpdateLabelText();
        }
        
        
        // If a fetch from the database comes back failed, try again, until the
        // maximum number of retries have been reached.  Failures are most often
        // caused by connectivity issues or database access rules.
        //Если выборка из базы данных не удалась, повторите попытку, 
        //пока не будет достигнуто максимальное количество попыток.
        // Отказы чаще всего возникают из-за проблем с подключением или правил доступа к базе данных.
        
        // Called once per frame when the state is active.
        public override void Update()
        {
            //Debug.Log("UPDATE");
            if (isComplete)
            {
                Debug.Log("UPDATE");
                manager.PopState();
            }
            else
            {
                UpdateLabelText();
            }
        }

        private void UpdateLabelText()
        {
           // Debug.Log("UpdateLabelText WaitingForDB");
            if (menuComponent != null)
            {
                menuComponent.LabelText.text =
                  StringConstants.LabelLoading + Utilities.StringHelper.CycleDots();
            }
        }
        public override StateExitValue Cleanup()
        {
            DestroyUI();
            return new StateExitValue(
              typeof(WaitingForDBLoad<T>), new Results(path, result, wasSuccessful));
        }
        // Class for encapsulating the results of the database load, as
        // well as information about whether the load was successful
        // or not.
        public class Results
        {

            public string path;
            public T results;
            public bool wasSuccessful;

            public Results(string path, T results, bool wasSuccessful)
            {
                this.path = path;
                this.results = results;
                this.wasSuccessful = wasSuccessful;
            }
        }
    }
}
