using System.Text;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FacebookApp.Helpers
{
    public static class FacebookHelper
    {
        public static MvcHtmlString OpenGraphTags()
        {
            StringBuilder result = new StringBuilder();

            TagBuilder tag = new TagBuilder("meta");
            tag.MergeAttribute("property", "og:title", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_title"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            tag.MergeAttribute("property", "og:description", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_desc"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            tag.MergeAttribute("property", "og:type", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_type"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            tag.MergeAttribute("property", "og:image", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_image"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            tag.MergeAttribute("property", "og:url", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_url"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            tag.MergeAttribute("property", "og:site_name", true);
            tag.MergeAttribute("content", WebConfigurationManager.AppSettings["og_sitename"], true);
            result.AppendLine(tag.ToString(TagRenderMode.SelfClosing));

            return MvcHtmlString.Create(result.ToString());
        }
    }
}
