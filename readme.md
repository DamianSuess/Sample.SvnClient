# SVN Client Example

This basic SVN CLient shows you how to connect to your SVN Repository with a user name and password and either download or view the log.

### Applying SVN Credientials
```cs
  using (var client = new SvnClient())
  {
    // Login SSL ------------
    client.Authentication.Clear();
    client.Authentication.DefaultCredentials = new System.Net.NetworkCredential(user, pass);
    client.Authentication.SslServerTrustHandlers += LoginSslOverride;

  // ..
  client.CheckOut(repo, path);
```
