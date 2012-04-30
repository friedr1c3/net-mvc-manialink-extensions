using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML audio.
	/// </summary>
	public class Audio : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public Audio(ViewContext viewContext)
			: base(viewContext, "audio", true)
		{
		}

		#endregion
	}
}