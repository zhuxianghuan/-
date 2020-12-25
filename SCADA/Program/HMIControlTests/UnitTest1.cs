using System;
using System.Windows.Forms;
using HMIControl;
using HMIControl.VisualStudio.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HMIControlTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string aa = "电流:Receiving2_LegCUR106_Digi\\设备名:Receiving1_Legmotor1\\运行:Receiving1_LegMotor1_Running\\OverCurrent:Receiving1_LegMotor1_Overload\\速度:Receiving1_Legmotor1Speed_Speed\\LowSpeed:Receiving1_leg1alm\\";
            var bb = aa.GetListFromText();
            foreach (var v in bb)
            {
               
                string[] strs = v.Key.Split('.');
                if (strs.Length > 1)
                {
                    for (int i = 0; i < strs.Length - 1; i++)
                    {
                       
                        
                    }
                }


            }
        }
    }
}
