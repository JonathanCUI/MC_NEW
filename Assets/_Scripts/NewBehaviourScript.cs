using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SqliteDB;
using Mono.Data.Sqlite;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DBManager.Initialize("tt");
        SqliteDataReader reader = DBManager.ExecuteQuery("SELECT * FROM Localization");
        while (reader.Read())
        {
            Debug.Log(reader["key"] + reader["value"].ToString());
            //Debug.Log(reader.GetString(reader.GetOrdinal("key")) + " " + reader.GetString(reader.GetOrdinal("value")));
        }
        reader = DBManager.ExecuteQuery("SELECT * FROM HeroBattleProperty");
        Debug.Log(reader.GetInt32(2));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        DBManager.Close();
    }
}
