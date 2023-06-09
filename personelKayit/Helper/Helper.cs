﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelKayit.Helper
{
    public static class Helper
    {
        public static void FormuTemizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }

                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }

                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }

                else if(control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }

                else if (control is RadioButton)
                {
                    if(((RadioButton)control).Text == "Erkek")
                    {
                        ((RadioButton)control).Checked = true;
                    }
                }

                else if (control is GroupBox)
                {
                   
                    
                   FormuTemizle(control.Controls);
                   
                }

            }
        }
    }
}
