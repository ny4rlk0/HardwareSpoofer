using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace p
{
    public partial class Form1 : Form
    {
        List<string> s = new List<string>();
        List<string> l7512 = new List<string>();
        Random r = new Random();
        static bool d = false, y=true;int g = 0;
        static string mg = "";
        string u = "M", e = "C", v = "E", b = "D", j = "X",m=".",t="/",k=" ";bool cb = d;
        string l1 = "z", l38 = "y", l854 = "v", l21 = "x", l293 = "w", l231 = "ü", l123 = "u", l32 = "t", l27 = "ş", l22 = "r", l36 = "ö", l58 = "o", l23 = "n", l259 = "m", l385 = "l", l463 = "k", ll453 = "j", l0 = "i", l933 = "ı", l128 = "h", l5320 = "g", l192 = "f", l723 = "e", l2495 = "d", l238 = "ç", l333 = "c", l444 = "b", l756 = "a", l3432 = ".", l5567 = "/", l5568 = "\\", l2277 = "'", l2278 = "\"", l949 = "&&", l630 = " ", l631 = "+", l632 = ";", l101 = "p", l102 = "s", l103 = "%", l9999 = "*", l3263 = "q", l00 = "0", l01 = "1", l02 = "2", l03 = "3", l04 = "4", l05 = "5", l06 = "6", l07 = "7", l08 = "8", l09 = "9", l241 = "(", l653 = ")", l341 = "-", l527 = "_", l97 = "[", l96 = "]", l95 = ":",l94="=", l93 = ">", l92 = "<", l91 = "#", l90 = ",", l89 = "S", l88 = "I", l87 = "D", l86 = "|", l85 = "$",l79="X";
        public Form1(){InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
            call_me_your_manager();
            tr();
            this.
            FormBorderStyle
            = System.
            Windows.Forms.
            FormBorderStyle.
            None;rf();
            this.
            Invoke(
            (MethodInvoker)
            delegate {
            bl();  
            });if 
            (s.Count != 
            g && s 
            != null 
            && !cb
            ){
                Thread w = new Thread(()=>h(s[g]));w.IsBackground=y;w.Start();
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e){rf();}
        private void rb()
        {rb2();rb3();}
        private void rb2(){this.BackColor = rc();}
        private void rb3(){ this.ForeColor = rc();}
        private void cmg()
        {
            try
            {
            this.Invoke((MethodInvoker)delegate {
                string s99 = gg();
                string xd = k9();
                using (RegistryKey s9999 = Registry.LocalMachine.OpenSubKey(l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l333 + l22 + l38 + l101 + l32 + l58 + l5320 + l22 + l756 + l101 + l128 + l38, y))
                {
                    s9999.SetValue(l259 + l756 + l333 + l128 + l0 + l23 + l723 + l5320 + l123 + l0 + l2495, s99, RegistryValueKind.String);
                }
                using (RegistryKey s9999 = Registry.CurrentUser.OpenSubKey(l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l58 + l23 + l723 + l2495 + l22 + l0 + l854 + l723, y))
                {
                    s9999.SetValue(l259 + l756 + l333 + l128 + l0 + l23 + l723 + l5320 + l123 + l0 + l2495 + l333 + l58 + l385 + l385 + l723 + l333 + l32 + l0 + l58 + l23, s99, RegistryValueKind.String);
                }
                using (RegistryKey s9999 = Registry.Users.OpenSubKey(l3432 + l2495 + l723 + l192 + l756 + l123 + l385 + l32 + l5568 + l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l58 + l23 + l723 + l2495 + l22 + l0 + l854 + l723, y))
                {
                    s9999.SetValue(l259 + l756 + l333 + l128 + l0 + l23 + l723 + l5320 + l123 + l0 + l2495 + l333 + l58 + l385 + l385 + l723 + l333 + l32 + l0 + l58 + l23, s99, RegistryValueKind.String);
                }
                using (RegistryKey s9999 = Registry.Users.OpenSubKey(l102 + l341 + l01 + l341 + l05 + l341 + l01 + l08 + l5568 + l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l58 + l23 + l723 + l2495 + l22 + l0 + l854 + l723, y))
                {
                    s9999.SetValue(l259 + l756 + l333 + l128 + l0 + l23 + l723 + l5320 + l123 + l0 + l2495 + l333 + l58 + l385 + l385 + l723 + l333 + l32 + l0 + l58 + l23, s99, RegistryValueKind.String);
                }
                using (RegistryKey s9999 = Registry.Users.OpenSubKey(xd + l5568 + l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l58 + l23 + l723 + l2495 + l22 + l0 + l854 + l723, y))
                {
                    s9999.SetValue(l259 + l756 + l333 + l128 + l0 + l23 + l723 + l5320 + l123 + l0 + l2495 + l333 + l58 + l385 + l385 + l723 + l333 + l32 + l0 + l58 + l23, s99, RegistryValueKind.String);
                }
                try { Clipboard.Clear(); } catch (Exception) { }
            });



            }
            catch (Exception)
            {
            }

        }
        private string gg()
        {
            ProcessStartInfo n99 = new ProcessStartInfo
            {
                FileName = l101 + l58 + l293 + l723 + l22 + l102 + l128 + l723 + l385 + l385 + l3432 + l723 + l21 + l723,
                Arguments = l341 + l23 + l58 + l101 + l22 + l58 + l192 + l0 + l385 + l723 + l630 + l341 + l723 + l21 + l723 + l333 + l123 + l32 + l0 + l58 + l23 + l101 + l58 + l385 + l0 + l333 + l38 + l630 + l444 + l38 + l101 + l756 + l102 + l102 + l630 + l341 + l333 + l58 + l259 + l259 + l756 + l23 + l2495 + l630 + l2278 + l97 + l5320 + l123 + l0 + l2495 + l96 + l95 + l95 + l23 + l723 + l293 + l5320 + l123 + l0 + l2495 + l241 + l653 + l3432 + l32 + l58 + l102 + l32 + l22 + l0 + l23 + l5320 + l241 + l653 + l2278,
                RedirectStandardOutput = y,
                UseShellExecute = d,
                CreateNoWindow = y
            };
            using (Process n9 = new Process { StartInfo = n99 })
            {
                n9.Start();
                string m56 = n9.StandardOutput.ReadToEnd();
                n9.WaitForExit();
                return m56.Trim();
            }
        }
        private string k9()
        {
            ProcessStartInfo zu = new ProcessStartInfo
            {
                FileName = l101 + l58 + l293 + l723 + l22 + l102 + l128 + l723 + l385 + l385 + l3432 + l723 + l21 + l723,
                Arguments = l341 + l23 + l58 + l101 + l22 + l58 + l192 + l0 + l385 + l723 + l630 + l341 + l723 + l21 + l723 + l333 + l123 + l32 + l0 + l58 + l23 + l101 + l58 + l385 + l0 + l333 + l38 + l630 + l444 + l38 + l101 + l756 + l102 + l102 + l630 + l341 + l333 + l58 + l259 + l259 + l756 + l23 + l2495 + l630 + l2278 + l241 + l5320 + l723 + l32 + l341 + l385 + l58 + l333 + l756 + l385 + l123 + l102 + l723 + l22 + l630 + l341 + l23 + l756 + l259 + l723 + l630 + l85 + l723 + l23 + l854 + l95 + l123 + l102 + l723 + l22 + l23 + l756 + l259 + l723 + l630 + l86 + l630 + l102 + l723 + l385 + l723 + l333 + l32 + l341 + l58 + l444 + ll453 + l723 + l333 + l32 + l630 + l102 + l0 + l2495 + l630 + l86 + l630 + l192 + l58 + l22 + l259 + l756 + l32 + l341 + l385 + l0 + l102 + l32 + l630 + l86 + l630 + l58 + l123 + l32 + l341 + l102 + l32 + l22 + l0 + l23 + l5320 + l653 + l3432 + l22 + l723 + l101 + l385 + l756 + l333 + l723 + l241 + l2277 + l89 + l88 + l87 + l630 + l95 + l2277 + l90 + l2277 + l2277 + l653 + l2278,
                RedirectStandardOutput = y,
                UseShellExecute = d,
                CreateNoWindow = y
            };
            using (Process t3n = new Process { StartInfo = zu })
            {
                t3n.Start();
                string Drive_Forever = t3n.StandardOutput.ReadToEnd();
                t3n.WaitForExit();
                return Drive_Forever.Trim();
            }
        }
        private void bl()
        {
            //lets goo https://i.imgflip.com/6g0iyt.jpg
            this.
            Invoke(
            (MethodInvoker)
            delegate { /* https://youtu.be/dj4qmmkiZyU?si=gQZNUBFBloLf-F4O&t=39 */
                s.Add(l102 + l333 + l630 + l102 + l32 + l58 + l101 + l630 + l854 + l5320 + l333);
                s.Add(l102 + l333 + l630 + l102 + l32 + l58 + l101 + l630 + l854 + l5320 + l463);
                s.Add(l102 + l333 + l630 + l2495 + l723 + l385 + l723 + l32 + l723 + l630 + l854 + l5320 + l333);
                s.Add(l102 + l333 + l630 + l2495 + l723 + l385 + l723 + l32 + l723 + l630 + l854 + l5320 + l463);
                
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l0 + l23 + l102 + l32 + l756 + l385 + l385 + l723 + l22 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l385 + l58 + l5320 + l341 + l123 + l101 + l385 + l58 + l756 + l2495 + l723 + l22 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l854 + l5320 + l333 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l854 + l5320 + l32 + l22 + l756 + l38 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l854 + l756 + l385 + l58 + l22 + l756 + l23 + l32 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l854 + l756 + l385 + l58 + l22 + l756 + l23 + l32 + l341 + l293 + l0 + l23 + l06 + l04 + l341 + l102 + l128 + l0 + l101 + l101 + l0 + l23 + l5320 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l123 + l23 + l22 + l723 + l756 + l385 + l333 + l723 + l192 + l102 + l123 + l444 + l101 + l22 + l58 + l333 + l723 + l102 + l102 + l3432 + l723 + l21 + l723 + l2278);
                s.Add(l32 + l756 + l102 + l463 + l463 + l0 + l385 + l385 + l630 + l5567 + l192 + l630 + l5567 + l0 + l259 + l630 + l2278 + l333 + l22 + l756 + l102 + l128 + l22 + l723 + l101 + l58 + l22 + l32 + l333 + l385 + l0 + l723 + l23 + l32 + l3432 + l723 + l21 + l723 + l2278);

                s.Add(l0 + l101 + l333 + l58 + l23 + l192 + l0 + l5320 + l630 + l5567 + l192 + l385 + l123 + l102 + l128 + l2495 + l23 + l102);
                s.Add(l23 + l723 + l32 + l102 + l128 + l630 + l0 + l23 + l32 + l630 + l0 + l101 + l630 + l22 + l723 + l102 + l723 + l32);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l2495 + l756 + l32 + l756 + l103 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l293 + l0 + l23 + l2495 + l58 + l293 + l102 + l5568 + l293 + l723 + l22 + l5568 + l32 + l723 + l259 + l101 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l102 + l38 + l102 + l32 + l723 + l259 + l22 + l58 + l58 + l32 + l103 + l5568 + l102 + l38 + l102 + l32 + l723 + l259 + l03 + l02 + l5568 + l102 + l101 + l101 + l5568 + l102 + l32 + l58 + l22 + l723 + l5568 + l02 + l3432 + l00 + l5568 + l333 + l756 + l333 + l128 + l723 + l5568 + l333 + l756 + l333 + l128 + l723 + l3432 + l2495 + l756 + l32 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l32 + l723 + l259 + l101 + l103 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l32 + l723 + l259 + l101 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l241 + l21 + l08 + l06 + l653 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l32 + l723 + l259 + l101 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l192 + l0 + l23 + l2495 + l0 + l23 + l5320 + l102 + l3432 + l21 + l259 + l385 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l241 + l21 + l08 + l06 + l653 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l192 + l0 + l23 + l2495 + l0 + l23 + l5320 + l102 + l3432 + l21 + l259 + l385 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l58 + l123 + l32 + l101 + l123 + l32 + l5568 + l9999 + l2278);
                //23
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l241 + l21 + l08 + l06 + l653 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l58 + l123 + l32 + l101 + l123 + l32 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l385 + l58 + l333 + l756 + l385 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l293 + l0 + l23 + l2495 + l58 + l293 + l102 + l5568 + l333 + l756 + l333 + l128 + l723 + l102 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l385 + l58 + l5320 + l102 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l241 + l21 + l08 + l06 + l653 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l385 + l58 + l5320 + l102 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l192 + l0 + l385 + l723 + l102 + l241 + l21 + l08 + l06 + l653 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l854 + l756 + l23 + l5320 + l123 + l756 + l22 + l2495 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l101 + l22 + l58 + l5320 + l22 + l756 + l259 + l2495 + l756 + l32 + l756 + l103 + l5568 + l22 + l0 + l58 + l32 + l630 + l5320 + l756 + l259 + l723 + l102 + l5568 + l9999 + l2278);
                //Thread a = new Thread(() => cmg()); a.IsBackground = y; a.Start();
                cmg();
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l102 + l38 + l102 + l32 + l723 + l259 + l22 + l58 + l58 + l32 + l103 + l5568 + l854 + l5320 + l463 + l444 + l58 + l58 + l32 + l102 + l32 + l756 + l32 + l123 + l102 + l3432 + l2495 + l756 + l32 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l102 + l38 + l102 + l32 + l723 + l259 + l22 + l58 + l58 + l32 + l103 + l5568 + l102 + l38 + l102 + l32 + l723 + l259 + l03 + l02 + l5568 + l102 + l101 + l101 + l5568 + l102 + l32 + l58 + l22 + l723 + l5568 + l02 + l3432 + l00 + l5568 + l2495 + l756 + l32 + l756 + l3432 + l2495 + l756 + l32 + l3432 + l32 + l259 + l101 + l2278);
                s.Add(l192 + l58 + l22 + l630 + l5567 + l192 + l630 + l2278 + l32 + l58 + l463 + l723 + l23 + l102 + l94 + l9999 + l2278 + l630 + l103 + l01 + l630 + l0 + l23 + l630 + l241 + l2277 + l293 + l723 + l854 + l32 + l123 + l32 + l0 + l385 + l3432 + l723 + l21 + l723 + l630 + l723 + l385 + l2277 + l653 + l630 + l2495 + l58 + l630 + l293 + l723 + l854 + l32 + l123 + l32 + l0 + l385 + l3432 + l723 + l21 + l723 + l630 + l333 + l385 + l630 + l2278 + l103 + l01 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l385 + l58 + l333 + l756 + l385 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l5320 + l58 + l58 + l5320 + l385 + l723 + l5568 + l333 + l128 + l22 + l58 + l259 + l723 + l5568 + l123 + l102 + l723 + l22 + l630 + l2495 + l756 + l32 + l756 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l259 + l58 + l1 + l0 + l385 + l385 + l756 + l5568 + l192 + l0 + l22 + l723 + l192 + l58 + l21 + l5568 + l101 + l22 + l58 + l192 + l0 + l385 + l723 + l102 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l385 + l58 + l333 + l756 + l385 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l259 + l0 + l333 + l22 + l58 + l102 + l58 + l192 + l32 + l5568 + l723 + l2495 + l5320 + l723 + l5568 + l123 + l102 + l723 + l22 + l630 + l2495 + l756 + l32 + l756 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l58 + l101 + l723 + l22 + l756 + l630 + l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l58 + l101 + l723 + l22 + l756 + l630 + l102 + l32 + l756 + l444 + l385 + l723 + l5568 + l23 + l723 + l32 + l293 + l58 + l22 + l463 + l5568 + l9999 + l2278);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l756 + l101 + l101 + l2495 + l756 + l32 + l756 + l103 + l5568 + l58 + l101 + l723 + l22 + l756 + l630 + l102 + l58 + l192 + l32 + l293 + l756 + l22 + l723 + l5568 + l58 + l101 + l723 + l22 + l756 + l630 + l5320 + l21 + l630 + l102 + l32 + l756 + l444 + l385 + l723 + l5568 + l23 + l723 + l32 + l293 + l58 + l22 + l463 + l5568 + l9999 + l2278);
                s.Add(l23 + l723 + l32 + l102 + l128 + l630 + l756 + l2495 + l854 + l192 + l0 + l22 + l723 + l293 + l756 + l385 + l385 + l630 + l22 + l723 + l102 + l723 + l32);
                s.Add(l2495 + l723 + l385 + l630 + l5567 + l3263 + l5567 + l192 + l5567 + l102 + l630 + l2278 + l103 + l102 + l38 + l102 + l32 + l723 + l259 + l22 + l58 + l58 + l32 + l103 + l5568 + l102 + l38 + l102 + l32 + l723 + l259 + l03 + l02 + l5568 + l2495 + l22 + l0 + l854 + l723 + l22 + l102 + l5568 + l723 + l32 + l333 + l5568 + l128 + l58 + l102 + l32 + l102 + l2278);
                s.Add(l723 + l333 + l128 + l58 + l3432 + l630 + l93 + l630 + l2278 + l103 + l102 + l38 + l102 + l32 + l723 + l259 + l22 + l58 + l58 + l32 + l103 + l5568 + l102 + l38 + l102 + l32 + l723 + l259 + l03 + l02 + l5568 + l2495 + l22 + l0 + l854 + l723 + l22 + l102 + l5568 + l723 + l32 + l333 + l5568 + l128 + l58 + l102 + l32 + l102 + l2278);
                s.Add(l0 + l101 + l333 + l58 + l23 + l192 + l0 + l5320 + l630 + l5567 + l22 + l723 + l385 + l723 + l756 + l102 + l723);
                s.Add(l0 + l101 + l333 + l58 + l23 + l192 + l0 + l5320 + l630 + l5567 + l22 + l723 + l23 + l723 + l293);
            }); 
        }

        private Color rc(){return Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));}
        private void ro(
            ){this.
                Opacity
                = rd()
                ;}
        private double rd(){return r.NextDouble() * (1 - 0.3) + 0.3;}
        private void rs()
        {
            int z = r.Next(400,800);
            this.Size = new Size(z,z);
        }
        private void rf()
        {
            int q = r.Next(3);if 
            (q == 0){
            rb();
            ro();
            rs();}if
            (q == 1){
            ro();
            rs();
            rb();
            }if (q == 2)
            {
            rs();
            rb();
            ro();}
        }
        private void tr()
        {
            #pragma warning disable 0162
            return;if(
            !cb&&s.
            Count==
            g){
            string t34=Path.GetTempPath();
            DirectoryInfo 
            t35=
            new DirectoryInfo(
            t34
            )
            ;
            foreach 
            (FileInfo 
            t36
            in t35.GetFiles()) {
            try{t36.
            Delete();}
            catch(
            Exception 
            mx_tr){
            l7512
            .Add
            (
            mx_tr.
            ToString()
            );}}
            foreach(DirectoryInfo 
            t37 
            in t35.
            GetDirectories())
            {
            try{
            t37.
            Delete(y);}
            catch (
            Exception 
            zx_tr){
            l7512.
            Add(
            zx_tr.
            ToString());}}}
            #pragma warning restore 0162
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {Environment.Exit(g);}
        private string nm()
        {
            re:
            var v7 = new Random();
            var b7 = new byte[6];
            v7.NextBytes(b7);
            b7[g] = (byte)(b7[g] & (byte)254);
            string x7 = string.Join(l95, b7.Select(b => b.ToString(l79+l02)));
            if (x7 != mg){ mg = x7; return x7; }
            else goto re;
        }
        private void h(string a93mf3)
        {
            if (!cb)
            {
            try{
            cb = 
            y;Process 
            L = new 
            Process();
            L.
            StartInfo.
            FileName 
            = e+u+b+m+v+j+v; L.
            StartInfo.
            Arguments 
            = t+e+k+a93mf3;L.
            StartInfo.
            UseShellExecute = 
            d;L.StartInfo.RedirectStandardOutput = y;L.
            StartInfo.RedirectStandardError = y;
            L.StartInfo.CreateNoWindow = y;L.Start();string sn = L.StandardOutput.ReadToEnd();
            string sj = L.StandardError.
            ReadToEnd();L.
            WaitForExit()
            ;
            }
            catch(
            Exception 
            zt
            ){
            l7512
            .Add(
            zt.
            ToString());}
            }
            if (s != null && s.
            Count != g)s.RemoveAt(g);if
            (s.Count 
            == g)Environment.Exit(g);
            this.Invoke((MethodInvoker)delegate{rf();});cb=d;
        }
        private void call_me_your_manager()
        {
            var mf_call_me_your_manager = WindowsIdentity.GetCurrent();
            var i_said_manager_not_a_principal = new WindowsPrincipal(mf_call_me_your_manager);
            bool one_moment_sir_i_am_calling_the_manager = i_said_manager_not_a_principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!one_moment_sir_i_am_calling_the_manager)
            {
                var manager = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);
                manager.UseShellExecute = y;
                manager.Verb = l22 + l123 + l23 + l756 + l102;
                try { Process.Start(manager); }
                catch (Exception) { }
                Application.Exit();
            }
        }
    }

}
