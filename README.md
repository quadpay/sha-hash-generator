# sha-hash-generator

This is a c# dotnet core command line application to demonstrate how to programmatically generate the HMAC-SHA256 one-way hash signature for custom QuadPay gateway integrations. It can be used as a model for translating into other languages.

See [Signing Requests](https://docs.quadpay.com/docs/custom-integration-guide#signing-requests) in the QP docs.

## Requirements

Requires dotnet core runtime or SDK to run. Works on Windows, macOS and Linux.

Download [here](https://dotnet.microsoft.com/download)

## Usage

You will need a json request body saved in a file, with the path to the file as the first argument, and the client secret as the second argument.

```sh
$ dotnet run ./ExampleBody.json merchant_client_secret
tr4Ki42bm1Hc8JWtqQ1ZNsVvBR5AJY704cBbr0oFiuE=
```

Which can then be used in the custom gateway API.
