using DevExpress.Utils.Localization.Internal;
using DevExpress.Web.Localization;

namespace CustomLocalizer {
    public class MyEditorsLocalizer : ASPxEditorsLocalizer {

        public static void Activate() {
            MyEditorsLocalizer localizer = new MyEditorsLocalizer();
            DefaultActiveLocalizerProvider<ASPxEditorsStringId> provider =
                new DefaultActiveLocalizerProvider<ASPxEditorsStringId>(localizer);
            MyEditorsLocalizer.SetActiveLocalizerProvider(provider);
        }

        public override string GetLocalizedString(ASPxEditorsStringId id) {
            string result = base.GetLocalizedString(id);
            return string.Format("editors:{0}", result);
        }

    }
}
