# sha-hash-generator

This is a c# dotnet core command line application for generating the hash for custom QuadPay gateway integrations.

See [Signing Requests](https://docs.quadpay.com/docs/custom-integration-guide#signing-requests) in the QP docs.

## Usage

```sh
$ dotnet run ./ExampleBody.json merchant_client_secret
09df2k3nfoinhsdjofu0a89sdhfnik
```

Which can then be used in ...
