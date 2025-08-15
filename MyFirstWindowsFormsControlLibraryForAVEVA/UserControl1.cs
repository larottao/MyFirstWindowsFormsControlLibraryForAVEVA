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

        public UserControl1()
        {
            InitializeComponent();

            //Map each input object to its respective button and light

            inputObjects.Add(new InputObject("Input0", buttonRed, pilotLightRed, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false));
            inputObjects.Add(new InputObject("Input1", buttonYellow, pilotLightYellow, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false));
            inputObjects.Add(new InputObject("Input2", buttonGreen, pilotLightGreen, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, true));
            inputObjects.Add(new InputObject("Input3", buttonBlue, pilotLightBlue, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false));
            inputObjects.Add(new InputObject("Input4", buttonWhite, pilotLightWhite, InputObject.CON_TYPE.NORMALLY_OPEN_SPRING, false));

            attachButtonEvents();
        }

        #region Create bindable properties for each object and expose them to AVEVA

        [Category("Inputs")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputObject Input0
        {
            get => inputObjects[0];
            set
            {
                inputObjects[0] = value;
                applyInputState(inputObjects[0]);
            }
        }

        [Category("Inputs")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputObject Input1
        {
            get => inputObjects[1];
            set
            {
                inputObjects[1] = value;
                applyInputState(inputObjects[1]);
            }
        }

        [Category("Inputs")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputObject Input2
        {
            get => inputObjects[2];
            set
            {
                inputObjects[2] = value;
                applyInputState(inputObjects[2]);
            }
        }

        [Category("Inputs")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputObject Input3
        {
            get => inputObjects[3];
            set
            {
                inputObjects[3] = value;
                applyInputState(inputObjects[3]);
            }
        }

        [Category("Inputs")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputObject Input4
        {
            get => inputObjects[4];
            set
            {
                inputObjects[4] = value;
                applyInputState(inputObjects[4]);
            }
        }

        #endregion Create bindable properties for each object and expose them to AVEVA

        #region Another example, in this case create a Label property exposed to AVEVA

        [Category("OMI Bindable Properties")]
        [DisplayName("Label Text")]
        [Description("Text to display in the label.")]
        public string LabelText
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }

        #endregion Another example, in this case create a Label property exposed to AVEVA


        private void attachButtonEvents()
        {
            foreach (var input in inputObjects)
            {
                input.AssociatedButton.MouseDown += (s, e) =>
                {
                    executeButtonAction(s, true);
                };

                input.AssociatedButton.MouseUp += (s, e) =>
                {
                    executeButtonAction(s, false);
                };
            }
        }

        private void executeButtonAction(object sender, bool isDown)
        {
            var button = sender as Label;
            if (button == null)
                return;

            var input = inputObjects.Find(io => io.AssociatedButton == button);
            if (input == null)
                return;

            if (input.ConnectionType == InputObject.CON_TYPE.NORMALLY_OPEN_SPRING)
                input.IsActive = isDown;
            else if (input.ConnectionType == InputObject.CON_TYPE.NORMALLY_CLOSED_SPRING)
                input.IsActive = !isDown;

            applyInputState(input);

            Debug.WriteLine(input.Tag + " is now " + (input.IsActive ? "ACTIVE" : "INACTIVE"));
        }

        private void applyInputState(InputObject input)
        {
            if (input.PilotImage != null)
                input.PilotImage.Visible = input.IsActive;
        }
 
    }
}