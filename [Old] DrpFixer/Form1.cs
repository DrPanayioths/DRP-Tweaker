using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrpFixer
{
    public partial class drpdownloader : Form
    {
        public drpdownloader()
        {
            InitializeComponent();
        }

        private void drpdownloader_Load(object sender, EventArgs e)
        {


        }

        private void dnsrunner_Click(object sender, EventArgs e)
        {
            var process = new Process();
            var dns = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = false,
                Arguments = @"/K powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61 & powercfg.cpl
"
            };

            process.StartInfo = dns;
            process.Start();

        }

        private void Mouseopt_Click(object sender, EventArgs e)
        {
            var processm = new Process();
            var mousel = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = false,
                Arguments = @"/C Reg.exe add ""HKCU\Control Panel\Accessibility\StickyKeys"" /v ""Flags"" /t REG_SZ /d ""506"" /f & Reg.exe add ""HKCU\Control Panel\Accessibility\MouseKeys"" /v ""Flags"" /t REG_SZ /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\Mouse"" /v ""MouseSpeed"" /t REG_SZ /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\Mouse"" /v ""MouseThreshold1"" /t REG_SZ /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\Mouse"" /v ""MouseThreshold2"" /t REG_SZ /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\Mouse"" /v ""MouseSensitivity"" /t REG_SZ /d ""10""
"
            };
            processm.StartInfo = mousel;
            processm.Start();

        }

        private void keybord_click(object sender, EventArgs e)
        {
            var processkeybo = new Process();
            var keyopt = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = false,
                Arguments = @"/C Reg.exe add ""HKCU\Control Panel\Keyboard"" /v ""KeyboardDelay"" /t REG_SZ /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\Keyboard"" /v ""KeyboardSpeed"" /t REG_SZ /d ""31"" /f "
            };
            processkeybo.StartInfo = keyopt;
            processkeybo.Start();
        }

        private void TheCreator_Click(object sender, EventArgs e)
        {

        }

        private void computenchn_Click(object sender, EventArgs e)
        {
            var processcomput = new Process();
            var computerenchan = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                Arguments = @"/K Reg.exe add ""HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize"" /v ""EnableTransparency"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\Windows Feeds"" /v ""EnableFeeds"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft"" /v ""AllowNewsAndInterests"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKLM\SOFTWARE\Policies\Microsoft\Windows\System"" /v ""EnableActivityFeed"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKCU\Control Panel\International\User Profile"" /v ""HttpAcceptLanguageOptOut"" /t REG_DWORD /d ""1"" /f & Reg.exe add ""HKCU\Software\Microsoft\Windows\CurrentVersion\AdvertisingInfo"" /v ""Enabled"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKLM\Software\Policies\Microsoft\Windows\System"" /v ""EnableActivityFeed"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"" /v ""DisallowShaking"" /t REG_DWORD /d ""1"" /f & Reg.exe add ""HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"" /v ""EnableBalloonTips"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"" /v ""ShowSyncProviderNotifications"" /t REG_DWORD /d ""0"" /f & Reg.exe add ""HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userNotificationListener"" /v ""Value"" /t REG_SZ /d ""Deny"" /f & Reg.exe add ""HKLM\Software\Policies\Microsoft\Windows\AdvertisingInfo"" /v ""DisabledByGroupPolicy"" /t REG_DWORD /d ""1"" /f & Reg.exe add ""HKCU\SOFTWARE\Microsoft\GameBar"" /v ""AllowAutoGameMode"" /t REG_DWORD /d ""1"" /f  & Reg.exe add ""HKCU\SOFTWARE\Microsoft\GameBar"" /v ""AutoGameModeEnabled"" /t REG_DWORD /d ""1"" /f  & Reg.exe add ""HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\System"" /v ""AllowExperimentation"" /t REG_DWORD /d ""0"" /f  & Reg.exe add ""HKLM\SOFTWARE\Microsoft\PolicyManager\default\System\AllowExperimentation"" /v ""value"" /t REG_DWORD /d ""0"" /f & Reg Add HKCU\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications /v GlobalUserDisabled /t REG_DWORD /d 1 /f & %windir%\system32\SystemPropertiesPerformance.exe & del /q/f/s %TEMP%\  "
            };
            processcomput.StartInfo = computerenchan;
            processcomput.Start();
        }

        private void spotfPrem_Click(object sender, EventArgs e)
        {
            string remoteUri = "https://github.com/SpotX-Official/SpotX/releases/download/1.8/Install_New_theme.bat";
            string fileName = "Install_New_theme.bat", Spotify = null;
            Spotify = remoteUri + fileName;
            WebClient myWebClient = new WebClient();
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, Spotify);
            myWebClient.DownloadFile(remoteUri, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, Spotify);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);
            
            string filename = "Install_New_theme.bat";
            string parameters = $"/k \"{filename}\"";
            Process.Start("cmd", parameters);
        }

        private void Viber_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://download.cdn.viber.com/desktop/windows/ViberSetup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Viber-Setup.msi");
            client.DownloadFile(url, downloadpath);
            Runmsi(downloadpath);

        }

        private void Signal_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://updates.signal.org/desktop/signal-desktop-win-6.44.0.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Viber-Setup.msi");
            client.DownloadFile(url, downloadpath);
            Runmsi(downloadpath);
        }

        private void element_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://packages.riot.im/desktop/install/win32/x64/Element%20Setup.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Viber-Setup.msi");
            client.DownloadFile(url, downloadpath);
            Runmsi(downloadpath);
        }

        private void netoptimize_Click(object sender, EventArgs e)
        {
            var neopt = new Process();
            var optimizenet = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                Arguments = "netsh interface tcp set heuristics disabled & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Parameters\" /v \"autodisconnect\" /t REG_DWORD /d \"4294967295\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Parameters\" /v \"EnableOplocks\" /t REG_DWORD /d \"0\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Parameters\" /v \"IRPStackSize\" /t REG_DWORD /d \"20\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\" /v \"TcpTimedWaitDelay\" /t REG_DWORD /d \"30\" /f & \r\nreg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\" /v \"MaxUserPort\" /t REG_DWORD /d \"65534\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\" /v \"TcpMaxDupAcks\" /t REG_DWORD /d \"2\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\" /v \"Tcp1323Opts\" /t REG_DWORD /d \"1\" /f & reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\" /v \"DefaultTTL\" /t REG_DWORD /d \"64\" /f & ipconfig /release & ipconfig /renew & ipconfig /flushdns & netsh int ip reset & netsh int ipv4 reset & netsh int ipv6 reset & netsh int tcp reset & netsh winsock reset & netsh advfirewall reset & netsh branchcache reset & netsh http flush logbuffer & reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v \"NetworkThrottlingIndex\" /t REG_DWORD /d \"4294967295\" /f"
            };
            neopt.StartInfo = optimizenet;
            neopt.Start();
        }

        private void avastanti_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://www.avast.com/el-gr/download-thank-you.php?product=FAV-ONLINE-HP&locale=el-gr&direct=1";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Avast-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);
        }

        private void bitdefend_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://download.bitdefender.com/windows/installer/en-us/bitdefender_avfree.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "BitDefender-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);

        }

        private void Aviraa_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = "https://package.avira.com/download/spotlight-windows-bootstrapper/avira_en_sptl1_eda087091538f108__pcmag.exe";
            string downfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            downfolder = Path.Combine(downfolder, "Downloads");
            string downloadpath = Path.Combine(downfolder, "Avira-Setup.exe");
            client.DownloadFile(url, downloadpath);
            RunDownloadedExecutable(downloadpath);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 form2 = new form2();
            form2.Show();
            this.Hide();
        }
    }
}

