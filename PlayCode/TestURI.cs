using System;
using System.Diagnostics;
using System.Net;

class TestURI
{
	public TestURI(string uriPath)
	{
		UriPath = uriPath ?? throw new ArgumentNullException(nameof(uriPath));
	}

	string UriPath;
	Uri siteUri = new Uri("http://www.contoso.com/");

	public void GetUriSystem()
	{
		siteUri = new Uri(UriPath);
		WebRequest wr = WebRequest.Create(siteUri);
	}

	public void GetUriString()
	{
		//siteUri = new Uri(UriPath);
		WebRequest wr = WebRequest.Create(UriPath);
	}


}
