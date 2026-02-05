using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public class MdiChildBoundedForm : Form
    {

    
            private const int WM_MOVING = 0x0216;

            [StructLayout(LayoutKind.Sequential)]
            private struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_MOVING && this.MdiParent != null)
                {
                    RECT rect = Marshal.PtrToStructure<RECT>(m.LParam);

                    MdiClient mdiClient = this.MdiParent.Controls
                        .OfType<MdiClient>()
                        .FirstOrDefault();

                    if (mdiClient != null)
                    {
                        // MdiClient bounds in SCHERMCOÖRDINATEN
                        Rectangle mdiBounds =
                            mdiClient.RectangleToScreen(mdiClient.ClientRectangle);

                        int width = rect.Right - rect.Left;
                        int height = rect.Bottom - rect.Top;

                        // Links
                        if (rect.Left < mdiBounds.Left)
                        {
                            rect.Left = mdiBounds.Left;
                            rect.Right = rect.Left + width;
                        }

                        // Boven (menu + toolstrip correct meegenomen)
                        if (rect.Top < mdiBounds.Top)
                        {
                            rect.Top = mdiBounds.Top;
                            rect.Bottom = rect.Top + height;
                        }

                        // Rechts
                        if (rect.Right > mdiBounds.Right)
                        {
                            rect.Right = mdiBounds.Right;
                            rect.Left = rect.Right - width;
                        }

                        // Onder (statusstrip inbegrepen)
                        if (rect.Bottom > mdiBounds.Bottom)
                        {
                            rect.Bottom = mdiBounds.Bottom;
                            rect.Top = rect.Bottom - height;
                        }

                        Marshal.StructureToPtr(rect, m.LParam, true);
                    }
                }

                base.WndProc(ref m);
            }
        }
    }

