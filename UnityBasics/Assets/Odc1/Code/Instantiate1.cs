using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc1
{
	public class Instantiate1 : MonoBehaviour
	{
		[SF] private GameObject _prefab;

		void Start()
		{
			Instantiate( _prefab );
		}
	}
}

