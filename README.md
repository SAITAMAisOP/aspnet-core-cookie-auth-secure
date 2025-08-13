# ASP.NET Core Cookie Authentication with Claims

This is a sample ASP.NET Core MVC project demonstrating **cookie-based authentication** with **claims** and security best practices applied.

## Features

* User login with **username/password** (hardcoded for demo purposes)
* Cookie authentication with:

  * `HttpOnly = true` → prevents JavaScript access to cookies
  * `SameSite = Strict` → mitigates CSRF attacks
  * `SecurePolicy = Always` → cookies sent only over HTTPS
* Custom claims:

  * `Name`
  * `Email`
  * `Country`
* Logout functionality
* Protected endpoints using `[Authorize]`
* **Content Security Policy (CSP)** applied via meta tag:

  ```html
  <meta http-equiv="Content-Security-Policy"
        content="default-src 'none'; script-src 'self'; connect-src 'self'; img-src 'self';
                 style-src 'self'; base-uri 'self'; form-action 'self'">
  ```

  This helps prevent XSS, data injection, and other code-injection attacks.

## Technologies

* ASP.NET Core MVC
* Cookie Authentication (`Microsoft.AspNetCore.Authentication.Cookies`)
* Claims-based authorization
* Content Security Policy (CSP)
* .NET 7/8 (or specify your version)

## Setup

1. Clone the repository:

```bash
git clone git@github.com:Omar-Zhioua/aspnet-core-cookie-auth-secure.git
```
