using NppPluginNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Houssam_Plugin.Forms
{
    public partial class FrmInput : Form
    {
        public string TheValue = "";
        public bool IsOK = false;
        public FrmInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //IsOK = true;
            TheValue = txtTag.Text;
            if (tabControl.SelectedIndex == 0)
            {
                Do_Surround_With_Html_Tag();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                Do_Replace_Text();
            }
        }
        StringBuilder GetSelectedTextFromEditor()
        {
            int selectionLength = (int)Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, 0);
            StringBuilder inputText = new StringBuilder(selectionLength);
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, inputText);
            return inputText;

        }
        void Do_Surround_With_Html_Tag()
        {
            string outputStrin = string.Empty;
            string the_val = txtTag.Text;
            if (!string.IsNullOrEmpty(the_val))
            {

                string myInput = GetSelectedTextFromEditor().ToString();
                string[] ar = the_val.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                bool IsOnce = rbOnlyOne.Checked;
                if (IsOnce)
                {
                    for (int i = ar.Length - 1; i >= 0; i--)
                    {
                        myInput = "<" + ar[i] + ">" + myInput + "</" + ar[i] + ">";
                    }
                    outputStrin = myInput;
                }
                else
                {
                    string[] lines = myInput.Split(new string[] { "\r", "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    StringBuilder new_text_final = new StringBuilder();
                    foreach (string line in lines)
                    {
                        String new_line = line;
                        for (int i = ar.Length - 1; i >= 0; i--)
                        {
                            new_line = "<" + ar[i] + ">" + new_line + "</" + ar[i] + ">";
                        }
                        new_text_final.AppendLine(new_line);
                    }
                    outputStrin = new_text_final.ToString();
                }
                Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_REPLACESEL, 0, outputStrin);
            }
            Hide();
        }
        void Do_Replace_Text()
        {
            string textAnchor = txtAnchor.Text;
            string txtFromEditor = GetSelectedTextFromEditor().ToString();
            string sToBeReplaceIn = txtReplace.Text;
            string outputStrin = string.Empty;
            //string[] ar = the_val.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            bool IsOnce = rbOnlyOnce_replace.Checked;
            if (IsOnce)
            {
                outputStrin = sToBeReplaceIn.Replace(textAnchor, txtFromEditor);
            }
            else
            {
                string[] lines = txtFromEditor.Split(new string[] { "\r", "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder new_text_final = new StringBuilder();
                foreach (string line in lines)
                {
                    new_text_final.AppendLine(sToBeReplaceIn.Replace(textAnchor, line));
                }
                outputStrin = new_text_final.ToString();
            }
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_REPLACESEL, 0, outputStrin);
            Hide();

        }
        private void FrmInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {

        }

        private void FrmInput_Activated(object sender, EventArgs e)
        {
            txtTag.SelectAll();
            txtTag.Focus();
        }

        private void txtTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);

        }
    }
}
