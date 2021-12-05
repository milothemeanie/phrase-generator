using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phrase_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void btnCreate_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            lblMessage.Text = string.Empty;

            if (!IsValid())
            {
                lblMessage.Visible = true;
                return;
            }

            var keywordRawText = txtKeyword.Text.Trim();
            var keywords = keywordRawText?.Split(new string[] { Environment.NewLine}, StringSplitOptions.None);

            List<string> outputPhrases = new List<string>();

            foreach (string keyword in keywords)
            {
                outputPhrases.Add(txtPhrase.Text.Replace(txtMask.Text, keyword));
            }


            var currentDir = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            var writelocation = currentDir + "\\" + txtFileName.Text;
            var exists = File.Exists(writelocation);

            if (exists)
            {
                var filename = Path.GetFileNameWithoutExtension(writelocation);
                var search = true;

                int count = 1;
                while (search)
                {
                    var fileCheck = $"{currentDir}\\{filename}_{count}{Path.GetExtension(txtFileName.Text)}";
                    if (!File.Exists(fileCheck))
                    {
                        search = false;
                        writelocation = fileCheck;
                    }
                    count++;
                   
                }

            }

            await File.WriteAllLinesAsync(writelocation, outputPhrases);

            lblMessage.Text = $"Success! \n File has been written to:\n {writelocation}";
            lblMessage.Visible = true;
        }

        private bool IsValid()
        {
            var valid = true;

            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                lblMessage.Text = "File Name cannot be empty";
                valid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtMask.Text))
            {
                lblMessage.Text = "Mask cannot be empty";
                valid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtPhrase.Text))
            {
                lblMessage.Text = "Phrase cannot be empty";
                valid = false;
            }
            else if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                lblMessage.Text = "Keywords cannot be empty";
                valid = false;
            }

            return valid;
        }

    }
}
