using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.Forms
{
    public static class UIEnhancer
    {
        // Visar progressbar och inaktiverar den knapp som användaren klickade på
        public static async Task RunLoadingBar(ProgressBar progressBar, Control button)
        {
            // Visar progressbar
            if (progressBar != null)
            {
                progressBar.Visible = true;
            }
            // Inaktiverar knapp
            if (button != null)
            {
                button.Enabled = false;
            }

            await Task.Delay(800); // Kort fördröjning
            progressBar?.Value = 0;
            // Döljer progressbar och aktiverar knapp igen
            progressBar?.Visible = false;
            button?.Enabled = true;
        }
        // Visar en notifikation i formulär som försvinner efter 1.8 sekunder
        public static async Task DisplayNotification(Label label, string message, string color)
        {
            label.ForeColor = Color.FromName(color); // Sätter färgen på texten i labeln
            label.Text = message; // Meddelandet
            label.Visible = true; // Visar labeln
            await Task.Delay(1800); // Väntar i 1,8 sekunder
            label.Visible = false; // Döljer labeln igen
        }
    }
}
