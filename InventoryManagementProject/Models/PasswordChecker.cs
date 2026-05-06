using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public enum PasswordStrength
    {
        Low,
        Medium,
        Strong
    }
    public class PasswordChecker
    {
        public PasswordStrength GetPasswordStrength(string password)
        {
            if (password.Length < 6)
                return PasswordStrength.Low;

            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSymbol = password.Any(ch => !char.IsLetterOrDigit(ch));
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);

            if (password.Length >= 8 && hasLetter && hasDigit && hasSymbol && hasUpper && hasLower)
                return PasswordStrength.Strong;

            if (password.Length >= 6 && hasLetter && hasDigit)
                return PasswordStrength.Medium;

            return PasswordStrength.Low;
        }
    }
}
