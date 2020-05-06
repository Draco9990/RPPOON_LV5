using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);
    }
}
