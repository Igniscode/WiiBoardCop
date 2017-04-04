using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using WiimoteLib;
using System.IO;

namespace BalanceBoardDataAnalysis
{

    public partial class Screen : Form
    {
        static String Target_path = "E:/Defaultname.txt";
        Wiimote wiiDevice = new Wiimote();
        public System.Timers.Timer UpdateTimer = new System.Timers.Timer() { Interval = 50, Enabled = false };
        public float _LeftTop, _RightTop, _LeftBottom, _RightBottom;
        public float initLT, initRT, initLB, initRB;
        List<string> datas = new List<string>();
        bool file_in = false;
        
        private void LabelOD_Click(object sender, EventArgs e)
        {
            Target_path = "E:/" + Filenamebox.Text + ".txt";
            File.WriteAllLines(Target_path, datas);
            file_in = false;
            datas.Clear();
        }

        private void LabelID_Click(object sender, EventArgs e)
        {
            file_in = true;
        }

        public Screen()
        {
            InitializeComponent();
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            UpdateTimer.Elapsed += new ElapsedEventHandler(UpdateTimer_Elapsed);
            _setConnection();
        }
        void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            BeginInvoke(new Action(() => Update()));
        }

        public void _setConnection()
        {
            WiimoteCollection dvcCol = new WiimoteCollection();
            dvcCol.FindAllWiimotes();
            wiiDevice = dvcCol[0];
            wiiDevice.WiimoteChanged += wiiDevice_WiimoteChanged;
            wiiDevice.Connect();
            wiiDevice.SetReportType(InputReport.IRAccel, false);
            wiiDevice.SetLEDs(true, false, false, false);
            UpdateTimer.Enabled = true;

            initLT = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopLeft;
            initRT = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopRight;
            initLB = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomLeft;
            initRB = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomRight;
        }

        public void wiiDevice_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            //Call When Changed
        }


        public void Update()
        {
            _LeftTop = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopLeft - initLT;
            _RightTop = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopRight - initRT;
            _LeftBottom = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomLeft - initLB;
            _RightBottom = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomRight - initRB;

            LabelTL.Text = _LeftTop.ToString();
            LabelTR.Text = _RightTop.ToString();
            LabelBL.Text = _LeftBottom.ToString();
            LabelBR.Text = _RightBottom.ToString();

            float x, y;
            int xint, yint;
            x = _RightTop + _RightBottom - _LeftTop - _LeftBottom;
            y = _RightTop + _LeftTop - _RightBottom - _LeftBottom;
            xint = (int)x;
            yint = (int)y;
            if (file_in)
            {
                String tmp_str = xint.ToString() + " " + yint.ToString();
                datas.Add(tmp_str);
            }
        }
    }
}
