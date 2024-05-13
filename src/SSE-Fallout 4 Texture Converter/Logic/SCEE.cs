using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_Fallout_4_Texture_Converter.Logic
{
    class SCEE
    {
        /// <summary>
        /// if the SDK vars exists it'll use those and combine it with the executable name and return the combined path.
        /// a few examples would be orbis-image2gnf.exe, libSceGnm.dll, libSceGpuAddress.dll, libSceTextureTool.dll
        /// </summary>
        /// <param name="exec"></param>
        /// <returns></returns>
        public static string GetExecutablePath(string executable)
        {
            string SCE_ORBIS_SDK_DIR = Environment.GetEnvironmentVariable("SCE_ORBIS_SDK_DIR");
            string SCE_PROSPERO_SDK_DIR = Environment.GetEnvironmentVariable("SCE_PROSPERO_SDK_DIR");

            if (SCE_ORBIS_SDK_DIR != null || SCE_PROSPERO_SDK_DIR != null)
            {
                string path = string.Empty;

                if (SCE_ORBIS_SDK_DIR != null)
                {
                    path = SCE_ORBIS_SDK_DIR;
                }

                if (SCE_PROSPERO_SDK_DIR != null)
                {
                    path = SCE_PROSPERO_SDK_DIR;
                }

                return path + "\\host_tools\\bin\\" + executable;
            }
            else
            {
                return Path.Combine(Environment.CurrentDirectory, "Data", executable);
            }
        }
    }
}
