using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.UI
{
    public static class UIEnhancer
    {
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
    }
}
