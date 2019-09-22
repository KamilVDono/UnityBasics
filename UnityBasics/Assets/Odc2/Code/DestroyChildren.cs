using UnityEngine;

namespace Odc2
{
	public class DestroyChildren : MonoBehaviour
	{
		public void Start()
		{
			for ( int i = transform.childCount - 1; i >= 0; i-- ) // Iterujemy od tyłu, WAŻNE!!!
			{
				GameObject child = transform.GetChild(i).gameObject; // Pobierz dziecko
				if ( child.GetComponent<PleaseDoNotDestroyMe>() == null ) // Jeżeli dziecko nie prosi to je niszczymy
				{
					Destroy( child );
				}
			}

			//transform.DestroyAllChildren();
		}
	}

	// Klasa rozszerzająca do klasy transform
	//public static class TransformExtensions
	//{
	//	public static void DestroyAllChildren( this Transform transform )
	//	{
	//		for ( int i = transform.childCount - 1; i >= 0; i-- )
	//		{
	//			Object.Destroy( transform.GetChild( i ).gameObject );
	//		}
	//	}
	//}
}

