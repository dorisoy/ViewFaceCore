﻿using SkiaSharp;
using System.Runtime.InteropServices;

namespace ViewFaceCore.Extension.SkiaSharp
{
    internal static class BitmapExtension
    {
        /// <summary>
        /// <see cref="Bitmap"/> 转为 3*8bit BGR <see cref="byte"/> 数组。
        /// </summary>
        /// <param name="bitmap">待转换图像</param>
        /// <param name="width">图像宽度</param>
        /// <param name="height">图像高度</param>
        /// <param name="channels">图像通道</param>
        /// <returns>图像的 BGR <see cref="byte"/> 数组</returns>
        public static byte[] To24BGRByteArray(this SKBitmap bitmap, out int width, out int height, out int channels)
        {
            width = bitmap.Width;
            height = bitmap.Height;
            channels = 3;
            byte[] array = bitmap.Bytes;
            byte[] bgra = new byte[array.Length / 4 * channels];
            // brga
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i + 1) % 4 == 0) continue;
                bgra[j] = array[i];
                j++;
            }
            return bgra;
        }
    }
}