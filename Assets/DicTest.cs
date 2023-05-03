using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DicTest : MonoBehaviour
{
	public static void Dic()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>();
		dict[1] = "one";
		dict[2] = null;
		dict[3] = "three";

		var nonNullKeys = dict.Where(kvp => kvp.Value != null).Select(kvp => kvp.Key);

		foreach (int key in nonNullKeys)
		{
			Debug.Log(key);
		}
	}
}
