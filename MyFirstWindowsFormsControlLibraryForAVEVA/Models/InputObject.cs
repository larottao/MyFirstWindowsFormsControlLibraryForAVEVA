using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyFirstWindowsFormsControlLibraryForAVEVA.Models
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InputObject
    {
        public enum CON_TYPE
        {
            NORMALLY_OPEN_SPRING,
            NORMALLY_CLOSED_SPRING
        }

        // The tag name for AVEVA binding
        [Category("Input Settings")]
        [Description("The tag name used in AVEVA.")]
        public string Tag { get; set; }

        private bool isActive;

        // Current active state - now updates PilotImage when changed from AVEVA
        [Category("Runtime State")]
        [Description("Whether this input is active.")]
        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;
                if (PilotImage != null)
                    PilotImage.Visible = isActive;
            }
        }

        [Category("Initial Status")]
        [Description("Whether this input is active or inactive at the start.")]
        public bool InitialValue { get; set; }

        // Type of contact
        [Category("Input Settings")]
        [Description("The type of input contact.")]
        public CON_TYPE ConnectionType { get; set; }

        [Browsable(false)]
        public Label AssociatedButton { get; set; }

        [Browsable(false)]
        public PictureBox PilotImage { get; set; }

        public InputObject()
        { } // Needed for property grid serialization

        public InputObject(string argTag, Label argButton, PictureBox argPilotPicture, CON_TYPE argConnType, bool argInitialValue)
        {
            Tag = argTag;
            AssociatedButton = argButton;
            PilotImage = argPilotPicture;
            ConnectionType = argConnType;
            InitialValue = argInitialValue;
            IsActive = argInitialValue; // Will also set PilotImage.Visible
        }

        public override string ToString()
        {
            return $"{Tag} ({ConnectionType}) Active={IsActive}";
        }
    }
}