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
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Pubs.Data.Models;
using Pubs.Services;
using Pubs.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class FMain : Form
    {
        AudioConfig _audioConfig;
        SpeechConfig _speechConfig;
        SpeechRecognizer _speechRecognizer;
        PhraseListGrammar _phraseListGrammar;
        IPubsService _pubsService;
        FListAuthors _frmListAuthors;
        FListPublishers _frmListPublishers;

        public FMain()
        {
            InitializeComponent();
            _audioConfig = AudioConfig.FromMicrophoneInput(ConfigurationManager.AppSettings["DeviceId"]);
            _speechConfig = SpeechConfig.FromSubscription(ConfigurationManager.AppSettings["SubscriptionKey"], ConfigurationManager.AppSettings["Region"]);
            _speechRecognizer = new SpeechRecognizer(_speechConfig, _audioConfig);
            _speechRecognizer.Recognizing += _speechRecognizer_Recognizing;
            _speechRecognizer.Recognized += _speechRecognizer_Recognized;
            _phraseListGrammar = PhraseListGrammar.FromRecognizer(_speechRecognizer);
            _phraseListGrammar.AddPhrase("list authors");
            _phraseListGrammar.AddPhrase("list publishers");
            _phraseListGrammar.AddPhrase("close authors");
            _phraseListGrammar.AddPhrase("close publishers");
            _pubsService = new PubsService();
        }

        private void _speechRecognizer_Recognizing(object sender, SpeechRecognitionEventArgs e)
        {
            txtRecognizing.Invoke(new Action(() => txtRecognizing.Text = e.Result.Text));
        }

        private void _speechRecognizer_Recognized(object sender, SpeechRecognitionEventArgs e)
        {
            if (e.Result.Reason == ResultReason.RecognizedSpeech)
            {
                txtRecognized.Invoke(new Action(() => txtRecognized.Text = e.Result.Text));
                string phrase = e.Result.Text.ToLower();
                if (phrase.Contains("list authors"))
                {
                    List<Author> authors = _pubsService.ListAuthors();
                    this.Invoke(new Action(() => this.ListAuthors(authors)));
                }
                else if (phrase.Contains("close authors"))
                {
                    this.Invoke(new Action(() => this.CloseAuthors()));
                }
                else if (phrase.Contains("list publishers"))
                {
                    List<Publisher> publishers = _pubsService.ListPublishers();
                    this.Invoke(new Action(() => this.ListPublishers(publishers)));
                }
                else if (phrase.Contains("close publishers"))
                {
                    this.Invoke(new Action(() => this.ClosePublishers()));
                }
            }
            else if (e.Result.Reason == ResultReason.NoMatch)
            {
                txtRecognized.Invoke(new Action(() => txtRecognized.Text = "Speech could not be recognized."));
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await _speechRecognizer.StartContinuousRecognitionAsync();
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await _speechRecognizer.StopContinuousRecognitionAsync();
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
    }
}
