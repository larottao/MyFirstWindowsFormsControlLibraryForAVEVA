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

        #region Assign Mouse down and up events to buttons

        private void buttonRED_MouseDown(object sender, MouseEventArgs e) => objectAction(sender, true);

        private void buttonRED_MouseUp(object sender, MouseEventArgs e) => objectAction(sender, false);

        private void buttonYellow_MouseDown(object sender, MouseEventArgs e) => objectAction(sender, true);

        private void buttonYellow_MouseUp(object sender, MouseEventArgs e) => objectAction(sender, false);

        private void buttonGreen_MouseDown(object sender, MouseEventArgs e) => objectAction(sender, true);

        private void buttonGreen_MouseUp(object sender, MouseEventArgs e) => objectAction(sender, false);

        private void buttonBlue_MouseDown(object sender, MouseEventArgs e) => objectAction(sender, true);

        private void buttonBlue_MouseUp(object sender, MouseEventArgs e) => objectAction(sender, false);

        private void buttonWhite_MouseDown(object sender, MouseEventArgs e) => objectAction(sender, true);

        private void buttonWhite_MouseUp(object sender, MouseEventArgs e) => objectAction(sender, false);

        #endregion Assign Mouse down and up events to buttons

        public UserControl1()
        {
            InitializeComponent();

            inputObjects.Add(new InputObject("Input0", buttonRed, pilotLightRed, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING));
            inputObjects.Add(new InputObject("Input1", buttonYellow, pilotLightYellow, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING));
            inputObjects.Add(new InputObject("Input2", buttonGreen, pilotLightGreen, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING));
            inputObjects.Add(new InputObject("Input3", buttonBlue, pilotLightBlue, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING));
            inputObjects.Add(new InputObject("Input4", buttonWhite, pilotLightWhite, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING));

            AttachButtonEvents();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic here
        }

        private void AttachButtonEvents()
        {
            foreach (var input in inputObjects)
            {
                input.associatedButon.MouseDown += (s, e) =>
                {
                    Console.WriteLine("MouseDown on " + input.associatedButon.Name);
                    objectAction(s, true);
                };

                input.associatedButon.MouseUp += (s, e) =>
                {
                    Console.WriteLine("MouseUp on " + input.associatedButon.Name);
                    objectAction(s, false);
                };
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

        private void objectAction(object sender, bool isDown)
        {
            var label = sender as Label;
            if (label == null)
                return;

            var input = inputObjects.Find(io => io.associatedButon == label);
            if (input == null)
                return;

            if (input.conType == InputObject.CON_TYPE.NORMALLY_OPEN_SPRING)
            {
                input.setActive(isDown);
                input.pilotImage.Visible = isDown;
            }

            Debug.WriteLine(input.tag + " is now " + (isDown ? "ACTIVE" : "INACTIVE"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}