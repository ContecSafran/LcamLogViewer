using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Contec_MCS.Util
{
    public class CTWin32API
    {
        public const Int32 WM_COPYDATA = 0x004A;
        public const Int32 WM_CLOSEMESSAGE = 0x004B;
        public const Int32 WM_GECAPTURE_RESULT = 0x004C;
        public const Int32 WM_XLSFILESAVE = 0x0050;
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            public IntPtr lpData;
        }
        public struct COPYDATASTRUCTSTR
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, ref CTWin32API.COPYDATASTRUCT lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, ref CTWin32API.COPYDATASTRUCTSTR lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, StringBuilder lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(HandleRef hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

    }
}
