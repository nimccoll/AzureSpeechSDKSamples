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
    public partial class FListAuthors : Form
    {
        private BindingSource _bindingSource = new BindingSource();

        public FListAuthors()
        {
            InitializeComponent();
        }

        public FListAuthors(List<Author> authors)
        {
            InitializeComponent();
            grdAuthors.Dock = DockStyle.Fill;
            grdAuthors.AutoGenerateColumns = true;
            _bindingSource.DataSource = authors;
            grdAuthors.DataSource = _bindingSource;
        }
    }
}
