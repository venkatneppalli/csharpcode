using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            browserTypes.WebDriverConcepts c = new browserTypes.WebDriverConcepts();
            //c.openChrome_Browser();
            isMethods.WebDriverConcepts i = new isMethods.WebDriverConcepts();
            //i.isDisplayMethod();
            // i.isSelectMethod();

            dropDownList.WebDriverConcepts d = new dropDownList.WebDriverConcepts();
            //d.dropDownList();

            switchTo.WebDriverConcepts s = new switchTo.WebDriverConcepts();
            //s.iframe_switchTo();
            //s.alert_switchTo();
            //s.popupWindow_switchTo();
            s.iframe_switchTo_frameName();

            getAttribute.WebDriverConcepts g = new getAttribute.WebDriverConcepts();
            //g.getAttribute_value();



            popupWindows_Handling.WebDriverConcepts p = new popupWindows_Handling.WebDriverConcepts();
            //p.popupWindow_switchTo();
            //p.countWindows_switchTo();
            //p.countANDSwitch_switchTo();

            Console.ReadKey();
        }
    }
}
