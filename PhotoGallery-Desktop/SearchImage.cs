using BusinessLogicLayer;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PhotoGallery_Desktop
{
	public partial class SearchImage : Form
	{
		public SearchImage()
		{
			InitializeComponent();

			InitializeWebView();
		}
		private void button1_Click(object sender, EventArgs e)
		{
		}

		private async void InitializeWebView()
		{
			await webViewMap.EnsureCoreWebView2Async(null);
			webViewMap.CoreWebView2.Settings.IsWebMessageEnabled = true;
			LoadOpenStreetMap();
		}

		private void LoadOpenStreetMap()
		{
			string html = @"
        <html>
        <head>
            <meta charset='utf-8' />
            <meta name='viewport' content='width=device-width, initial-scale=1.0' />
            <title>OpenStreetMap with Leaflet</title>
            <link rel='stylesheet' href='https://unpkg.com/leaflet/dist/leaflet.css' />
        </head>
        <body>
            <div id='map' style='width: 100%; height: 80vh;'></div>
            <script src='https://unpkg.com/leaflet/dist/leaflet.js'></script>
            <script>
                window.onload = function() {
                    var map = L.map('map').setView([37.7749, -122.4194], 8);
                    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                        attribution: '© OpenStreetMap contributors'
                    }).addTo(map);

                    var marker;
                    map.on('click', function(e) {
                        var lat = e.latlng.lat.toFixed(6);
                        var lng = e.latlng.lng.toFixed(6);

                        if (marker) {
                            map.removeLayer(marker);
                        }

                        marker = L.marker([lat, lng]).addTo(map);
                        if (window.chrome.webview) {
                            window.chrome.webview.postMessage(lat + ', ' + lng);
                        }
                    });
                };
            </script>
        </body>
        </html>";

			webViewMap.NavigateToString(html);
			webViewMap.WebMessageReceived += WebViewMap_WebMessageReceived;
		}

		private void WebViewMap_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
		{
			string latLon = e.WebMessageAsJson.Trim('"');
			lblLocationName.Text = "Selected Coordinates: " + latLon;
		}

		
	}

}
