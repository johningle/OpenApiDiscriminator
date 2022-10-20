# Overview
This is an example project demonstrating how to segregate an ASP.NET Swashbuckle-based REST API into separate JSON specification endpoints using OpenAPI groups.
It divides it's API into separate `public` and `private` definitions.
This is intended to enable Azure API Management reconfiguration in CI/CD pipelines.

## Reviewing the Solution
Starting with a default ASP.NET Web API solution, I removed all extraneous comments, made the necessary changes, and supplemented with explanatory comments in-line as needed.
Please review the comments for detailed explanation.