using System.Web.Mvc;

namespace ManiaLink.Extensions.Elements
{
	/// <summary>
	/// Manialink XML file entry.
	/// </summary>
	public class FileEntry : ManialinkElement
	{
		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		/// <param name="viewContext"></param>
		public FileEntry(ViewContext viewContext)
			: base(viewContext, "fileentry", true)
		{
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// 
		/// </summary>
		public void EndFileEntry()
		{
			this.Dispose(true);
		}

		#endregion
	}
}