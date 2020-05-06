using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class PurpleTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
