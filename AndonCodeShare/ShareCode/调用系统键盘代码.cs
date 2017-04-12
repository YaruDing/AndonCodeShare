#region µ÷³öÐ¡¼üÅÌ
private const Int32 WM_SYSCOMMAND = 274;
private const UInt32 SC_CLOSE = 61536;
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
private static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
private static extern bool PostMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
private static extern int RegisterWindowMessage(string lpString);



//ÏÔÊ¾ÆÁÄ»¼üÅÌ
public void ShowInputPanel()
{
	try
	{
		dynamic file = "C:\\Program Files\\Common Files\\microsoft shared\\ink\\TabTip.exe";
		if (!System.IO.File.Exists(file))
			return;
		Process.Start(file);
	}
	catch (Exception)
	{

	}
}

//Òþ²ØÆÁÄ»¼üÅÌ
public void HideInputPanel()
{
	IntPtr TouchhWnd = new IntPtr(0);
	TouchhWnd = FindWindow("IPTip_Main_Window", null);
	if (TouchhWnd == IntPtr.Zero)
		return;
	PostMessage(TouchhWnd, WM_SYSCOMMAND, SC_CLOSE, 0);
}
#endregion