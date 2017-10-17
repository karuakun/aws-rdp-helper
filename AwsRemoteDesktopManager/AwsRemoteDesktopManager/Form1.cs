using System;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime.CredentialManagement;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwsRemoteDesktopManager
{
    public partial class Form1 : Form
    {
        //public string RegionName { get; set; } = "ap-northeast-1";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            SetCurrentProfile("Default");
            await ShowEc2Instances();
        }

        private async void lstEc2Instances_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ShowEc2InstanceDetail();
        }

        private void btnLaunchRsc_Click(object sender, EventArgs e)
        {
            var privateIpAddress = txtPrivateIpAddress.Text;
            Process.Start("mstsc.exe", $"/v:{privateIpAddress}");
        }

        private void SetCurrentProfile(string profileName)
        {
            var profile = GetAwsProfile(profileName);
            if (null == profile)
            {
                return;
            }
            txtProfileName.Text = profile.Name;
            txtAccessKey.Text = profile.Options.AccessKey;
            txtRegion.Text = profile.Region.DisplayName;
        }

        public async Task<IEnumerable<Instance>> GetEc2Instances()
        {
            var client = new AmazonEC2Client();
            var result = await client.DescribeInstancesAsync();
            return result
                ?.Reservations
                ?.SelectMany(r => r.Instances);
        }

        private async Task ShowEc2Instances()
        {
            var instances = (await GetEc2Instances())
                ?.Where(i => PlatformValues.Windows == i.Platform)
                ?.Select(i => new { Instance = i, Display = $"{i.Tags.FirstOrDefault(t => t.Key == "Name")?.Value}" })
                ?.ToList();
            if (null == instances)
            {
                return;
            }
            lstEc2Instances.DisplayMember = "Display";
            lstEc2Instances.ValueMember = "Instance";
            lstEc2Instances.DataSource = instances;
        }

        public async Task ShowEc2InstanceDetail()
        {
            var instance = lstEc2Instances.SelectedValue as Instance;
            if (null == instance)
            {
                return;
            }
            txtPassword.Text = await GetEc2Password(instance);
            txtPrivateIpAddress.Text = instance.PrivateIpAddress;
        }

        //public CredentialProfile RegisterAwsProfile(string profileName, string accessKey, string secretKey)
        //{
        //    var profile = new CredentialProfile(profileName, new CredentialProfileOptions
        //    {
        //        AccessKey = accessKey,
        //        SecretKey = secretKey,
        //    });
        //    profile.Region = RegionEndpoint.GetBySystemName(RegionName);

        //    var credentialFile = new NetSDKCredentialsFile();
        //    credentialFile.RegisterProfile(profile);

        //    return profile;
        //}
        //public List<CredentialProfile> GetAwsProfiles()
        //{
        //    var credentialFile = new NetSDKCredentialsFile();
        //    return credentialFile.ListProfiles();
        //}

        public CredentialProfile GetAwsProfile(string profileName)
        {
            var credentialFile = new NetSDKCredentialsFile();
            CredentialProfile profile = null;
            if (!credentialFile.TryGetProfile(profileName, out profile))
            {
                return null;
            }
            return profile;
        }

        public async Task<string> GetEc2Password(Instance instance)
        {
            var client = new AmazonEC2Client();
            var result = await client.GetPasswordDataAsync(new GetPasswordDataRequest
            {
                InstanceId = instance.InstanceId
            });
            if (string.IsNullOrEmpty(result.PasswordData))
            {
                return string.Empty;
            }
            var keyLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Key\key.cer");
            var key = File.ReadAllText(keyLocation);
            return result.GetDecryptedPassword(key);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://aws.amazon.com/jp/powershell/");
        }


    }
}
