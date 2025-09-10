using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Utilities
{
    internal static class ValidationHelper
    {
        public static bool IsNotEmpty(TextBox textBox, ErrorProvider errorProvider, string errorMessage = "This field is required.")
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, errorMessage);
                return false;
            }

            errorProvider.SetError(textBox, string.Empty);
            return true;
        }

        public static bool IsNumeric(TextBox textBox, ErrorProvider errorProvider, string errorMessage = "Only numbers are allowed.")
        {
            if (!Regex.IsMatch(textBox.Text, @"^\d+$"))
            {
                errorProvider.SetError(textBox, errorMessage);
                return false;
            }

            errorProvider.SetError(textBox, string.Empty);
            return true;
        }

        public static bool IsValidEmail(TextBox textBox, ErrorProvider errorProvider, string errorMessage = "Invalid email address.")
        {
            if (!Regex.IsMatch(textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(textBox, errorMessage);
                return false;
            }

            errorProvider.SetError(textBox, string.Empty);
            return true;
        }

    }
}
