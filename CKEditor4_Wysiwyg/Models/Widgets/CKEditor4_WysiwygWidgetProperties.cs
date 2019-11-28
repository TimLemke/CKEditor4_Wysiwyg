using Kentico.PageBuilder.Web.Mvc;

namespace SeventyeightDigital.CKEditor4_Wysiwyg
{
    /// <summary>
    /// Properties for Editable Text widget.
    /// </summary>
    public class CKEditor4_WysiwygWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// HTML formatted text.
        /// </summary>
        public string Html { get; set; }
    }
}