using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public static Dictionary<int, string> comDic = new Dictionary<int, string>();

    public static void SetData()
	{
		comDic.Add(1001, "검");
		comDic.Add(1002, "방패");
		comDic.Add(1003, "옷");
		comDic.Add(1004, "물약");
		comDic.Add(1005, "부적");
		comDic.Add(1006, "지팡이");
		comDic.Add(1007, "책");
		comDic.Add(1008, "돈주머니");

		comDic.Add(2001, "누군가의 소문");
		comDic.Add(2002, "식당가 괴담");

		Debug.Log("셋팅완료");
	}

	public static string GetData(int _id)
	{
		if (comDic.ContainsKey(_id))
		{
			Debug.Log(_id+". "+comDic[_id]);
			return comDic[_id];
		}
		return null;
	}
}
