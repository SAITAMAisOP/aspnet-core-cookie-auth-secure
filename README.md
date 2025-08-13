# ASP.NET Core Cookie Authentication with Claims

This is a sample ASP.NET Core MVC project demonstrating **cookie-based authentication** with **claims** and security best practices applied.

## Features

- User login with **username/password** (hardcoded for demo purposes)
- Cookie authentication with:
    - `HttpOnly = true` → prevents JavaScript access to cookies
    - `SameSite = Strict` → mitigates CSRF attacks
    - `SecurePolicy = Always` → cookies sent only over HTTPS
- Custom claims:
    - `Name`
    - `Email`
    - `Country`
- Logout functionality
- Protected endpoints using `[Authorize]`

## Technologies

- ASP.NET Core MVC
- Cookie Authentication (`Microsoft.AspNetCore.Authentication.Cookies`)
- Claims-based authorization
- .NET 7/8 (or specify your version)

## Setup

1. Clone the repository:

```bash
git clone git@github.com:Omar-Zhioua/aspnet-core-cookie-auth-secure.git