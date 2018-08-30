using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBStruct<T> where T : new()
{
    public string dbPathName = "<<UNNAMED STRUCT>>";
    public bool areChangesPending { get; private set; }

    public T data { get; private set; }
    public T newData { get; private set; }

   

    DBStruct()
    {
        DiscardRemoteChanges();
    }

    public DBStruct(string name)
    {
        
        
        dbPathName = name;
        data = new T();
        newData = new T();
        
    }

    public void ApplyRemoteChanges()
    {
        if (areChangesPending)
        {
            Debug.Log("UPDATE DATABASE_1");
            data = newData;
            DiscardRemoteChanges();
        }
    }

    public void DiscardRemoteChanges()
    {
        areChangesPending = false;
    }

    // Returns a guaranteed unique string, usable as a dictionary key value.
    public string GetUniqueKey()
    {
        return null;
    }

    public void Initialize(T value)
    {
        data = value;
        newData = value;
        DiscardRemoteChanges();
        PushData();
    }

    

    public void PushData()
    {
        
    }

    public void PopData(string path)
    {
       
    }

    public void UpData(string path, string dataNew)
    {
        
    }
	
}
