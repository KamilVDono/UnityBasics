using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc1
{
	public class Instantiate4 : MonoBehaviour
	{
		[SF] private GameObject[] _prefabs;
		[SF] private Transform _prefabsParent;

		void Start()
		{
			foreach ( var prefab in _prefabs )
			{
				Instantiate( prefab, _prefabsParent, true);
			}
		}
	}
}
