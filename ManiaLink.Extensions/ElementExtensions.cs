using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManiaLink.Extensions
{
	using Elements;

	/// <summary>
	/// Manialink element extensions.
	/// </summary>
	public static class ElementExtensions
	{
		#region Public Methods

		/// <summary>
		/// Begins a Manialink XML audio element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Audio BeginAudio(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Audio>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML entry element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Entry BeginEntry(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Entry>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML file entry element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static FileEntry BeginFileEntry(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<FileEntry>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML format element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Format BeginFormat(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Format>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML frame.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Frame BeginFrame(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Frame>(html, xmlAttributes);
		}

		/// <summary>
		/// Renders a Manialink XML include element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="resourceURL"></param>
		/// <returns></returns>
		public static Include Include(this HtmlHelper html, string resourceURL)
		{
			return ElementHelper<Include>(html, new { url = resourceURL });
		}

		/// <summary>
		/// Begins a Manialink XML label element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Label BeginLabel(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Label>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML quad element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Quad BeginQuad(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Quad>(html, xmlAttributes);
		}

		/// <summary>
		/// Begins a Manialink XML script element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Script BeginScript(this HtmlHelper html)
		{
			return ElementHelper<Script>(html, null);
		}

		/// <summary>
		/// Begins a Manialink XML video element.
		/// </summary>
		/// <param name="html"></param>
		/// <param name="xmlAttributes"></param>
		/// <returns></returns>
		public static Video BeginVideo(this HtmlHelper html, object xmlAttributes)
		{
			return ElementHelper<Video>(html, xmlAttributes);
		}

		#endregion

		#region Private Methods

		/// <summary>
		/// Renders an Manialink XML element.
		/// </summary>
		/// <typeparam name="T">The XML element to render.</typeparam>
		/// <param name="element">An instance of a Manialink XML element.</param>
		/// <param name="html">MVC HTML helper.</param>
		/// <param name="xmlAttributes"></param>
		/// <returns>Rendered XML element.</returns>
		private static T ElementHelper<T>(HtmlHelper html, object xmlAttributes) where T : ManialinkElement
		{
			// Create an instance of the element.
			T element = (T)Activator.CreateInstance(typeof(T), new object[] { html.ViewContext });

			// Convert the anonymous object(s) to element attributes.
			var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(xmlAttributes);

			// Create a new TagBuilder instance for the Manialink element.
			TagBuilder builder = new TagBuilder(element.ElementName);
			builder.MergeAttributes<string, object>(attributes); // Merge XML attributes.

			// Write tag to view context.
			html.ViewContext.Writer.Write(builder.ToString((element.SelfClosing ? TagRenderMode.SelfClosing : TagRenderMode.StartTag)));

			return element;
		}

		#endregion
	}
}