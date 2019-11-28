# CKEditor4 Wysiwyg Editor

# Installation

1. Install the `SeventyeightDigital.CKEditor4_Wysiwyg.Kentico.MVC` NuGet Package to your MVC Site
2. For ease of integration and to prevent CSS styling conflicts, a link to the CDN for CKEditor 4 must be placed before `@HTML.Kentico().PageBuilderScripts()`
   (ckeditor-cdninclude.png)
3. If you wish to configure the CKEditor 4 toolbar, you can do so by editing the currently commented out toolbar configuration option found in `CKEditor4-InlineEditor.ks`
   (ckeditor-toolbaroptions.png)

# Inline Editor

You can add the Inline Editor to your own widget creations by following the example below:

```
@if (Context.Kentico().PageBuilder().EditMode)
{
    Html.RenderPartial("InlineEditors/_CKEditor4_WysiwygInlineEditor", new CKEditor4_WysiwygViewModel
    {
        PropertyName = nameof(Model.Properties.Html),
        Html = Model.Properties.Html
    });
}
else
{
    if (Model.Properties.Html != "" && Model.Properties.Html != null)
    {
        @Html.Kentico().ResolveUrls(Model.Properties.Html)
    }
}

```

# Widget

There is one widget, `CKEditor4 WYSIWYG Editor Widget` which allows for content entry via the page tab.

![CKEditor4 Widget](CkEditor4_Wysiwyg-Demo.gif)

# Contributions, bug fixes and license

This inline editor / widget integration comes without any support whatsoever.

Feel free to Fork and submit pull requests to contribute.

Check the License.txt for License information

# Compatability

Can be used on any Kentico 12 SP site (hotfix 29 or above).
