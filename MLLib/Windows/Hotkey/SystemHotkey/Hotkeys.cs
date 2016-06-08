using MLLib.Windows.Hotkey.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MLLib.Windows.Hotkey
{
    public class Hotkeys : Component, IDisposable
    {
        private Container components;
        protected bool isRegistered;
        protected System.Windows.Forms.Shortcut m_HotKey;
        protected DummyWindowWithEvent m_Window;

        public event EventHandler Error;

        public event EventHandler Pressed;

        public Hotkeys()
        {
            this.components = null;
            this.m_Window = new DummyWindowWithEvent();
            this.m_HotKey = System.Windows.Forms.Shortcut.None;
            this.isRegistered = false;
            this.InitializeComponent();
            if (!base.DesignMode)
            {
                this.m_Window.ProcessMessage += new MessageEventHandler(this.MessageEvent);
            }
        }

        public Hotkeys(IContainer container)
        {
            this.components = null;
            this.m_Window = new DummyWindowWithEvent();
            this.m_HotKey = System.Windows.Forms.Shortcut.None;
            this.isRegistered = false;
            container.Add(this);
            this.InitializeComponent();
            this.m_Window.ProcessMessage += new MessageEventHandler(this.MessageEvent);
        }

        public void Dispose()
        {
            if (this.isRegistered && this.UnregisterHotkey())
            {
                Debug.WriteLine("Unreg: OK");
            }
            Debug.WriteLine("Disposed");
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        protected void MessageEvent(object sender, ref Message m, ref bool Handled)
        {
            if ((m.Msg == 0x312) && (m.WParam == ((IntPtr)base.GetType().GetHashCode())))
            {
                Handled = true;
                Debug.WriteLine("HOTKEY pressed!");
                if (this.Pressed != null)
                {
                    this.Pressed(this, EventArgs.Empty);
                }
            }
        }

        protected bool RegisterHotkey(System.Windows.Forms.Shortcut key)
        {
            int fsModifiers = 0;
            Keys none = Keys.None;
            if ((key & ((System.Windows.Forms.Shortcut)0x40000)) == ((System.Windows.Forms.Shortcut)0x40000))
            {
                fsModifiers++;
                none = Keys.Alt;
            }
            if ((key & ((System.Windows.Forms.Shortcut)0x10000)) == ((System.Windows.Forms.Shortcut)0x10000))
            {
                fsModifiers += 4;
                none = Keys.Shift;
            }
            if ((key & ((System.Windows.Forms.Shortcut)0x20000)) == ((System.Windows.Forms.Shortcut)0x20000))
            {
                fsModifiers += 2;
                none = Keys.Control;
            }
            Debug.Write(fsModifiers.ToString() + " ");
            Debug.WriteLine(((int)(key - ((System.Windows.Forms.Shortcut)((int)none)))).ToString());
            return User32.RegisterHotKey(this.m_Window.Handle, base.GetType().GetHashCode(), fsModifiers, (int)(key - ((System.Windows.Forms.Shortcut)((int)none))));
        }

        protected bool UnregisterHotkey()
        {
            return User32.UnregisterHotKey(this.m_Window.Handle, base.GetType().GetHashCode());
        }

        public bool IsRegistered
        {
            get
            {
                return this.isRegistered;
            }
        }

        [DefaultValue(0)]
        public System.Windows.Forms.Shortcut Shortcut
        {
            get
            {
                return this.m_HotKey;
            }
            set
            {
                if (base.DesignMode)
                {
                    this.m_HotKey = value;
                }
                else
                {
                    if (this.isRegistered && (this.m_HotKey != value))
                    {
                        if (this.UnregisterHotkey())
                        {
                            Debug.WriteLine("Unreg: OK");
                            this.isRegistered = false;
                        }
                        else
                        {
                            if (this.Error != null)
                            {
                                this.Error(this, EventArgs.Empty);
                            }
                            Debug.WriteLine("Unreg: ERR");
                        }
                    }
                    if (value == System.Windows.Forms.Shortcut.None)
                    {
                        this.m_HotKey = value;
                    }
                    else
                    {
                        if (this.RegisterHotkey(value))
                        {
                            Debug.WriteLine("Reg: OK");
                            this.isRegistered = true;
                        }
                        else
                        {
                            if (this.Error != null)
                            {
                                this.Error(this, EventArgs.Empty);
                            }
                            Debug.WriteLine("Reg: ERR");
                        }
                        this.m_HotKey = value;
                    }
                }
            }
        }
    }
}

