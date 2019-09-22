using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc2
{
	public class DestroyImmediate1 : MonoBehaviour, IClickTarget
	{
		[ContextMenu( "Destroy" )]
		public void Clicked()
		{
			//Destroy( gameObject );
			//DestroyImmediate( gameObject );
			DestroyImmediate( gameObject.GetComponent<BoxCollider>(), true );
		}

	}
}

