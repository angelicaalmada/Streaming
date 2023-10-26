using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApiVideo.Api;
using ApiVideo.Client;
using ApiVideo.Model;


namespace Streaming
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            var apiKey = "SjaEhidlsHHznZHAw0efMf6TDUZpsBy335FlwuUQ79v";

            var apiVideoClient = new ApiVideoClient(apiKey);
            
            var videoPayload = new VideoCreationPayload()
            {
                title = txtNombre.Text,
                description = txtDescripcion.Text,
                mp4support = true,
                tags = new List<string>()
            {
                "first","video","test","c#","client"
            }
            };
            Stream myVideoFile = fuVideo.FileContent;
           
            try
            {
                var newVideo = apiVideoClient.Videos().create(videoPayload);
                var video = apiVideoClient.Videos().upload(newVideo.videoid, myVideoFile);

                txtURL.Text = video.assets.player;
                lit.Text = video.assets.iframe;
                
            }
            catch (ApiException ex)
            {
                //Console.WriteLine(e.ErrorCode);
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }

        }
}
}