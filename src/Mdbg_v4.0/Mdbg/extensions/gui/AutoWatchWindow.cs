//---------------------------------------------------------------------
//  This file is part of the CLR Managed Debugger (mdbg) Sample.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//---------------------------------------------------------------------
#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

using System.Globalization;
using Microsoft.Samples.Tools.Mdbg;
using Microsoft.Samples.Debugging.MdbgEngine;
using Microsoft.Samples.Tools.Mdbg.Extension;
using Microsoft.Samples.Debugging.CorDebug.NativeApi;

namespace gui
{
    partial class AutoWatchWindow : DebuggerToolWindow
    {
        public AutoWatchWindow(MainForm mainForm)
            : base(mainForm)
        {
            InitializeComponent();
            // Hook handler for lazily expanding
            treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeSelect);
        }

        // Called On UI thread.
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            Util.TryExpandNode(MainForm, e.Node);
        }

        // Called On UI thread.
        protected override void RefreshToolWindowInternal()
        {
            MDbgFrame frame = null;

            MDbgValue[] locals = null;
            MDbgValue[] args = null;

            MainForm.ExecuteOnWorkerThreadIfStoppedAndBlock(delegate(MDbgProcess proc)
            {
                frame = GetCurrentFrame(proc);
                if (frame == null)
                {
                    return;
                }

                // Add Vars to window.            
                MDbgFunction f = frame.Function;

                locals = f.GetActiveLocalVars(frame);
                args = f.GetArguments(frame);

                if (proc.IsEvalSafe())
                    EvalWatch(proc);
            });

            if (frame == null)
            {
                return;
            }

            // Reset
            TreeView t = this.treeView1;
            t.BeginUpdate();
            t.Nodes.Clear();

            // Add Vars to window.            
            if (locals != null)
            {
                foreach (MDbgValue v in locals)
                {
                    Util.PrintInternal(MainForm, v, t.Nodes);
                }
            }

            if (args != null)
            {
                foreach (MDbgValue v in args)
                {
                    Util.PrintInternal(MainForm, v, t.Nodes);
                }
            }

            t.EndUpdate();


        } // refresh

        void EvalWatch(MDbgProcess proc)
        {
            Console.WriteLine("-------------------");
            try
            {
                //public class Test { public int MyProp { get; set; } }
                //...
                //var t = new Test();                            
                //t.MyProp = 9;
                string expression = "t.MyProp";
                expression = "printer";
                //expression = "d";

                MDbgValue value = proc.ResolveVariable(expression, proc.Threads.Active.CurrentFrame);

                if (value != null)
                {
                    //Console.WriteLine(expression + ": " + value.InvokeToString());
                    //Console.WriteLine(expression + ": " + value.InvokeMethod("Test").InvokeToString());
                    Console.WriteLine(expression + ": " + value.InvokeMethod("Ping"));
                    //Console.WriteLine(expression + ": " + value.InvokeMethod("Who").InvokeToString());
                    //Console.WriteLine(expression + ": " + value.InvokeMethod("Who1").InvokeToString());
                    //Console.WriteLine(expression + ": " + value.GetStringValue(false));
                }
                Console.WriteLine("#################");
            }
            catch
            {
                //expressionValue = "<items/>";
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("-------------------");
        }
    } // AutoWatchWindow
}