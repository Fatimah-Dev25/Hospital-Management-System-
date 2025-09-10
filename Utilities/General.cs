using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Utilities
{
    internal static class General
    {

        public static List<string> GetSystemInfoAndNews() => new List<string>()
        {
            "🆕 New Feature Added:\n  Roles & Permissions management is now available.\n",
            "📊 Statistics: \n  Over 10,000 patients have been registered since the system launch.\n",
            "📅 Administrative Note: \n  Next Friday is an official hospital holiday.\n",
            "🔒 Security Update: \n  Two-Factor Authentication has been enabled for login."
        };

        public static List<string> GetSystemTips() => new List<string>() {

            "💡 Tip: Use the quick search to access patients faster.\n\n",
            "🔗 Shortcut: Ctrl + N to add a new patient.\n\n",
            "⚠️ Note: Make sure to save your changes before exiting."
        };
    }
}
