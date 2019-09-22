using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc2
{
	public class Destroy1 : MonoBehaviour, IClickTarget
	{
		[SF][Range(0f, 15f)] private float _timeToDestory = 0f;

		public void Clicked()
		{
			//Destroy( gameObject );
			Destroy( gameObject, _timeToDestory );
		}
	}
}

