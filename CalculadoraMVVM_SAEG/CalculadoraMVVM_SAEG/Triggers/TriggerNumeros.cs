using CalculadoraMVVM_SAEG.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CalculadoraMVVM_SAEG.Triggers
{
    public class TriggerNumeros : TriggerAction<Button>
    {
        public Label TargetLabel { get; set; }
        protected override void Invoke(Button sender)
        {
            if(sender.ClassId == "Numero")
                TargetLabel.Text += sender.Text;
        }
    }
}
