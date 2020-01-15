using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using Sports4All.UserControls_Items;

namespace Sports4All
{
    public partial class UC_Events : UserControl
    {
        public UC_Events()
        {
            InitializeComponent();
        }

        private void UC_Events_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }

        private void PopulateItems()
        {
            flpEvents.Controls.Clear();

            List<String> imageList = new List<string>
            {
                "https://dovethemes.com/wp-content/uploads/2016/12/Eiffel-Tower-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Space-Debris.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Small-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Island-of-Love.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/12/Dinosaur-Theme.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Forest-Waterfall.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Central-Park.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Sea-Turtle.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Endless-Fields.jpg",
                "https://dovethemes.com/wp-content/uploads/2016/09/Mountain-Sunrise.jpg"
            };

            ImageList img = new ImageList {ImageSize = new Size(140, 140), ColorDepth = ColorDepth.Depth32Bit};

            UC_EventItem[] listItems = new UC_EventItem[imageList.Count];

            for (int i = 0; i < imageList.Count; i++)
            {
                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(imageList[i]);
                MemoryStream stream = new MemoryStream(imageByte);

                listItems[i] = new UC_EventItem {Title = "Título do evento " + i, Image = Image.FromStream(stream)};

                flpEvents.Controls.Add(listItems[i]);
            }
        }

        private Image RoundCorners(Image image, int cornerRadius)
        {
            cornerRadius *= 2;
            Bitmap roundedImage = new Bitmap(image.Width, image.Height);
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            gp.AddArc(0 + roundedImage.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            gp.AddArc(0 + roundedImage.Width - cornerRadius, 0 + roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            gp.AddArc(0, 0 + roundedImage.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.SetClip(gp);
                g.DrawImage(image, Point.Empty);
            }
            return roundedImage;
        }
    }
}
