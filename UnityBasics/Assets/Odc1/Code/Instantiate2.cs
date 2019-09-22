using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc1
{
	public class Instantiate2 : MonoBehaviour
	{
		[SF] private GameObject _prefab;

		void Start()
		{
			Vector3 spawnPoint = transform.position + transform.forward * 10;   // Punkt w który pojawi się kopia prefab'a, 
																				// bierzemy miejsce w którym znajduje się obiekt ze skryptem
																				// i dodajemy do niego 5 jednostek odległości w 
																				// kierunku na który się patrzy
			Quaternion spawnRotation = transform.rotation; // Quaternion.LookRotation(transform.position - spawnPoint, transform.up);
			Instantiate( _prefab, spawnPoint, spawnRotation );
		}
	}
}
