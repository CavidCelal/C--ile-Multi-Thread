using Scada.Componet.Gauge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scada.Component.Gauge
{
    public partial class Form1 : Form
    {
        public List<Scada.Data.TDevice> Devices;
        private TProcess process;
        public Form1()
        {
            InitializeComponent();
            process = new TProcess();
            process.OnGenerateDevice +=Process_OnGenerateDevice;
            process.OnGetDeviceData +=Process_OnGetDeviceData;
        }

        private void Process_OnGetDeviceData(List<Data.TData> DataList)
        {
            foreach (var item in DataList)
            {
                var Cntrl = PnlDevices.Controls.Find("gauge_" + item.DeviceId.ToString(), true).FirstOrDefault();

                if (Cntrl != null)
                {
                    ((Componet.Gauge.UserControl1)Cntrl).Heat = item.Heat;
                }
            }
        }
        private void Process_OnGenerateDevice(List<Data.TDevice> Devices)
        {
            this.Devices = Devices;
            GenerateScadaGauge();
            process.StartGenerateData();
            Thread.Sleep(2000);
            process.GetDevisesProcess();
        }
        private void GenerateScadaGauge()
        {
            foreach (var Device in Devices)
            {
                UserControl1 gauge = new UserControl1();
                gauge.Dock = DockStyle.Left;
                gauge.Name = "gauge_" + Device.DeviceId.ToString();
                gauge.AlarimActive = true;
                gauge.Device = Device;
                gauge.MaxHeat = 70;
                gauge.Parent = PnlDevices;
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            
        }



        private void PnlDevices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            int Count = (int)TxtCount.Value;
            process.CreateDevices(Count);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
