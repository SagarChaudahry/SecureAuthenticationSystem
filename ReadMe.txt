SecureAuthenticationSystem

Description
SecureAuthenticationSystem is an ASP.NET Core MVC project that implements a robust and secure authentication mechanism. It includes features such as user registration, login with reCAPTCHA integration, password change functionality, and email verification.

Features
- User Registration
- User Login with reCAPTCHA
- Password Change
- Email Verification
- Secure Password Hashing (using ASP.NET Core Identity)

Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- Microsoft.AspNetCore.Identity
- SQL Server
- reCAPTCHA v2

Project Structure
- Controllers:
  - AccountController: Handles user authentication operations
  - AuthenticationController: Additional authentication views
  - HomeController: Manages home page and general navigation
- Models:
  - Users: Custom user model extending IdentityUser
- ViewModels:
  - LoginViewModel
  - RegisterViewModel
  - VerifyEmailViewModel
  - ChangePasswordViewModel
- Views:
  - Account: Login, Register, VerifyEmail, ChangePassword
  - Authentication: Login, Register
  - Home: Index, Privacy

Setup and Configuration
1. Clone the repository
2. Open the solution in Visual Studio
3. Update the connection string in `appsettings.json` to point to your SQL Server instance
4. Update the reCAPTCHA secret key in `appsettings.json`
5. Run the following commands in the Package Manager Console:


Add-Migration InitialCreate
Update-Database
Copy6. Build and run the application

Configuration
- Database connection string and reCAPTCHA secret key are stored in `appsettings.json`
- Password requirements and other identity options are configured in `Program.cs`

Usage
After setting up the project:
1. Run the application
2. Navigate to the Register page to create a new account
3. Use the Login page to sign in
4. Use the "Forgot Password" link on the Login page to reset your password

Security Features
- Password hashing using ASP.NET Core Identity
- reCAPTCHA integration for bot protection
- Password strength meter on registration
- Configurable password requirements (length, complexity, etc.)
