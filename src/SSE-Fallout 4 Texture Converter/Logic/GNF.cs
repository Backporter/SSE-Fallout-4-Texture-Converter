using SSE_Fallout_4_Texture_Converter;
using SSE_Fallout_4_Texture_Converter.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE_Fallout_4_Texture_Converter
{
    class GNF
    {
        //  *.bmp, *.dds, *.exr, *.gnf, *.hdr, *.jpg, *.jpeg, *.pfm, *.pic, *.png, *.psd, *.tga, *.tiff
        public static List<string> SupportedExtenstion = new List<string>()
        {
            ".bmp",
            ".dds",
            ".exr",
            ".gnf",
            ".hdr",
            ".jpg",
            ".jpeg",
            ".pfm",
            ".pic",
            ".png",
            ".psd",
            ".tga",
            ".tiff"
        };

        // ...
        public static List<string> SupportedFormats = new List<string>()
        {
            "Auto",
            "Bc1UNorm",
            "Bc1UNormSrgb",
            "Bc2UNorm",
            "Bc2UNormSrgb",
            "Bc3UNorm",
            "Bc3UNormSrgb",
            "Bc4UNorm",
            "Bc4Snorm",
            "Bc5UNorm",
            "Bc5Snorm",
            "Bc6UNorm",
            "Bc6Snorm",
            "Bc7UNorm",
            "Bc7UNormSrgb",
            "R32G32B32A32Float",
            "R32G32B32A32Uint",
            "R32G32B32A32Sint",
            "R32G32Float",
            "R32G32Uint",
            "R32G32Sint",
            "R32Float",
            "R32Uint",
            "R32Sint",
            "R16G16B16A16Float",
            "R16G16B16A16Uint",
            "R16G16B16A16Sint",
            "R16G16B16A16UNorm",
            "R16G16B16A16UBNorm",
            "R16G16B16A16UBNormNoZero",
            "R16G16B16A16UScaled",
            "R16G16B16A16SScaled",
            "R16G16B16A16UBInt",
            "R16G16B16A16UBScaled",
            "R16G16B16A16Snorm",
            "R16G16Float",
            "R16G16Uint",
            "R16G16Sint",
            "R16G16UNorm",
            "L16A16UNorm",
            "R16G16UBNorm",
            "R16G16UBNormNoZero",
            "R16G16UScaled",
            "R16G16SScaled",
            "R16G16UBInt",
            "R16G16UBScaled",
            "R16G16Snorm",
            "R16Float",
            "R16Uint",
            "R16Sint",
            "R16UNorm",
            "R16UBNorm",
            "R16UBNormNoZero",
            "R16UScaled",
            "R16SScaled",
            "R16UBInt",
            "R16UBScaled",
            "R16Snorm",
            "L16UNorm",
            "A16UNorm",
            "R8G8B8A8Uint",
            "R8G8B8A8Sint",
            "R8G8B8A8UNorm",
            "R8G8B8A8UNormSrgb",
            "R8G8B8A8UBNorm",
            "R8G8B8A8UBNormNoZero",
            "R8G8B8A8UScaled",
            "R8G8B8A8SScaled",
            "R8G8B8A8UBInt",
            "R8G8B8A8UBScaled",
            "R8G8B8A8Snorm",
            "R8G8Uint",
            "R8G8Sint",
            "R8G8UNorm",
            "R8G8UNormSrgb",
            "R8G8UBNorm",
            "R8G8UBNormNoZero",
            "R8G8UScaled",
            "R8G8SScaled",
            "R8G8UBInt",
            "R8G8UBScaled",
            "R8G8Snorm",
            "L8A8UNorm",
            "L8A8UNormSrgb",
            "R8Uint",
            "R8Sint",
            "R8UNorm",
            "R8UNormSrgb",
            "R8UBNorm",
            "R8UBNormNoZero",
            "R8UScaled",
            "R8SScaled",
            "R8UBInt",
            "R8UBScaled",
            "R8Snorm",
            "L8UNorm",
            "L8UNormSrgb",
            "A8UNorm",
            "B4G4R4A4UNorm",
            "B4G4R4X4UNorm",
            "B5G6R5UNorm",
            "B5G5R5A1UNorm",
            "B5G5R5X1UNorm",
            "R5G6B5UNorm",
            "B10G10R10A2UNorm",
            "R10G10B10A2UNorm",
            "B10G10R10A2Uint",
            "R10G10B10A2Uint",
            "R11G11B10Float",
            "R9G9B9E5Float",
            "R1Unorm",
            "L1Unorm",
            "A1Unorm",
            "R1Uint",
            "L1Uint",
            "A1Uint"
        };

        //
        public static string ExecutiablePath = SCEE.GetExecutablePath("orbis-image2gnf.exe");

        //
        public static string Format = "Auto";

        //
        public static Int32  Processed = 0;
        public static object ProcessedLock = new object();
        //

        //
        public static string GetTexureFormatFromDXGIFormat(DirectXTex.DirectXTexUtility.DXGIFormat format)
        {
            return SupportedFormats.Find(item => item.ToLower() == format.ToString().ToLower()) ?? "auto";
            
            /*
            switch (format)
            {
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32A32TYPELESS.to:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32A32FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32A32UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32A32SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32B32SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16B16A16SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G32SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32G8X24TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.D32FLOATS8X24UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32FLOATX8X24TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.X32TYPELESSG8X24UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R10G10B10A2TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R10G10B10A2UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R10G10B10A2UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R11G11B10FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8A8SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16G16SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.D32FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R32SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R24G8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.D24UNORMS8UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R24UNORMX8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.X24TYPELESSG8UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16FLOAT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.D16UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R16SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8UINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8SINT:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.A8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R1UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R9G9B9E5SHAREDEXP:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R8G8B8G8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.G8R8G8B8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC1TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC1UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC1UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC2TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC2UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC2UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC3TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC3UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC3UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC4TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC4UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC4SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC5TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC5UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC5SNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B5G6R5UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B5G5R5A1UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8A8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8X8UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.R10G10B10XRBIASA2UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8A8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8A8UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8X8TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B8G8R8X8UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC6HTYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC6HUF16:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC6HSF16:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC7TYPELESS:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC7UNORM:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.BC7UNORMSRGB:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.AYUV:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.Y410:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.Y416:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.NV12:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.P010:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.P016:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.OPAQUE420:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.YUY2:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.Y210:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.Y216:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.NV11:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.AI44:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.IA44:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.P8:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.A8P8:
                    return "auto";
                case DirectXTex.DirectXTexUtility.DXGIFormat.B4G4R4A4UNORM:
                    return "auto";
                default:
                    return "auto";
                }
                */
        }

        public static void blah()
        {
            //
            // string scannedFormat = Format;
            // if (scannedFormat == string.Empty)
            // {
            //     if (Settings.Global.LogThreadOutput)
            //     {
            //         tisw.WriteLine($"Atempting to convert {input}, format used is {Format}");
            //     }
            // }
            // else
            // {
            //     if (Settings.Global.LogThreadOutput)
            //     {
            //         tisw.WriteLine($"Atempting to convert {input}, format used is {scannedFormat}");
            //     }
            // }
            // 
            // if (Settings.Global.ScanTextureForFormat)
            // {
            //     DirectXTex.DirectXTexUtility.DDSHeader header = new DirectXTex.DirectXTexUtility.DDSHeader();
            //     DirectXTex.DirectXTexUtility.DX10Header header10 = new DirectXTex.DirectXTexUtility.DX10Header();
            // 
            //     // DXT10 textures only.
            //     DirectXTex.DirectXTexUtility.ReadDDSHeader(input, ref header, ref header10);
            //     if (header.PixelFormat.FourCC == 0x30315844)
            //     {
            //         scannedFormat = GetTexureFormatFromDXGIFormat(header10.Format);
            //         args += $"-f {scannedFormat} ";
            //     }
            //     else // non dxt10-texture.
            //     {
            //         args += $"-f {Format} ";
            //     }
            // }
            // else
            // {
            //     args += $"-f {Format} ";
            // }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ProcessExitedEventCallback(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Spawns a Process that starts orbis-image2gnf.exe with provided args and waits for a return.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="args"></param>
        public static void Spawn(List<string> ListToProcess, Int32 ThreadID)
        {
            StreamWriter tisw = null;

            if (Settings.Global.LogThreadOutput)
            {
                tisw = new StreamWriter(File.Open($"Data/Thread Log({ThreadID}).txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
                tisw.WriteLine($"----------Start Of Debug Log----------");
                tisw.WriteLine($"ThreadID: {ThreadID}");

                //
                foreach (string file in ListToProcess)
                {
                    //
                    tisw.WriteLine($"File: {file}");
                }
            }

            foreach (string file in ListToProcess)
            {
                // vars.
                long    startTime = DateTimeOffset.Now.ToUnixTimeSeconds();
                string  input = file;
                string  args = $"-f {Format} ";
                string  extension = Path.GetExtension(file);
                string  output = file.Replace(extension, ".gnf");
                string  log = file.Replace(extension, ".log");

                //
                if (Settings.Global.DisableMipMaps)
                {
                    args += $"--nomips ";
                }

                if (Settings.Global.LogThreadOutput)
                {
                    tisw.WriteLine($"Processing {input}, format used is {Format}");
                }

                using (Process process = new Process())
                {
                    //
                    process.StartInfo.FileName = ExecutiablePath;
                    process.StartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "Data");
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.Arguments = $"-i \"{input}\" -o \"{output}\" {args}";

                    if (Settings.Global.LogProcessOutput)
                    {
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                    }

                    process.Start();
                    process.PriorityClass = ProcessPriorityClass.High;
                    process.WaitForExit();

                    if (Settings.Global.LogProcessOutput)
                    {
                        using (StreamWriter sw = new StreamWriter(File.Open(log, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)))
                        {
                            sw.WriteLine(process.StandardOutput.ReadToEnd());
                        }
                    }

                    //
                    if (Settings.Global.BackUpOrginalTexture)
                    {
                        File.Move(input, input + ".bak");
                    }
                    else
                    {
                        File.Delete(input);
                    }

                    if (!Settings.Global.KeepGNFExtestion)
                    {
                        //
                        File.Move(output, input);
                    }
                }

                var endTime = DateTimeOffset.Now.ToUnixTimeSeconds();

                if (Settings.Global.LogThreadOutput)
                {
                    tisw.WriteLine($"Processing {input} took {endTime - startTime}s");
                }

                //
                lock(ProcessedLock)
                {
                    Processed++;
                }
            }

            if (Settings.Global.LogThreadOutput)
            {
                //
                tisw.WriteLine($"----------End Of Debug Log----------");
                tisw.Close();
            }
        }
    }
}
