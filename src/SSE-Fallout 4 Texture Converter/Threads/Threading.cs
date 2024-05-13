using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSE_Fallout_4_Texture_Converter
{
    public class Threading
    {
        //
        public static Threading Global = new Threading();

        /// <summary>
        /// a storage place for each constructed thread.
        /// </summary>
        public List<Thread> Workers = new List<Thread>();

        /// <summary>
        /// 
        /// </summary>
        public BackgroundWorker UIWorker = new BackgroundWorker();

        /// <summary>
        /// Max Allowed Task's
        /// </summary>
        /// <returns></returns>
        public static Int32 GetMaxAllowedTaskCount()
        {
            return Settings.Global.UseHalfThreadCount ? Environment.ProcessorCount / 2 : Environment.ProcessorCount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public void DispatchWorker(Delegate Task, List<List<string>> ObjectArray)
        {
            //
            Workers.Clear();

            //
            for (int i = 0; i < ObjectArray.Count; i++)
            {
                object[] args =
                {
                    ObjectArray[i], // 
                    i
                };

                Workers.Add(new Thread(() => Task.DynamicInvoke(args)));
            }
            
            //
            foreach (var worker in Workers)
            {
                //
                worker.Start();
            }
        }
    }
}
