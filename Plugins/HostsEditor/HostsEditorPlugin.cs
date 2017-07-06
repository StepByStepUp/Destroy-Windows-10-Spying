﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWS.Plugins;

namespace HostsEditor
{
    public class HostsEditorPlugin : AbstractPlugin
    {
        private Hosts m_editor;
        public override string Name => "HostsEditor";
        public override string Author => "Main writed nummer - refactpring sergius-dart.";
        public override string Version => "0.0.1";

        public override string Description => @"Default plugin for add spy domains to hosts file.";
        
        public HostsEditorPlugin()
        {
            State = STATE.NONE;
            m_editor = new Hosts();
#if DEBUG
            //MessageBox.Show(@"Plugin Loaded");
#endif
        }

        private object _ui = new Settings();
        public override object UIControl => _ui;
        

    }
}
