﻿//===============================================================================
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
using Pubs.Services;
using Pubs.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace SpeechOffline
{
    public partial class FMain : Form
    {
        SpeechRecognitionEngine _recognizer = null;
        IPubsService _pubsService;
        FListAuthors _frmListAuthors;
        FListPublishers _frmListPublishers;

        public FMain()
        {
            InitializeComponent();
            _recognizer = new SpeechRecognitionEngine();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(new string[] { "list authors", "close authors", "list publishers", "close publishers" }))));
            _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
            _recognizer.SetInputToDefaultAudioDevice();
            _pubsService = new PubsService();
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtRecognized.Invoke(new Action(() => txtRecognized.Text = e.Result.Text));
            switch (e.Result.Text)
            {
                case "list authors":
                    List<Author> authors = _pubsService.ListAuthors();
                    this.Invoke(new Action(() => this.ListAuthors(authors)));
                    break;
                case "close authors":
                    this.Invoke(new Action(() => this.CloseAuthors()));
                    break;
                case "list publishers":
                    List<Publisher> publishers = _pubsService.ListPublishers();
                    this.Invoke(new Action(() => this.ListPublishers(publishers)));
                    break;
                case "close publishers":
                    this.Invoke(new Action(() => this.ClosePublishers()));
                    break;
                default:
                    break;
            }
        }


        private void ListAuthors(List<Author> authors)
        {
            _frmListAuthors = new FListAuthors(authors);
            _frmListAuthors.Show();
        }

        private void CloseAuthors()
        {
            if (_frmListAuthors != null)
            {
                _frmListAuthors.Close();
            }
        }

        private void ListPublishers(List<Publisher> publishers)
        {
            _frmListPublishers = new FListPublishers(publishers);
            _frmListPublishers.Show();
        }

        private void ClosePublishers()
        {
            if (_frmListPublishers != null)
            {
                _frmListPublishers.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _recognizer.RecognizeAsyncStop();
        }
    }
}
