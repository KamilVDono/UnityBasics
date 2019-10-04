using UnityEngine;

namespace Odc4
{
	public class OnClickLogger : MonoBehaviour, IClickTarget
	{
		public void Clicked()
		{
			Debug.Log( $"Clicked on {gameObject.name}" );
		}
	}
}
