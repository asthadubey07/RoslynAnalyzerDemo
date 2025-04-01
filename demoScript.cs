using System;

namespace RoslynAnalyzerDemo
{
    /// <summary>
    /// Demonstrates proper naming conventions and coding rules.
    /// </summary>
    public class UserProfile
    {
        private string _username;  // ✅ Correct private field naming (_camelCase)

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));  // ✅ Null check enforced
        }

        /// <summary>
        /// Initializes a new user profile with a username.
        /// </summary>
        /// <param name="username">The username.</param>
        public UserProfile(string username)
        {
            _username = username ?? throw new ArgumentNullException(nameof(username));  // ✅ Prevents null assignment
        }

        /// <summary>
        /// Prints the user details.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine($"User: {_username}");  // ✅ Proper method naming
        }
    }
}
