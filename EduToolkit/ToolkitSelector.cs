using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduToolkits
{
    public partial class ToolkitSelector : Form
    {
        public ToolkitSelector()
        {
            InitializeComponent();
        }

        private void convertorButton_Click(object sender, EventArgs e)
        {
            ApplicationQueue.InstanceAddFormQueue(new Convertor.Convertor());
        }

        private void flipDirPicsButton_Click(object sender, EventArgs e)
        {
            ApplicationQueue.InstanceAddFormQueue(new FlipThisPic.FlipPicForm());
        }

        private void jsonViewerButton_Click(object sender, EventArgs e)
        {
            ApplicationQueue.InstanceAddFormQueue(new JsonViewer.JsonLoader());
        }

        private void SentencesToImagesButton_Click(object sender, EventArgs e)
        {
            ApplicationQueue.InstanceAddFormQueue(new SentencesToImages.SentencesToImages());
        }
    }
}
