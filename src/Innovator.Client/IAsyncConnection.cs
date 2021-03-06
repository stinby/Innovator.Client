namespace Innovator.Client
{
  /// <summary>
  /// Interface for a connection to an Aras Innovator instance that allows asynchronous calls
  /// </summary>
  public interface IAsyncConnection : IConnection
  {
    /// <summary>
    /// Calls a SOAP action asynchronously
    /// </summary>
    /// <param name="request">Request AML and possibly files <see cref="UploadCommand"/></param>
    /// <param name="async">Whether to perform this action asynchronously</param>
    /// <returns>A promise to return an XML SOAP response as a <see cref="System.IO.Stream"/></returns>
    IPromise<System.IO.Stream> Process(Command request, bool async);

    /// <summary>
    /// Hashes the credentials for use with logging in or workflow voting
    /// </summary>
    /// <param name="credentials">The credentials.</param>
    /// <param name="async">Whether to perform this action asynchronously</param>
    /// <returns>A promise to return hashed credentials</returns>
    IPromise<ExplicitHashCredentials> HashCredentials(ICredentials credentials, bool async);
  }
}
