using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;

namespace CalcNota {
    [Activity(Label = "CalcNota", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
             
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }

        public void Calcular() {
            Button btnCalc = FindViewById<Button>(Resource.Id.calcular);

            btnCalc.Click += delegate {
                double aux1, aux2;
                TextView res = FindViewById<TextView>(Resource.Id.showStatus);
                aux1 = Convert.ToDouble(FindViewById<TextView>(Resource.Id.editNota1).Text);
                aux2 = Convert.ToDouble(FindViewById<TextView>(Resource.Id.editNota2).Text);

                double tmp = ((aux1 * 6) + (aux2 * 4)) / 10;

                if (tmp >= 6) {
                    res.Text = "Aprovado";
                } else if (tmp < 6 && tmp >= 4) {
                    res.Text = "Prova Final";
                } else if (tmp < 4) {
                    res.Text = "Reprovado";
                }
            };
        }
    }
}

