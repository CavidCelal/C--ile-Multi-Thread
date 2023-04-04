using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Scada.Data;

namespace Scada.Componet.Gauge
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private int Cound = 0;
        private int FHeat;

        private TDevice FDevice;

        public TDevice Device
        {
            get { return GetDeviceVar(); }
            set { SetDeviceVar(value); }
        }

        private void SetDeviceVar(TDevice value)
        {
            FDevice = value;
            LblName.Text = FDevice.DeviceName;
        }

        private TDevice GetDeviceVar()
        {
            return FDevice;
        }

        public int Heat
        {
            get { return GetFHeat(); }
            set { SetFHeat(value); }
        }

        private void SetFHeat(int value)
        {
            FHeat = value;
            label1.Text = FHeat.ToString();
            trackBar1.Value = FHeat;
            if (FHeat > FMaxHeat)
            {
                if (FAlarmActive)
                    Blink();
            }
        }

        private int GetFHeat()
        {
            return FHeat;
        }

        private bool FAlarmActive;

        public bool  AlarimActive
        {
            get { return GetAlarmActive(); }
            set { SetAlarmActive(value); }
        }

        private void SetAlarmActive(bool value)
        {
            FAlarmActive = value;
        }

        private bool GetAlarmActive()
        {
            return FAlarmActive;
        }

        private int FMaxHeat;

        public int MaxHeat
        {
            get { return  GetFMaxHeat(); }
            set {  SetMaxHeat(value); }
        }

        private void SetMaxHeat(int value)
        {
            FMaxHeat = value;
        }

        private int GetFMaxHeat()
        {

            return FMaxHeat;
        }
       
        private void Blink()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    if (LblName.BackColor == Color.CornflowerBlue)
                        LblName.BackColor = Color.Red;
                    else
                        LblName.BackColor = Color.CornflowerBlue;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
