//===============================================================================
// Microsoft FastTrack for Azure
// Speech SDK Samples
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
using Pubs.Data.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class FListPublishers : Form
    {
        private BindingSource _bindingSource = new BindingSource();

        public FListPublishers()
        {
            InitializeComponent();
        }

        public FListPublishers(List<Publisher> publishers)
        {
            InitializeComponent();
            grdPublishers.Dock = DockStyle.Fill;
            grdPublishers.AutoGenerateColumns = true;
            _bindingSource.DataSource = publishers;
            grdPublishers.DataSource = _bindingSource;
        }
    }
}
