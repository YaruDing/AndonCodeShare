See the end of this message for details on invoking 
just-in-time (JIT) debugging instead of this dialog box.

************** Exception Text **************
System.Net.Sockets.SocketException (0x80004005): 由于目标主机坏了，套接字操作失败。
   at EASendMail.SmtpClient.7j(String 5P, Boolean 5P, Boolean 5P, Boolean 5P)
   at EASendMail.SmtpClient.72(Int32& 5P, String& 5P, Boolean 5P)
   at EASendMail.SmtpClient.2\(SmtpServer 5P, SocksProxyProtocol 5P, Boolean 5P, Boolean 5P)
   at EASendMail.SmtpClient.17(SmtpServer 5P, SocksProxyProtocol 5P)
   at EASendMail.SmtpClient.Connect(SmtpServer server)
   at EASendMail.SmtpClient.SendMail(SmtpServer server, SmtpMail mail)
   at WeiXinSystemV1.TestForm.button2_Click(Object sender, EventArgs e) in F:\yaruding\WXTest\WeiXinSystemV1\WeiXinSystemV1\TestForm.cs:line 130
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)


************** Loaded Assemblies **************
mscorlib
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.NET/Framework/v4.0.30128/mscorlib.dll
----------------------------------------
AndonWeChat
    Assembly Version: 1.0.0.0
    Win32 Version: 1.0.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/AndonWeChat.exe
----------------------------------------
System.Windows.Forms
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Windows.Forms/v4.0_4.0.0.0__b77a5c561934e089/System.Windows.Forms.dll
----------------------------------------
System.Drawing
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Drawing/v4.0_4.0.0.0__b03f5f7f11d50a3a/System.Drawing.dll
----------------------------------------
System
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System/v4.0_4.0.0.0__b77a5c561934e089/System.dll
----------------------------------------
AndonSys.Common
    Assembly Version: 1.0.0.0
    Win32 Version: 1.0.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/AndonSys.Common.DLL
----------------------------------------
System.Xml
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Xml/v4.0_4.0.0.0__b77a5c561934e089/System.Xml.dll
----------------------------------------
System.Configuration
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Configuration/v4.0_4.0.0.0__b03f5f7f11d50a3a/System.Configuration.dll
----------------------------------------
id0sfazb
    Assembly Version: 1.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System/v4.0_4.0.0.0__b77a5c561934e089/System.dll
----------------------------------------
WXDCommon
    Assembly Version: 1.0.0.0
    Win32 Version: 1.0.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/WXDCommon.DLL
----------------------------------------
System.Data
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_32/System.Data/v4.0_4.0.0.0__b77a5c561934e089/System.Data.dll
----------------------------------------
System.Core
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Core/v4.0_4.0.0.0__b77a5c561934e089/System.Core.dll
----------------------------------------
WXModel
    Assembly Version: 1.0.0.0
    Win32 Version: 1.0.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/WXModel.DLL
----------------------------------------
WeiXinInterfaceV1
    Assembly Version: 1.0.0.0
    Win32 Version: 1.0.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/WeiXinInterfaceV1.DLL
----------------------------------------
System.Numerics
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 built by: RC1Rel
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_MSIL/System.Numerics/v4.0_4.0.0.0__b77a5c561934e089/System.Numerics.dll
----------------------------------------
System.Data.OracleClient
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_32/System.Data.OracleClient/v4.0_4.0.0.0__b77a5c561934e089/System.Data.OracleClient.dll
----------------------------------------
System.Transactions
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_32/System.Transactions/v4.0_4.0.0.0__b77a5c561934e089/System.Transactions.dll
----------------------------------------
System.EnterpriseServices
    Assembly Version: 4.0.0.0
    Win32 Version: 4.0.30128.1 (RC1Rel.030128-0100)
    CodeBase: file:///C:/Windows/Microsoft.Net/assembly/GAC_32/System.EnterpriseServices/v4.0_4.0.0.0__b03f5f7f11d50a3a/System.EnterpriseServices.dll
----------------------------------------
Newtonsoft.Json.Net20
    Assembly Version: 3.5.0.0
    Win32 Version: 3.5.0.0
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/Newtonsoft.Json.Net20.DLL
----------------------------------------
EASendMail40
    Assembly Version: 7.3.0.6
    Win32 Version: 7.3.0.6
    CodeBase: file:///C:/Users/yaru.ding/Desktop/Debug/EASendMail40.DLL
----------------------------------------

************** JIT Debugging **************
To enable just-in-time (JIT) debugging, the .config file for this
application or computer (machine.config) must have the
jitDebugging value set in the system.windows.forms section.
The application must also be compiled with debugging
enabled.

For example:

<configuration>
    <system.windows.forms jitDebugging="true" />
</configuration>

When JIT debugging is enabled, any unhandled exception
will be sent to the JIT debugger registered on the computer
rather than be handled by this dialog box.
