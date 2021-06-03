using DevExpress.Utils.Serializing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace Reporting_AspNetMvc_Create_Custom_Control
{
    public class NumericLabel : XRLabel
    {
        [Browsable(true), Bindable(false), Category("Data")]
        [XtraSerializableProperty]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        EditorBrowsable(EditorBrowsableState.Always)]
        public int Number { get; set; }

        // Render the control in the Designer's Preview and in the document.
        protected override void PutStateToBrick(VisualBrick brick, PrintingSystemBase ps)
        {
            base.PutStateToBrick(brick, ps);
            brick.Text = this.Number.ToString();
        }
    }
}
