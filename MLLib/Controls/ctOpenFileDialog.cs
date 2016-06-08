using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Controls
{
    public partial class ctOpenFileDialog : UserControl
    {
        OpenFileDialog openfile;
        public ctOpenFileDialog()
        {
            InitializeComponent();
            openfile = new OpenFileDialog();
        }

        public string FilterText
        {
            get
            {
                return openfile.Filter;
            }
            set
            {
                openfile.Filter = value;
            }
        }

        public string DialogTitle
        {
            get
            {
                return openfile.Title;
            }
            set
            {
                openfile.Title = value;
            }
        }

        public bool FileNameReadOnly
        {
            get
            {
                return !txtFile.Enabled;
            }
            set
            {
                txtFile.Enabled = !value;
            }
        }

        public Color FileNameBackColor
        {
            get
            {
                return txtFile.BackColor;
            }
            set
            {
                txtFile.BackColor = value;
            }

        }


        public string Value
        {
            get
            {
                return txtFile.Text;
            }
            set
            {
                txtFile.Text = value;
            }
        }

        public enum TypeControl
        {
            SelectFile,
            SelectFolder
        }

        TypeControl type = TypeControl.SelectFile;
        public TypeControl Type
        {
            get
            {
                return type;
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                    txtFile.Text = "";
                    Value = "";
                }
            }
        }


        private void btnBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;
            FolderBrowserDialog folder = null;
            switch (type)
            {
                case TypeControl.SelectFile:
                    result = openfile.ShowDialog();
                    break;
                case TypeControl.SelectFolder:
                    folder = new FolderBrowserDialog();
                    folder.SelectedPath = txtFile.Text;
                    result = folder.ShowDialog();
                    break;
            }
            if (result == DialogResult.OK)
            {
                switch (type)
                {
                    case TypeControl.SelectFile:
                        Value = openfile.FileName;
                        break;
                    case TypeControl.SelectFolder:
                        Value = folder.SelectedPath;
                        break;
                }
                if (BrowserButtonClickOK != null)
                    BrowserButtonClickOK(this, e);
            }
            else
            {
                if (BrowserButtonClickCancel != null)
                    BrowserButtonClickCancel(this, e);
            }
        }

        public String BrowserButtonText
        {
            get
            {
                return btnBrowser.Text;
            }
            set
            {
                btnBrowser.Text = value;
            }
        }
        public Color BrowserButtonBackColor
        {
            get
            {
                return btnBrowser.ButtonBackgroundColor;
            }
            set
            {
                btnBrowser.ButtonBackgroundColor = value;
            }

        }


        public String LabelText
        {
            get
            {
                return txtFile.TextHint;
            }
            set
            {
                txtFile.TextHint = value;
            }
        }

        public int LabelTextWidth
        {
            get
            {
                return txtFile.TextHintWidth;
            }
            set
            {
                txtFile.TextHintWidth = value;
            }
        }

        public Color LabelTextColor
        {
            get
            {
                return txtFile.TextHintColor;
            }
            set
            {
                txtFile.TextHintColor = value;
            }
        }

        public int BrowserButtonWidth
        {
            get
            {
                return btnBrowser.Width;
            }
            set
            {
                btnBrowser.Width = value;
            }
        }

        public event EventHandler BrowserButtonClickOK;
        public event EventHandler BrowserButtonClickCancel;


    }
}
