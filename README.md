# Idfy .NET SDK
[![Build Status](https://travis-ci.org/idfy-io/idfy-sdk-net.svg?branch=master)](https://travis-ci.org/idfy-io/idfy-sdk-net) [![NuGet](https://img.shields.io/nuget/v/Idfy.SDK.svg)](https://www.nuget.org/packages/Idfy.SDK)

A .NET SDK for simple integration with the Idfy REST API.

Supports .NET Standard 2.0+, .NET Core 2.0+ and .NET Framework 4.6.1+.

## Installation
Using NuGet is the easiest way to install the SDK.

Package Manager:

	PM > Install-Package Idfy.SDK

.NET Core CLI:  

	dotnet add package Idfy.SDK

## Documentation
- [Idfy REST API Reference](https://developer.signicat.io/apis/overview.html)
- [Idfy Developer Documentation](https://developer.signicat.io/docs)


## Sample Usage
The example below shows how to get the details of a specific document.

```csharp
// Set your credentials and desired scopes
IdfyConfiguration.SetClientCredentials("clientId", "clientSecret",
    new[] {OAuthScope.DocumentRead, OAuthScope.DocumentWrite});

// Make a call to retrieve the document
var signatureService = new SignatureService();
var document = signatureService.GetDocument(documentId);

Console.WriteLine($"Retrieved document: {document.Title}");
```

## Support
- Open an [issue](https://github.com/idfy-io/idfy-sdk-net/issues) to report bugs or submit feature requests.
- For other support requests, visit our [support page](https://support.idfy.io) or contact us at [support@idfy.io](mailto:support@idfy.io).
