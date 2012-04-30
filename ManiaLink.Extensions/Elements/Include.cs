using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML include.
	/// </summary>
	public class Include : ManialinkElement
	{
		#region Constructor

		public Include(ViewContext viewContext)
			: base(viewContext, "include", true)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndInclude()
		{
			this.Dispose(true);
		}

		#endregion
	}
}