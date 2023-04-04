using Scada.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Scada.Data.DataList;

namespace Scada.Component.Gauge
{

    public delegate void RxOnGenerateDevice(List<TDevice> Devices);
    public delegate void RxOnGetDeviceData(List<TData> DataList);
        
    public  class TProcess
    {
        Thread ThrSimulation;
        private List<TDevice> Devices;
        private int DeviceCount;
        public event RxOnGetDeviceData OnGetDeviceData;
        public event RxOnGenerateDevice OnGenerateDevice;
        public void CreateDevices(int Count)
        {
            DeviceCount = Count;
            Devices = new List<TDevice>();
            for (int i = 0; i < Count; i++)
            {
                TDevice Device = new TDevice();
                Device.DeviceId = new Random().Next(10, 99);
                Thread.Sleep(20);
                Device.DeviceName = Device.DeviceId.ToString() + ".Cihaz";
                Devices.Add(Device);
                
            }
            if (OnGenerateDevice != null)
                OnGenerateDevice(Devices);
        }
        public void StartGenerateData()
        {
            if (ThrSimulation == null)
            {
                ThrSimulation = new Thread(new ThreadStart(DoStartGenerateData));
                ThrSimulation.Start();
            }
        }
        public void DoStartGenerateData()
        {
            foreach (var Device in Devices)
            {
                TDeviceProcess DeviceProcess = new TDeviceProcess(Device);
                DeviceProcess.Start();
            }
        }
        public void GetDevisesProcess()
        {
            foreach (var device in Devices)
            {
                TDeviseDataProcess DeviseDataProcess = new TDeviseDataProcess(device);
                DeviseDataProcess.OnGetDeviseData +=DeviseDataProcess_OnGetDeviseData;
                DeviseDataProcess.Start();
            }
        }

        private void DeviseDataProcess_OnGetDeviseData(List<TData> DataList)
        {
            if (OnGetDeviceData != null)
            {
                OnGetDeviceData(DataList);
            }
        }
    }
    public class TDeviceProcess
    {
        public TDevice Device;
        public Thread Mythread;
        public TDeviceProcess(TDevice device)
        {
            Device = device;
        }
        public void Start()
        {
            if ( Mythread == null)
            {
                Mythread = new Thread(new ThreadStart(DoStart));
                Mythread.Start();
            }
        }
        public void DoStart()
        {
            while (true)
            {

                lock (TScadaDataList.DataList)
                {
                    TData Data = new TData();
                    Data.DateTime = DateTime.Now;
                    Data.Heat = new Random().Next(1, 100);
                    Thread.Sleep(20);
                    Data.DeviceId = Device.DeviceId;
                    TScadaDataList.DataList.Add(Data);
                }
                int SleepTime = new Random().Next(3, 9);
                Thread.Sleep(SleepTime * 1000);
            }
        }
    }
    public class TDeviseDataProcess
    {
        public event RxOnGetDeviceData OnGetDeviseData;
        public TDevice devise;
        public Thread MyThread;
        public TDeviseDataProcess(TDevice Device)
        {
            devise = Device;
        }
        public void Start()
        {
            if (MyThread == null)
            {
                MyThread = new Thread(new ThreadStart(DoStart));
                MyThread.Start();
            }
        }
        public void DoStart()
        {
            while (true)
            {
                List<TData> DataList = new List<TData>();
                lock (TScadaDataList.DataList)
                {
                    DataList = (from datalist in TScadaDataList.DataList where datalist.DeviceId == devise.DeviceId orderby datalist.DateTime select datalist).ToList();
                    foreach (var data in DataList)
                    {
                        TScadaDataList.DataList.Remove(data);
                    }
                }
                if (OnGetDeviseData != null)
                {
                    OnGetDeviseData(DataList);
                }
                Thread.Sleep(500);
            }
        }
    }
}
