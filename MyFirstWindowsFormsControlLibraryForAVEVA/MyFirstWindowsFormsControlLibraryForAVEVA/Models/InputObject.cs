using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsControlLibraryForAVEVA.Models
{
    public class InputObject
    {
        public enum CON_TYPE
        { NORMALLY_OPEN_SPRING, NORMALLY_CLOSED_SPRING, NORMALLY_OPEN_LATCH, NORMALLY_CLOSED_LATCH }

        public String tag { get; set; }
        public PictureBox pilotImage { get; set; }
        public Label associatedButon { get; set; }

        public CON_TYPE conType { get; set; }

        public Boolean isActive { get; set; }

        public InputObject(String argTag, Label argAssociatedButon, PictureBox argImage, CON_TYPE argType)
        {
            tag = argTag;
            associatedButon = argAssociatedButon;
            pilotImage = argImage;
            conType = argType;
            isActive = false;
        }

        public void setActive(Boolean argStatus)
        {
            isActive = argStatus;
        }
    }
}