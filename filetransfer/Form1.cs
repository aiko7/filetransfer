using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
namespace filetransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BROWSE FILE

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "All Files|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = fileDialog.FileName;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //START LISTENING
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            //STOP LISTENING
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //SEND FILE

            string filePath = txtFilePath.Text;  // File to send
            string ip = txtIP.Text;              // Receiver IP 
            string port = txtPort.Text;          // Port 

            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                MessageBox.Show("Please select a file, enter an IP address, and specify a port.");
                return;
            }

            // Path to the full Nmap installation
            string nmapPath = @"C:\Program Files (x86)\Nmap"; //FIGURE OUT DEPENDENECIES THIS IS ONLY A TEMP FIX 
            string ncatPath = Path.Combine(nmapPath, "ncat.exe");

            if (!File.Exists(ncatPath))
            {
                MessageBox.Show("Error: ncat.exe not found in Nmap directory!");
                return;
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c \"\"{ncatPath}\" {ip} {port} < \"{filePath}\"\"",
                    UseShellExecute = false,
                    WorkingDirectory = nmapPath,  // Set working directory to Nmap folder with all dependencies
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    // Capture output and error
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    // Check the exit code
                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show($"Error occurred (Exit code: {process.ExitCode}): {error}");
                    }
                    else
                    {
                        MessageBox.Show("File transfer complete!");
                    }

                    // Show any output from ncat (for debugging)
                    if (!string.IsNullOrEmpty(output))
                    {
                        MessageBox.Show($"ncat output: {output}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}