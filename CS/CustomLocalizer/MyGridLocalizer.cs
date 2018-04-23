using DevExpress.Utils.Localization.Internal;
using DevExpress.Web.Localization;

namespace CustomLocalizer {
    public class MyGridLocalizer : ASPxGridViewLocalizer {

        public static void Activate() {
            MyGridLocalizer localizer = new MyGridLocalizer();
            DefaultActiveLocalizerProvider<ASPxGridViewStringId> provider =
                new DefaultActiveLocalizerProvider<ASPxGridViewStringId>(localizer);
            MyGridLocalizer.SetActiveLocalizerProvider(provider);
        }

        public override string GetLocalizedString(ASPxGridViewStringId id) {
            if (id == ASPxGridViewStringId.GroupPanel)
                return "Testing: group panel caption";
            string result = base.GetLocalizedString(id);
            return string.Format("grid:{0}", result);
        }

    }
}
