using DevExpress.Utils.Localization.Internal;
using DevExpress.Web.Localization;

namespace CustomLocalizer {
    public class MyWebLocalizer : ASPxperienceLocalizer {

        public static void Activate() {
            MyWebLocalizer localizer = new MyWebLocalizer();
            DefaultActiveLocalizerProvider<ASPxperienceStringId> provider =
                new DefaultActiveLocalizerProvider<ASPxperienceStringId>(localizer);
            MyWebLocalizer.SetActiveLocalizerProvider(provider);
        }

        public override string GetLocalizedString(ASPxperienceStringId id) {
            string result = base.GetLocalizedString(id);
            return string.Format("web:{0}", result);
        }

    }
}
