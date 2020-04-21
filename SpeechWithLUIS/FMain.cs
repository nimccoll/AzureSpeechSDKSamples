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
using Microsoft.CognitiveServices.Speech.Intent;
using Newtonsoft.Json;
using Pubs.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace SpeechWithLUIS
{
    public partial class FMain : Form
    {
        AudioConfig _audioConfig;
        SpeechConfig _speechConfig;
        IntentRecognizer _speechRecognizer;
        HttpClient _httpClient;

        public FMain()
        {
            InitializeComponent();
            _audioConfig = AudioConfig.FromMicrophoneInput(ConfigurationManager.AppSettings["DeviceId"]);
            _speechConfig = SpeechConfig.FromSubscription(ConfigurationManager.AppSettings["SubscriptionKey"], ConfigurationManager.AppSettings["Region"]);
            _speechRecognizer = new IntentRecognizer(_speechConfig, _audioConfig);
            LanguageUnderstandingModel model = LanguageUnderstandingModel.FromAppId(ConfigurationManager.AppSettings["ApplicationId"]);
            _speechRecognizer.AddAllIntents(model);
            _speechRecognizer.Recognizing += _speechRecognizer_Recognizing; ;
            _speechRecognizer.Recognized += _speechRecognizer_Recognized; ;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["APIBaseUrl"]);
        }

        private void _speechRecognizer_Recognized(object sender, IntentRecognitionEventArgs e)
        {
            if (e.Result.Reason == ResultReason.RecognizedIntent)
            {
                txtRecognized.Invoke(new Action(() => txtRecognized.Text = $"Intent Id: { e.Result.IntentId }"));
                if (e.Result.IntentId == "GetShowTimes")
                {
                    dynamic luisJSON = JsonConvert.DeserializeObject(e.Result.Properties.GetProperty(PropertyId.LanguageUnderstandingServiceResponse_JsonResult));
                    if (luisJSON.entities != null)
                    {
                        string city = string.Empty;
                        string state = string.Empty;
                        foreach (dynamic entity in luisJSON.entities)
                        {
                            if (entity.type.Value == "builtin.geographyV2.city")
                            {
                                city = entity.entity.Value;
                            }
                            else if (entity.type.Value == "builtin.geographyV2.state")
                            {
                                state = GetStateCode(entity.entity.Value);
                            }
                        }
                        if (!string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(state))
                        {
                            string url = $"/api/showtimes?city={city}&state={state}&date={DateTime.Today.ToString("MM-dd-yyyy")}";
                            HttpResponseMessage apiResult = _httpClient.GetAsync(url).Result;
                            dynamic showTimes = JsonConvert.DeserializeObject(apiResult.Content.ReadAsStringAsync().Result);
                            txtShowTimes.Invoke(new Action(() => txtShowTimes.Text = showTimes.ToString()));
                        }
                    }
                }
            }
            else if (e.Result.Reason == ResultReason.RecognizedSpeech)
            {
                txtRecognized.Invoke(new Action(() => txtRecognized.Text = $"Intent not recognized. Text: {e.Result.Text}"));
            }
            else if (e.Result.Reason == ResultReason.NoMatch)
            {
                txtRecognized.Invoke(new Action(() => txtRecognized.Text = "Speech could not be recognized."));
            }
        }

        private void _speechRecognizer_Recognizing(object sender, IntentRecognitionEventArgs e)
        {
            txtRecognizing.Invoke(new Action(() => txtRecognizing.Text = e.Result.Text));
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await _speechRecognizer.StartContinuousRecognitionAsync();
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await _speechRecognizer.StopContinuousRecognitionAsync();
        }

        private string GetStateCode(string stateName)
        {
            string stateCode = string.Empty;
            KeyValuePair<string, string> state = State.List.FirstOrDefault(s => s.Value.ToLower() == stateName);
            if (!string.IsNullOrEmpty(state.Key)) stateCode = state.Key;

            return stateCode;
        }
    }
}
