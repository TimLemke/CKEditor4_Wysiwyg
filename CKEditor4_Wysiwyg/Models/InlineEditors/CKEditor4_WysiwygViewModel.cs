using System;

namespace SeventyeightDigital.CKEditor4_Wysiwyg
{
    /// <summary>
    /// View model for Text editor.
    /// </summary>
    public sealed class CKEditor4_WysiwygViewModel : InlineEditorViewModel
    {
        /// <summary>
        /// HTML formatted text.
        /// </summary>
        public string Html { get; set; }

        public Guid myID { get; set; } = Guid.NewGuid();
    }
}