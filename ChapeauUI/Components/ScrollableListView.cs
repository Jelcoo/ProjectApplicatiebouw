using System;
using System.Windows.Forms;

public class ScrollableListView : ListView
{
    private const int WM_VSCROLL = 0x0115;
    private const int WM_HSCROLL = 0x0114;
    private const int WM_MOUSEWHEEL = 0x020A;

    public event ScrollEventHandler Scroll;
    public event MouseEventHandler MouseScroll;

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == WM_VSCROLL || m.Msg == WM_HSCROLL)
        {
            OnScroll(new ScrollEventArgs((ScrollEventType)(m.WParam.ToInt32() & 0xffff), 0));
        }
        else if (m.Msg == WM_MOUSEWHEEL)
        {
            OnMouseScroll(new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0));
        }
    }

    protected virtual void OnScroll(ScrollEventArgs e)
    {
        Scroll?.Invoke(this, e);
    }

    protected virtual void OnMouseScroll(MouseEventArgs e)
    {
        MouseScroll?.Invoke(this, e);
    }
}
