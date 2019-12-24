using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NppPluginNET;
using System.Threading;
using System.Runtime.InteropServices;
using Houssam_Plugin.Forms;

namespace Houssam_Plugin
{
    class Main
    {

        internal const string PluginName = "Houssam Plugin";
        static FrmInput frmInput;
        //static string iniFilePath = null;
        //static bool someSetting = false;





        internal static void CommandMenuInit()
        {
            //PluginBase.SetCommand(0, "Remove duplicate lines", Selection, new ShortcutKey(false, false, false, Keys.None));
            PluginBase.SetCommand(0, "Houssam Plugin", Houssam_Plugin_Func, new ShortcutKey(false, false, false, Keys.None));
        }
        internal static void SetToolBarIcon()
        {

        }
        internal static void PluginCleanUp()
        {
            //Win32.WritePrivateProfileString("SomeSection", "SomeKey", someSetting ? "1" : "0", iniFilePath);
        }



        public static void Houssam_Plugin_Func()
        {
            try
            {
                if (frmInput == null) frmInput = new FrmInput();
                frmInput.IsOK = false;
                frmInput.Show();
                //NppTbData _nppTbData = new NppTbData();
                //_nppTbData.hClient = frm.Handle;
                //_nppTbData.pszName = "Go To Line #";
                //_nppTbData.dlgID = 15;

                //_nppTbData.uMask = NppTbMsg.DWS_DF_CONT_RIGHT | NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;
                //_nppTbData.hIconTab = (uint)tbIcon.Handle;
                //_nppTbData.pszModuleName = PluginName;
                //IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
                //Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

                //Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);
                // Following message will toogle both menu item state and toolbar button
                //Win32.SendMessage(PluginBase.nppData._nppHandle, (uint)NppMsg.NPPM_SETMENUITEMCHECK, PluginBase._funcItems.Items[idFrmGotToLine]._cmdID, 1);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            /*frm.Show();
                       */
        }
        static void MyThreadMethod()
        {

        }
        internal static void Selection()
        {
            int selectionLength = (int)Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, 0);
            StringBuilder inputText = new StringBuilder(selectionLength);
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETSELTEXT, 0, inputText);

            if (string.IsNullOrEmpty(inputText.ToString()))
            {
                MessageBox.Show("please select lines first");
                return;
            }
            try
            {
                string original = inputText.ToString();
                string outputString;
                using (StringReader reader = new StringReader(original)) // code from https://stackoverflow.com/questions/2865863/removing-all-whitespace-lines-from-a-multi-line-string-efficiently
                using (StringWriter writer = new StringWriter())
                {
                    string line;
                    int x = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        x += 1;
                        if (string.IsNullOrEmpty(line.Trim()))
                        {
                            line = Regex.Replace(line, "$", "3f5456cfsd661lld33Guid9CA0F324-3E3A-4C43-8AGu989CAACD-3BD6-499D-8664-41CE47622FE25E1E7C8FF3Guid9CA0F324-3E3A-4C43-8A22-308B5E1E7C8FA-4C43-8A22-308B5E1E7CGuid9CA0F324-3E3A-4C43-8A22-308B5E1E7C8F" + x);
                        }
                        writer.WriteLine(line);
                    }
                    outputString = writer.ToString();
                }

                string[] distinctLines = outputString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).Distinct().ToArray();
                string outputStrin;
                string s = string.Join("\r\n", distinctLines);
                using (StringReader readerr = new StringReader(s)) // code from https://stackoverflow.com/questions/2865863/removing-all-whitespace-lines-from-a-multi-line-string-efficiently
                using (StringWriter writerr = new StringWriter())
                {
                    string linek;
                    while ((linek = readerr.ReadLine()) != null)
                    {
                        string uu = Regex.Replace(linek, "3f5456cfsd661lld33Guid9CA0F324-3E3A-4C43-8AGu989CAACD-3BD6-499D-8664-41CE47622FE25E1E7C8FF3Guid9CA0F324-3E3A-4C43-8A22-308B5E1E7C8FA-4C43-8A22-308B5E1E7CGuid9CA0F324-3E3A-4C43-8A22-308B5E1E7C8F.*$", "");
                        writerr.WriteLine(uu);
                    }
                    outputStrin = writerr.ToString();
                    outputStrin = outputStrin.Substring(0, outputStrin.LastIndexOf(Environment.NewLine));
                }
                if (inputText.ToString() == outputStrin)
                {

                    Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_CLEARSELECTIONS, 0, 0);
                    return;
                }
                Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_REPLACESEL, 0, outputStrin);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error. " + exp.Message);
            }
        }

    }
}