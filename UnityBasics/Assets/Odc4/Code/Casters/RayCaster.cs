using UnityEngine;

namespace Odc4
{
	public class RayCaster : MonoBehaviour, ICaster
	{
		public bool Cast( Ray ray, out RaycastHit hitInfo, float maxDistance, int layers )
		{
			return Physics.Raycast( ray, out hitInfo, maxDistance, layers );
		}

		public RaycastHit[] CastAll( Ray ray, float maxDistance, int layers )
		{
			return Physics.RaycastAll( ray, maxDistance, layers );
		}

		public int CastNonAlloc( Ray ray, RaycastHit[] results, float maxDistance, int layers )
		{
			return Physics.RaycastNonAlloc( ray, results, maxDistance, layers );
		}
	}
}
