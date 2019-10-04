using UnityEngine;

namespace Odc4
{
	// Interfejs pozwalający zastosować w prosty sposób wzorzec strategii dla obiektów cast'ujących
	public interface ICaster
	{
		bool Cast( Ray ray, out RaycastHit hitInfo, float maxDistance, int layers );
		RaycastHit[] CastAll( Ray ray, float maxDistance, int layers );
		int CastNonAlloc( Ray ray, RaycastHit[] results, float maxDistance, int layers );
	}
}
