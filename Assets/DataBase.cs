using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public static Dictionary<int, string> comDic = new Dictionary<int, string>();

    public static void SetData()
	{
		comDic.Add(1001, "��");
		comDic.Add(1002, "����");
		comDic.Add(1003, "��");
		comDic.Add(1004, "����");
		comDic.Add(1005, "����");
		comDic.Add(1006, "������");
		comDic.Add(1007, "å");
		comDic.Add(1008, "���ָӴ�");

		comDic.Add(2001, "�������� �ҹ�");
		comDic.Add(2002, "�Ĵ簡 ����");

		Debug.Log("���ÿϷ�");
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