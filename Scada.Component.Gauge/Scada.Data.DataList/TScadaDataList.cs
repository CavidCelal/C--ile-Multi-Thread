using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Scada.Data.DataList
{
    public static class TScadaDataList
    {
        public static List<TData> DataList = new List<TData>();
        public static Queue<TData> Datas = new Queue<TData>();
        public static ConcurrentDictionary<int, List<TData>> Datalarim = new ConcurrentDictionary<int, List<TData>>();  


        public static void AddData(TData Data)
        {
            DataList.Add(Data);

        }

        public static void HeatData(TData Data)
        {
            Datas.Enqueue(Data);
        }
        public static TData GetHeatDatas()
        {
            return Datas.Dequeue();
        }

        public static void AddDatam(int DeviceId, TData Data)
        {
            List<TData> Datas = new List<TData>() { Data };
            Datalarim.TryAdd(DeviceId, Datas);
        }
        public static void GetData(int DeviceId)
        {
            List<TData> datas = new List<TData>();
            Datalarim.TryGetValue(DeviceId, out datas);
        }

    }
}
