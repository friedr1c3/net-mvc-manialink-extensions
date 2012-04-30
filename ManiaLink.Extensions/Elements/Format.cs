using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML format.
	/// </summary>
	public class Format : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Format(ViewContext viewContext)
			: base(viewContext, "format", true)
		{
		}

		#endregion
	}
}