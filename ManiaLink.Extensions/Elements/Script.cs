using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink script element.
	/// </summary>
	public class Script : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Script(ViewContext viewContext)
			: base(viewContext, "script", false)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndScript()
		{
			this.Dispose(true);
		}

		#endregion
	}
}