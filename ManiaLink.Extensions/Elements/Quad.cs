using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML quad.
	/// </summary>
	public class Quad : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Quad(ViewContext viewContext)
			: base(viewContext, "quad", true)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndQuad()
		{
			this.Dispose(true);
		}

		#endregion
	}
}