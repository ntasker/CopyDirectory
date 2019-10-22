using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CopyDirectoryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //disable copy button until source and destination have been selected
            CopyButton.Enabled = false;
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            var fileBrowser = new FolderBrowserDialog();
            fileBrowser.ShowDialog();

            //Fill source text box when source has been selected
            if (IsPathSelected(fileBrowser.SelectedPath))
            {
                SourceText.Text = fileBrowser.SelectedPath;
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            var fileBrowser = new FolderBrowserDialog();
            fileBrowser.ShowDialog();

            //Fill destination text box when destination has been selected
            if (IsPathSelected(fileBrowser.SelectedPath))
            {
                DestinationText.Text = fileBrowser.SelectedPath;
            }
        }

        //enable copy button if both source and destination box has a value
        private void SourceText_TextChanged(object sender, EventArgs e)
        {
            CopyButton.Enabled = IsSourseAndDestinationSelected();
        }

        //enable copy button if both source and destination box has a value
        private void DestinationText_TextChanged(object sender, EventArgs e)
        {
            CopyButton.Enabled = IsSourseAndDestinationSelected();
        }

        //check path is not null or contains whitespace
        private bool IsPathSelected(String path)
        {
            return !string.IsNullOrWhiteSpace(path);
        }

        //check both source and destination text boxes contain a value
        private bool IsSourseAndDestinationSelected()
        {
            return IsPathSelected(SourceText.Text) && IsPathSelected(DestinationText.Text);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {

            //temporarily disable copy button
            CopyButton.Enabled = false;
            //keep track of the task progress with a Progress object
            var progressUpdates = new Progress<string>(updateProgress);

            //Submit the copying proces to the threadpool
            Task.Run(() =>
            {

                var copyDir = new CopyDirectoryLibrary.CopyDirectory(progressUpdates);
                copyDir.CopyDir(SourceText.Text, DestinationText.Text);
            }).ContinueWith(antecedent =>
            {
                displayExceptions(antecedent);
                //re-eneble the copy button
                Invoke((MethodInvoker)delegate
                {
                    CopyButton.Enabled = true;
                });

            });

        }

        //Inform the user on which files have been succesfully copied
        private void updateProgress(string fileCopied)
        {
            filesCopiedListbox.Items.Add(fileCopied);
        }

        //Display any errors to the user
        private static void displayExceptions(Task task)
        {
            if (task.Status == TaskStatus.Faulted)
            {
                var exception = task.Exception;
                if (exception != null)
                {
                    foreach (var innerException in exception.InnerExceptions)
                    {
                        MessageBox.Show(innerException.Message);
                    }
                }
            }
        }

    }
}
