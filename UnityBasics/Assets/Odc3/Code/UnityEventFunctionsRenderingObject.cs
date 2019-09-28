using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Odc3.Odc3_Utils;


namespace Odc3.Assets.Odc3.Code
{
	public class UnityEventFunctionsRenderingObject : MonoBehaviour
	{
		 #region Rendering
		// Dla obiektu który będzie renderowany, dla każej kamery która będzie renderowała ten obiekt
		private void OnWillRenderObject()
		{
			Log( $"by camera {Camera.current.name}" );
		}

		// Kiedy obiekt był nie widoczny i staje się widoczny (włączanie obliczeń wymaganych kiedy gracz patrzy)
		private void OnBecameVisible()
		{
			Log();
		}

		// Kiedy obiekt był widoczny i staje się nie widoczny (wyłączenie obliczeń wymaganych kiedy gracz patrzy)
		private void OnBecameInvisible()
		{
			Log();
		}

		// Po wyrenderowaniu sceny można wyrenderować własną geometrię przez np. Graphics.DrawMeshNow
		private void OnRenderObject()
		{
			Log();
		}
		#endregion Rendering
	}
}
