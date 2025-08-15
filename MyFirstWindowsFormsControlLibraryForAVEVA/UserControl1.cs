using MyFirstWindowsFormsControlLibraryForAVEVA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyFirstWindowsFormsControlLibraryForAVEVA
{
    // Make the control visible to COM

    [ComVisible(true)]
    [Guid("E1234567-89AB-4CDE-ABCD-0123456789AC")] // Change if AVEVA refuses to refresh
    [ProgId("MyAvevaControl.MainControl")]
    public partial class UserControl1 : UserControl
    {
        private List<InputObject> inputObjects = new List<InputObject>();

        [Category("OMI Bindable Properties")]
        [DisplayName("Input 0")]
        public InputObject Input0 { get; private set; }

        [Category("OMI Bindable Properties")]
        [DisplayName("Input 1")]
        public InputObject Input1 { get; private set; }

        [Category("OMI Bindable Properties")]
        [DisplayName("Input 2")]
        public InputObject Input2 { get; private set; }

        [Category("OMI Bindable Properties")]
        [DisplayName("Input 3")]
        public InputObject Input3 { get; private set; }

        [Category("OMI Bindable Properties")]
        [DisplayName("Input 4")]
        public InputObject Input4 { get; private set; }

        public UserControl1()
        {
            InitializeComponent();

            Input0 = new InputObject("Input0", buttonRed, pilotLightRed, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false);
            Input1 = new InputObject("Input1", buttonYellow, pilotLightYellow, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false);
            Input2 = new InputObject("Input2", buttonGreen, pilotLightGreen, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, true);
            Input3 = new InputObject("Input3", buttonBlue, pilotLightBlue, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false);
            Input4 = new InputObject("Input4", buttonWhite, pilotLightWhite, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false);

            AttachButtonEvents();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic here
        }

        private void AttachButtonEvents()
        {
            foreach (var input in new[] { Input0, Input1, Input2, Input3, Input4 })
            {
                input.AssociatedButton.MouseDown += (s, e) => objectAction(input, true);
                input.AssociatedButton.MouseUp += (s, e) => objectAction(input, false);
            }
        }

        // How to expose a property to AVEVA Properties panel

        [Category("OMI Bindable Properties")]
        [DisplayName("Label Text")]
        [Description("Text to display in the label.")]
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        private void objectAction(InputObject input, bool isDown)
        {
            if (input.ConnectionType == InputObject.CON_TYPE.NORMALLY_OPEN_SPRING)
            {
                input.SetActive(isDown);
            }
            Debug.WriteLine($"{input.Tag} is now {(isDown ? "ACTIVE" : "INACTIVE")}");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}