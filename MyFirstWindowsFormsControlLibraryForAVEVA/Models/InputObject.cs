using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyFirstWindowsFormsControlLibraryForAVEVA.Models
{
    [TypeConverter(typeof(ExpandableObjectConverter))] //
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

        // Current active state
        [Category("Runtime State")]
        [Description("Whether this input is active.")]
        public bool IsActive { get; set; }

        [Category("Initial Status")]
        [Description("Whether this input is active or inactive at the start.")]
        public bool initialValue { get; set; }

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

        public InputObject(string argTag, Label argButton, PictureBox argPilotPicture, CON_TYPE argConnType, Boolean argInitialValue)
        {
            Tag = argTag;
            AssociatedButton = argButton;
            PilotImage = argPilotPicture;
            ConnectionType = argConnType;
            IsActive = argInitialValue;
            argPilotPicture.Visible = argInitialValue;
        }

        public void SetActive(bool buttonPressed)
        {
            // Determine "active" state based on connection type
            if (ConnectionType == CON_TYPE.NORMALLY_OPEN_SPRING)
            {
                IsActive = buttonPressed;
            }
            else if (ConnectionType == CON_TYPE.NORMALLY_CLOSED_SPRING)
            {
                IsActive = !buttonPressed;
            }

            if (PilotImage != null)
                PilotImage.Visible = IsActive;
        }

        public override string ToString()
        {
            return $"{Tag} ({ConnectionType}) Active={IsActive}";
        }
    }
}