using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using SharpSvn;

namespace SimpleSvnClient
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      txtPath.Text = @"C:\temp\svn-export\";
      txtRepo.Text = @"https://svn.testhost.com";
      txtUser.Text = "USER";
      txtPass.Text = "PASSWORD";
    }

    private void LoginSslOverride(object sender, SharpSvn.Security.SvnSslServerTrustEventArgs e)
    {
      e.AcceptedFailures = e.Failures;
      e.Save = true;
    }

    private void BtnLogHistory_Click(object sender, EventArgs e)
    {
      Uri repo = new Uri(txtRepo.Text);
      string path = txtPath.Text;
      string user = txtUser.Text;
      string pass = txtPass.Text;

      DateTime startDttm = new DateTime();
      DateTime endDttm = new DateTime();

      using (var client = new SvnClient())
      {
        // Login SSL ------------
        client.Authentication.Clear();
        client.Authentication.DefaultCredentials = new System.Net.NetworkCredential(user, pass);
        client.Authentication.SslServerTrustHandlers += LoginSslOverride;

        //client.Authentication.SslServerTrustHandlers += delegate (object sender, SharpSvn.Security.SvnSslServerTrustEventArgs e)
        //{
        //  e.AcceptedFailures = e.Failures;
        //  e.Save = true;
        //};

        // Method 1 -------------
        //client.Authentication.Clear();
        //client.Authentication.ForceCredentials(user, pass);

        // Method 2 -------------
        //client.Configuration.SetOption("servers", "global", "http-auth-types", "basic;digest");
        //client.Authentication.Clear();
        // client.Authentication.DefaultCredentials = new System.Net.NetworkCredential(user, pass);

        //var range = new SvnRevisionRange(
        //  new SvnRevision(startDttm), new SvnRevision(endDttm));

        try
        {
          Collection<SvnLogEventArgs> logItems = new Collection<SvnLogEventArgs>();
          client.GetLog(repo, out logItems);
          foreach (var item in logItems)
          {
            Console.WriteLine($"Rev: {item.Revision} - {item.Time}");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine("ERROR: " + ex.Message);
          Console.WriteLine("ERROR: " + ex.ToString());
        }

        return;
        client.CheckOut(repo, path);

        //SvnUriTarget target = new SvnUriTarget(txtRepo.Text);
        //
        //if (client.CheckOut(target, path, checkoutArgs, out updateResult))
        //{
        //}
      }
    }

    private void BtnCheckout_Click(object sender, EventArgs e)
    {
      Uri repo = new Uri(txtRepo.Text);
      string path = txtPath.Text;
      string user = txtUser.Text;
      string pass = txtPass.Text;

      DateTime startDttm = new DateTime();
      DateTime endDttm = new DateTime();

      using (var client = new SvnClient())
      {
        // Login SSL ------------
        client.Authentication.Clear();
        client.Authentication.DefaultCredentials = new System.Net.NetworkCredential(user, pass);
        client.Authentication.SslServerTrustHandlers += LoginSslOverride;

        this.Text = "Check-out repo in progress...";

        try
        {
          client.Progress += Client_Progress;
          client.Processing += Client_Processing;
          client.CheckOut(repo, path);

          //SvnUriTarget target = new SvnUriTarget(txtRepo.Text);
          //if (client.CheckOut(target, path, checkoutArgs, out updateResult))
          //{
          //}
          client.Progress -= Client_Progress;
        }
        catch (Exception ex)
        {
          Console.WriteLine("ERROR: " + ex.Message);
          Console.WriteLine("ERROR: " + ex.ToString());
        }
        // Managed Debugging Assistant 'ContextSwitchDeadlock'
        //The CLR has been unable to transition from COM context 0xbbb260 to COM context 0xbbb1a8 for 60 seconds.The thread that owns the destination context / apartment is most likely either doing a non pumping wait or processing a very long running operation without pumping Windows messages.This situation generally has a negative performance impact and may even lead to the application becoming non responsive or memory usage accumulating continually over time.To avoid this problem, all single threaded apartment(STA) threads should use pumping wait primitives(such as CoWaitForMultipleHandles) and routinely pump messages during long running operations.

        /*
          The CLR has been unable to transition from COM context 0xbbb260 to COM context 0xbbb1a8
          for 60 seconds.The thread that owns the destination context / apartment is most likely
          either doing a non pumping wait or processing a very long running operation without
          pumping Windows messages.This situation generally has a negative performance impact and
          may even lead to the application becoming non responsive or memory usage accumulating
          continually over time.To avoid this problem, all single threaded apartment(STA) threads
          should use pumping wait primitives(such as CoWaitForMultipleHandles) and routinely pump
          messages during long running operations.
        */
        this.Text = "FINISHED Checkout!";

        return;
      }
    }

    private void Client_Processing(object sender, SvnProcessingEventArgs e)
    {
      var x = e.CommandType;
      Console.WriteLine($"Processing... '{e.CommandType}'");
    }

    private void Client_Progress(object sender, SvnProgressEventArgs e)
    {
      var stats = $"Total: {e.TotalProgress} - Progress: {e.Progress}";
      lblProgress.Text = "Progress - " + stats;
      Console.WriteLine(stats);
    }
  }
}