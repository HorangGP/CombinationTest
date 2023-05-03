using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Combination : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataBase.SetData();
    }

    public void Refresh()
    {
		var nonNullKeys = DataBase.comDic.Where(kvp => kvp.Value != null).Select(kvp => kvp.Key);

		foreach(int key in nonNullKeys)
		{
			DataBase.GetData(key);
		}
		//if (DataBase.comDic.Count != 0)
		//{
  //          for (int i = 0; i < DataBase.comDic.Count; i++)
  //          {
		//		if (DataBase.GetData(i) == null)
		//		{
		//			while (DataBase.GetData(i) == null)
		//			{
  //                      i = i + 1;
		//			}
  //                  Debug.Log(DataBase.GetData(i) + " 반복");
		//		}
		//		else
		//		{
  //                  Debug.Log(DataBase.GetData(i) + " 직진");
  //              }
  //          }
  //      }
		//else
		//{
  //          return;
		//}
    }
}
